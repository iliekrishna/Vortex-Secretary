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

                // Preencher campos (mantém igual)
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

                // Inicialmente esconder controles relacionados a mídias e motivo
                btnBaixarMidia.Visible = false;
                lblMotivo.Visible = false;
                txtMotivo.Visible = false;
                // Buscar imagens associadas ao requerimento
                var imagens = RequerimentoDAO.BuscarImagensPorRequerimento(idRequerimento);
                List<ImagemRequerimento> listaImagens = new List<ImagemRequerimento>();
                if (imagens != null && imagens.Count > 0)
                {
                    listaImagens = imagens;
                }
                else if (requerimento.IdImagem.HasValue)
                {
                    var img = RequerimentoDAO.BuscarImagemPorId(requerimento.IdImagem.Value);
                    if (img != null)
                    {
                        listaImagens.Add(img);
                    }
                }

                if (listaImagens.Count > 0)
                {
                    var img = listaImagens[0];  // Usa a primeira para motivo
                    // Mostrar motivo apenas se houver
                    if (!string.IsNullOrEmpty(img.MotivoSegundaVia))
                    {
                        txtMotivo.Text = img.MotivoSegundaVia;
                        lblMotivo.Visible = true;
                        txtMotivo.Visible = true;
                    }

                    // Alinhar com ResponderRequerimento: mostrar botão se houver comprovante ou BO (ou ArquivoResposta para consistência)
                    bool temMidia = listaImagens.Any(i =>
                        !string.IsNullOrEmpty(i.EnderecoComprovante) ||
                        !string.IsNullOrEmpty(i.EnderecoBO) ||
                        (i.ArquivoResposta != null && i.ArquivoResposta.Length > 0));

                    if (temMidia)
                    {
                        btnBaixarMidia.Visible = true;
                        btnBaixarMidia.Tag = listaImagens;
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
                    // Baixar comprovante (sempre, se existir)
                    if (!string.IsNullOrEmpty(img.EnderecoComprovante))
                    {
                        string urlComprovante = new Uri(new Uri(urlBase), img.EnderecoComprovante.Replace("\\", "/")).ToString();
                        string nomeArquivoComprovante = Path.GetFileName(img.EnderecoComprovante);
                        await BaixarArquivoAsync(urlComprovante, nomeArquivoComprovante);
                    }
                    // Baixar BO (sempre, se existir)
                    if (!string.IsNullOrEmpty(img.EnderecoBO))
                    {
                        string urlBO = new Uri(new Uri(urlBase), img.EnderecoBO.Replace("\\", "/")).ToString();
                        string nomeArquivoBO = Path.GetFileName(img.EnderecoBO);
                        await BaixarArquivoAsync(urlBO, nomeArquivoBO);
                    }
                    // Baixar arquivo de resposta da secretaria (se existir)
                    if (img.ArquivoResposta != null && img.ArquivoResposta.Length > 0)
                    {
                        string pastaDownloads = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                        string nomeArquivo = img.NomeArquivoResposta ?? $"Resposta_Secretaria_{idRequerimento}_{img.IdImagem}.pdf";
                        string caminhoDestino = Path.Combine(pastaDownloads, nomeArquivo);
                      
                        try
                        {
                            File.WriteAllBytes(caminhoDestino, img.ArquivoResposta);
                            MessageBox.Show($"Arquivo da secretaria salvo em: {caminhoDestino}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao salvar resposta: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma mídia encontrada para baixar.");
            }
        }
    }    
}
