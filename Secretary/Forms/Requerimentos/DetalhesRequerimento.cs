using Secretary.DAO;
using Secretary.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;  
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretary.Forms
{
    public partial class DetalhesRequerimento : Form
    {
        private int idRequerimento;
        private Requerimento requerimento;

        public DetalhesRequerimento(int idRequerimento)
        {
            InitializeComponent();
            this.idRequerimento = idRequerimento;
            this.Load += DetalhesRequerimento_Load;
        }

        private void DetalhesRequerimento_Load(object sender, EventArgs e)
        {
            try
            {
                requerimento = RequerimentoDAO.BuscarPorId(idRequerimento);
                if (requerimento == null)
                {
                    MessageBox.Show("Requerimento não encontrado.");
                    this.Close();
                    return;
                }

                // Preencher campos
                txtNome.Text = requerimento.Nome;
                txtRA.Text = requerimento.RA;
                txtCurso.Text = requerimento.Curso;
                txtCPF.Text = requerimento.CPF;
                txtRG.Text = requerimento.RG;
                txtEmail.Text = requerimento.Email;
                txtVinculo.Text = requerimento.TipoVinculo ?? "";
                txtTelefone.Text = requerimento.Telefone;
                txtDocumento.Text = requerimento.NomeDocumento;
                txtStatus.Text = requerimento.StatusDocumento;
                txtDataPedido.Text = requerimento.DataPedido?.ToString("dd/MM/yyyy") ?? "";
                txtRespostaEnviada.Text = requerimento.Resposta ?? "";

                // Exibir nome do usuário que respondeu e data da resposta
                if (!string.IsNullOrEmpty(requerimento.Resposta) && requerimento.DataResposta.HasValue && !string.IsNullOrEmpty(requerimento.NomeUsuarioResposta))
                {
                    lblRespondidoPor.Text = $"Respondido por: {requerimento.NomeUsuarioResposta} em {requerimento.DataResposta.Value:dd/MM/yyyy}";
                }
                else
                {
                    lblRespondidoPor.Text = "Ainda não respondido.";
                }

                // Inicialmente esconder controles relacionados a mídias e motivo
                btnBaixarMidia.Visible = false;
                lblMotivo.Visible = false;
                txtMotivo.Visible = false;

                // Buscar imagens associadas ao requerimento
                var imagens = RequerimentoDAO.BuscarImagensPorRequerimento(idRequerimento);
                List<ImagemRequerimento> listaImagens = new List<ImagemRequerimento>();

                if (imagens != null && imagens.Count > 0)
                {
                    // Usa as imagens encontradas via id_campo
                    listaImagens = imagens;
                }
                else if (requerimento.IdImagem.HasValue)
                {
                    // Fallback: busca via id_imagem (para registros antigos)
                    var img = RequerimentoDAO.BuscarImagemPorId(requerimento.IdImagem.Value);
                    if (img != null)
                    {
                        listaImagens.Add(img);
                    }
                }

                if (listaImagens.Count > 0)
                {
                    var img = listaImagens[0];  // Usa a primeira para motivo (assumindo 1:1)

                    // Mostrar motivo apenas se houver (ex.: para segunda via)
                    if (!string.IsNullOrEmpty(img.MotivoSegundaVia))
                    {
                        txtMotivo.Text = img.MotivoSegundaVia;
                        lblMotivo.Visible = true;
                        txtMotivo.Visible = true;
                    }

                    // Mostrar botão de baixar mídia se houver comprovante ou BO em qualquer imagem
                    bool temMidia = listaImagens.Any(i => !string.IsNullOrEmpty(i.EnderecoComprovante) || !string.IsNullOrEmpty(i.EnderecoBO));
                    if (temMidia)
                    {
                        btnBaixarMidia.Visible = true;
                        btnBaixarMidia.Tag = listaImagens;  // Sempre uma lista
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar detalhes do requerimento: " + ex.Message);
            }
        }

        private async Task BaixarArquivoAsync(string url, string nomeArquivo)
        {
            try
            {
                string pastaDownloads = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string caminhoDestino = Path.Combine(pastaDownloads, nomeArquivo);

                using (HttpClient client = new HttpClient())
                {
                    var bytes = await client.GetByteArrayAsync(url);
                    await Task.Run(() => File.WriteAllBytes(caminhoDestino, bytes));
                }

                MessageBox.Show($"Arquivo baixado em: {caminhoDestino}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao baixar arquivo: " + ex.Message);
            }
        }

        private async void btnBaixarMidia_Click_1(object sender, EventArgs e)
        {
            if (btnBaixarMidia.Tag is List<ImagemRequerimento> imagens && imagens.Count > 0)
            {
                string urlBase = "https://www.secretaria.aprenderensinando.com.br/vortex/";

                foreach (var img in imagens)
                {
                    // Baixar comprovante
                    if (!string.IsNullOrEmpty(img.EnderecoComprovante))
                    {
                        string urlComprovante = new Uri(new Uri(urlBase), img.EnderecoComprovante.Replace("\\", "/")).ToString();
                        string nomeArquivoComprovante = Path.GetFileName(img.EnderecoComprovante);
                        await BaixarArquivoAsync(urlComprovante, nomeArquivoComprovante);
                    }

                    // Baixar BO
                    if (!string.IsNullOrEmpty(img.EnderecoBO))
                    {
                        string urlBO = new Uri(new Uri(urlBase), img.EnderecoBO.Replace("\\", "/")).ToString();
                        string nomeArquivoBO = Path.GetFileName(img.EnderecoBO);
                        await BaixarArquivoAsync(urlBO, nomeArquivoBO);
                    }
                }

                // Para o arquivo resposta da secretaria (blob), buscar separadamente se necessário
                var arquivos = RequerimentoDAO.BuscarArquivosPorRequerimento(idRequerimento);
                if (arquivos.arquivoResposta != null && arquivos.arquivoResposta.Length > 0)
                {
                    string pastaDownloads = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                    string nomeArquivo = arquivos.nomeArquivoResposta ?? $"Resposta_Secretaria_{idRequerimento}.pdf";
                    string caminhoDestino = Path.Combine(pastaDownloads, nomeArquivo);
                    File.WriteAllBytes(caminhoDestino, arquivos.arquivoResposta);
                    MessageBox.Show($"Arquivo da secretaria salvo em: {caminhoDestino}");
                }
            }
            else
            {
                MessageBox.Show("Nenhuma mídia encontrada para baixar.");
            }
        }
    }
}
