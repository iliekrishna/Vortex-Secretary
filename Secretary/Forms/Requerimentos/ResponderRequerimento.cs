using Secretary.DAO;
using Secretary.Forms.Requerimentos;
using Secretary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretary.Forms
{
    public partial class ResponderRequerimento : Form
    {
        private int idRequerimento;
        private int _idUsuario; 
        private Requerimento requerimento;

        public ResponderRequerimento(int idRequerimento, int usuarioId)
        {
            InitializeComponent();
            this.idRequerimento = idRequerimento;
            this._idUsuario = usuarioId;  
            this.Load += ResponderRequerimento_Load;
        }

        private async Task BaixarArquivoAsync(string url, string nomeArquivo)
        {
            try
            {
                string pastaDownloads = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Downloads"
                );

                // Garantir que a pasta exista
                Directory.CreateDirectory(pastaDownloads);

                string caminhoDestino = Path.Combine(pastaDownloads, nomeArquivo);

                using (var client = new HttpClient())
                using (var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                {
                    response.EnsureSuccessStatusCode();

                    using (var input = await response.Content.ReadAsStreamAsync())
                    using (var output = new FileStream(
                        caminhoDestino,
                        FileMode.Create,
                        FileAccess.Write,
                        FileShare.None,
                        bufferSize: 8192,
                        useAsync: true))
                    {
                        await input.CopyToAsync(output);
                        await output.FlushAsync();
                    }
                }

                MessageBox.Show($"Arquivo baixado em: {caminhoDestino}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao baixar arquivo: " + ex.Message);
            }
        }

        private void ResponderRequerimento_Load(object sender, EventArgs e)
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
                txtVinculo.Text = requerimento.TipoVinculo ?? "";
                txtDataPedido.Text = requerimento.DataPedido?.ToString("dd/MM/yyyy") ?? "";

                // Inicialmente esconder controles relacionados a mídias e motivo
                btnBaixarMidia.Visible = false;
                txtMotivo.Visible = false;
                lblMotivo.Visible = false;

                // Verifica se o documento é Carteira de Identidade Escolar (RA) e se está disponível (id_disponibilidade = 5)
                bool carteiraDisponivel = RequerimentoDAO.DocumentoDisponivel(5);

                if (requerimento.NomeDocumento == "Carteira de Identidade Escolar (RA)" && carteiraDisponivel)
                {
                    if (requerimento.IdImagem.HasValue)
                    {
                        var img = RequerimentoDAO.BuscarImagemPorId(requerimento.IdImagem.Value);

                        if (img != null)
                        {
                            txtMotivo.Text = img.MotivoSegundaVia ?? "";
                            txtMotivo.Visible = true;
                            lblMotivo.Visible = true;

                            if (!string.IsNullOrEmpty(img.EnderecoComprovante) || !string.IsNullOrEmpty(img.EnderecoBO))
                            {
                                btnBaixarMidia.Visible = true;
                                btnBaixarMidia.Tag = img;
                            }
                        }
                    }
                }
                else
                {
                    btnBaixarMidia.Visible = false;
                    txtMotivo.Visible = false;
                    lblMotivo.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar requerimento: " + ex.Message);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string resposta = txtResposta.Text.Trim();

                if (string.IsNullOrEmpty(resposta))
                {
                    MessageBox.Show("Digite uma resposta antes de enviar!");
                    return;
                }

                RequerimentoDAO.AtualizarResposta(idRequerimento, resposta, "Respondido", _idUsuario);

                MessageBox.Show("Resposta enviada com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar resposta: " + ex.Message);
            }
        }

        private async void btnBaixarMidia_Click_1(object sender, EventArgs e)
        {
            if (btnBaixarMidia.Tag is ImagemRequerimento img)
            {

                string urlBase = "https://www.secretaria.aprenderensinando.com.br/vortex/"; // URL do servidor

                if (!string.IsNullOrEmpty(img.EnderecoComprovante))
                {
                    string urlComprovante = new Uri(new Uri(urlBase), img.EnderecoComprovante.Replace("\\", "/")).ToString();
                    string nomeArquivo = Path.GetFileName(img.EnderecoComprovante);
                    await BaixarArquivoAsync(urlComprovante, nomeArquivo);
                }
                if (img.MotivoSegundaVia == "Roubo/Furto" && !string.IsNullOrEmpty(img.EnderecoBO))
                {
                    string urlBO = new Uri(new Uri(urlBase), img.EnderecoBO.Replace("\\", "/")).ToString();
                    string nomeArquivoBO = Path.GetFileName(img.EnderecoBO);
                    await BaixarArquivoAsync(urlBO, nomeArquivoBO);
                }
            }
            else
            {
                MessageBox.Show("Tag do botão não está configurada corretamente.");
            }
        }

        private void btnEnviarDocumento_Click(object sender, EventArgs e)
        {
            if (requerimento == null)
            {
                MessageBox.Show("Requerimento não carregado.");
                return;
            }
            string nomeAluno = requerimento.Nome;
            string nomeDocumento = requerimento.NomeDocumento;
            string emailAluno = requerimento.Email;
            var formEnviar = new EnviarDocumento(idRequerimento, requerimento.Nome, requerimento.NomeDocumento, requerimento.Email);
            formEnviar.ShowDialog();
        }

        private void btnEditarDados_Click(object sender, EventArgs e)
        {
            if (requerimento == null)
            {
                MessageBox.Show("Requerimento não carregado.");
                return;
            }

            var formEditar = new EditarDadosSolicitante(requerimento);
            if (formEditar.ShowDialog() == DialogResult.OK)
            {
                // Atualizar os campos da tela atual após edição
                txtNome.Text = requerimento.Nome;
                txtRA.Text = requerimento.RA;
                txtCurso.Text = requerimento.Curso;
                txtCPF.Text = requerimento.CPF;
                txtRG.Text = requerimento.RG;
                txtEmail.Text = requerimento.Email;
            }
        }



    }
}