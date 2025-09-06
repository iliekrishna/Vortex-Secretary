using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Secretary.DAO;
using Secretary.Models;
using System.Net.Http;

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

                // Verificar se o documento é Carteira de Identidade (id_disponibilidade == 5)
                bool isCarteiraIdentidade = requerimento.IdDisponibilidade.HasValue && requerimento.IdDisponibilidade.Value == 5;

                if (isCarteiraIdentidade && requerimento.IdImagem.HasValue)
                {
                    var img = RequerimentoDAO.BuscarImagemPorId(requerimento.IdImagem.Value);
                    if (img != null)
                    {
                        txtMotivo.Text = img.MotivoSegundaVia ?? "";
                        lblMotivo.Visible = true;
                        txtMotivo.Visible = true;
                    }
                    else
                    {
                        lblMotivo.Visible = false;
                        txtMotivo.Visible = false;
                    }
                }
                else
                {
                    lblMotivo.Visible = false;
                    txtMotivo.Visible = false;
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
            try
            {
                if (requerimento == null || !requerimento.IdImagem.HasValue)
                {
                    MessageBox.Show("Nenhuma mídia disponível para download.");
                    return;
                }

                var arquivos = RequerimentoDAO.BuscarArquivosPorRequerimento(idRequerimento);

                bool temArquivoResposta = arquivos.arquivoResposta != null && arquivos.arquivoResposta.Length > 0;
                bool temComprovante = !string.IsNullOrEmpty(arquivos.enderecoComprovante);
                bool temBO = !string.IsNullOrEmpty(arquivos.enderecoBo);

                if (!temArquivoResposta && !temComprovante && !temBO)
                {
                    MessageBox.Show("Nenhuma mídia disponível para download.");
                    return;
                }

                string urlBase = "https://www.secretaria.aprenderensinando.com.br/vortex/";

                // Baixar arquivo resposta da secretaria
                if (temArquivoResposta)
                {
                    string pastaDownloads = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                    string nomeArquivo = arquivos.nomeArquivoResposta;

                    if (string.IsNullOrEmpty(nomeArquivo))
                    {
                        nomeArquivo = $"Resposta_Secretaria_{idRequerimento}.pdf"; // fallback
                    }

                    string caminhoDestino = Path.Combine(pastaDownloads, nomeArquivo);
                    File.WriteAllBytes(caminhoDestino, arquivos.arquivoResposta);
                    MessageBox.Show($"Arquivo da secretaria salvo em: {caminhoDestino}");
                }

                // Baixar comprovante
                if (temComprovante)
                {
                    string urlComprovante = new Uri(new Uri(urlBase), arquivos.enderecoComprovante.Replace("\\", "/")).ToString();
                    string nomeArquivoComprovante = Path.GetFileName(arquivos.enderecoComprovante);
                    await BaixarArquivoAsync(urlComprovante, nomeArquivoComprovante);
                }

                // Baixar BO
                if (temBO)
                {
                    string urlBO = new Uri(new Uri(urlBase), arquivos.enderecoBo.Replace("\\", "/")).ToString();
                    string nomeArquivoBO = Path.GetFileName(arquivos.enderecoBo);
                    await BaixarArquivoAsync(urlBO, nomeArquivoBO);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao baixar mídia: " + ex.Message);
            }
        }
    }
}