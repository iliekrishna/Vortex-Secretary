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
                txtTelefone.Text = requerimento.Telefone;
                txtDocumento.Text = requerimento.NomeDocumento;
                txtStatus.Text = requerimento.StatusDocumento;
                txtDataPedido.Text = requerimento.DataPedido?.ToString("dd/MM/yyyy") ?? "";
                txtRespostaEnviada.Text = requerimento.Resposta ?? "";

                // Exibir nome do usuário que respondeu e data da resposta
                if (!string.IsNullOrEmpty(requerimento.Resposta) && requerimento.DataResposta.HasValue && !string.IsNullOrEmpty(requerimento.NomeUsuarioResposta))
                {
                    lblRespondidoPor.Text = $"Respondido por: {requerimento.NomeUsuarioResposta} em {requerimento.DataResposta.Value.ToString("dd/MM/yyyy")}";
                }
                else
                {
                    lblRespondidoPor.Text = "Ainda não respondido.";
                }

                // Mostrar botão para baixar mídia se houver imagem associada
                txtMotivo.Visible = false;
                lblMotivo.Visible = false;
                btnBaixarMidia.Visible = false;
                if (requerimento.IdImagem.HasValue)
                {
                    var img = RequerimentoDAO.BuscarImagemPorId(requerimento.IdImagem.Value);
                    if (img != null && (!string.IsNullOrEmpty(img.EnderecoComprovante) || !string.IsNullOrEmpty(img.EnderecoBO)))
                    {
                        txtMotivo.Text = img.MotivoSegundaVia ?? ""; 
                        txtMotivo.Visible = true;
                        lblMotivo.Visible = true;
                        btnBaixarMidia.Visible = true;
                        btnBaixarMidia.Tag = img;
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
                    // Como WriteAllBytesAsync pode não existir, usamos Task.Run com WriteAllBytes síncrono
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
            if (btnBaixarMidia.Tag is ImagemRequerimento img)
            {
                string urlBase = "http://localhost/Vortex-Web-Forms/main.html"; // URL do localhost para testes

                //string urlBase = "https://www.secretaria.aprenderensinando.com.br/Vortex/"; // URL do servidor (indisponível no momento, usar o localhost acima)

                try
                {
                    if (!string.IsNullOrEmpty(img.EnderecoComprovante))
                    {
                        string urlComprovante = new Uri(new Uri(urlBase), img.EnderecoComprovante.Replace("\\", "/")).ToString();
                        string nomeArquivo = Path.GetFileName(img.EnderecoComprovante);
                        await BaixarArquivoAsync(urlComprovante, nomeArquivo);
                    }

                    if (!string.IsNullOrEmpty(img.EnderecoBO))
                    {
                        string urlBO = new Uri(new Uri(urlBase), img.EnderecoBO.Replace("\\", "/")).ToString();
                        string nomeArquivoBO = Path.GetFileName(img.EnderecoBO);
                        await BaixarArquivoAsync(urlBO, nomeArquivoBO);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao baixar arquivo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma mídia disponível para download.");
            }

        }
    }
}