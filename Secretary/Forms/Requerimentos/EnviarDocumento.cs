using MySql.Data.MySqlClient;
using Secretary;
using Secretary.DAO;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;

namespace Secretary.Forms.Requerimentos
{
    public partial class EnviarDocumento : Form
    {
        private int idRequerimento;
        private string nomeAluno;
        private string nomeDocumento;
        private string emailDestino;

        private string caminhoArquivoSelecionado = "";
        private int? idDisponibilidade;

        public EnviarDocumento(int idRequerimento, string nomeAluno, string nomeDocumento, string emailDestino)
        {
            InitializeComponent();
            this.idRequerimento = idRequerimento;
            this.nomeAluno = nomeAluno;
            this.nomeDocumento = nomeDocumento;
            this.emailDestino = emailDestino;

            // Buscar id_disponibilidade pelo nome do documento
            this.idDisponibilidade = RequerimentoDAO.ObterIdDisponibilidadePorNomeDoc(nomeDocumento);

            this.Load += EnviarDocumento_Load;
        }

        // Monta mensagem inicial em texto puro (mostrada no TextBox)
        private string MontarMensagemTexto()
        {
            return
                $"Prezado(a) {nomeAluno},\r\n\r\n" +
                $"Conforme solicitado, segue em anexo o documento {nomeDocumento}.\r\n\r\n" +
                "Horário de atendimento:\r\n" +
                "Segunda a sexta, das 8h30 às 22h\r\n\r\n";
        }

        private void EnviarDocumento_Load(object sender, EventArgs e)
        {
            // Mostra a versão limpa no TextBox para o usuário editar
            txtMensagem.Text = MontarMensagemTexto();
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecione o documento para enviar";
                ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp|Arquivos PDF|*.pdf|Todos os arquivos|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    caminhoArquivoSelecionado = ofd.FileName;
                    txtCaminhoArquivo.Text = caminhoArquivoSelecionado;
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(caminhoArquivoSelecionado))
            {
                MessageBox.Show("Por favor, selecione um arquivo para enviar.");
                return;
            }

            try
            {
                SalvarArquivoNoBanco();

                // Pega o que o usuário digitou
                string mensagemTexto = txtMensagem.Text.Trim();

                // Converte para HTML (substitui \r\n por <br>)
                string corpoHtml = mensagemTexto.Replace("\r\n", "<br>");

                // Garante que o rodapé esteja presente
                if (!corpoHtml.Contains("cid:LogoFaculdade"))
                {
                    corpoHtml += "<br><br>Atenciosamente,<br>Secretaria Acadêmica<br>" +
                                 "<img src='cid:LogoFaculdade'>";
                }

                EnviarEmailComAnexo(
                    emailDestino,
                    $"Envio do documento {nomeDocumento}",
                    corpoHtml,
                    caminhoArquivoSelecionado
                );

                MessageBox.Show("E-mail enviado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail ou salvar arquivo:\n" + ex.ToString());
            }
        }

        private void EnviarEmailComAnexo(string emailDestino, string assunto, string corpoHtml, string caminhoArquivo)
        {
            var fromAddress = new MailAddress("vortex.esqueci.senha@gmail.com", "Sistema Vortex");
            var toAddress = new MailAddress(emailDestino);
            const string fromPassword = "bdxr oeei vfkj rgoq"; // senha de app

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = assunto,
                Body = corpoHtml,
                IsBodyHtml = true
            })
            {
                // Anexa o documento selecionado
                if (!string.IsNullOrEmpty(caminhoArquivo))
                {
                    Attachment anexo = new Attachment(caminhoArquivo);
                    message.Attachments.Add(anexo);
                }

                // 🔹 NÃO usar "using" no MemoryStream aqui
                var ms = new MemoryStream();
                Properties.Resources.img_resposta_email.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ms.Position = 0;

                var linkedImage = new LinkedResource(ms, MediaTypeNames.Image.Jpeg)
                {
                    ContentId = "LogoFaculdade"
                };

                string htmlWithImage = corpoHtml.Replace(
                    "<img src='cid:LogoFaculdade'>",
                    $"<img src=\"cid:LogoFaculdade\" style=\"width:471; height:107;\">"
                );

                AlternateView avHtml = AlternateView.CreateAlternateViewFromString(htmlWithImage, null, MediaTypeNames.Text.Html);
                avHtml.LinkedResources.Add(linkedImage);

                message.AlternateViews.Add(avHtml);

                smtp.Send(message);

                ms.Dispose();
            }
        }

        private void SalvarArquivoNoBanco()
        {
            byte[] arquivoBytes = File.ReadAllBytes(caminhoArquivoSelecionado);
            string nomeArquivo = Path.GetFileName(caminhoArquivoSelecionado);
            var requerimento = RequerimentoDAO.BuscarPorId(idRequerimento);
            if (requerimento == null)
                throw new Exception("Requerimento não encontrado.");

            // Buscar imagens existentes para este requerimento
            var imagensExistentes = RequerimentoDAO.BuscarImagensPorRequerimento(idRequerimento);

            if (imagensExistentes != null && imagensExistentes.Count > 0)
            {
                // Atualizar o primeiro registro existente com o arquivo resposta
                int idImagemExistente = imagensExistentes[0].IdImagem;
                RequerimentoDAO.AtualizarArquivoRespostaSecretaria(idImagemExistente, arquivoBytes, nomeArquivo);
            }
            else
            {
                // Se não houver imagens (caso raro), inserir um novo registro com id_campo
                int novoIdImagem = RequerimentoDAO.InserirImagemRespostaSecretariaComIdCampo(idRequerimento, arquivoBytes, nomeArquivo);
                RequerimentoDAO.AtualizarIdImagemRequerimento(idRequerimento, novoIdImagem);
            }
        }
    }
}
