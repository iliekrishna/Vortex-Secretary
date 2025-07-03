using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Secretary.DAO;

namespace Secretary
{
    public partial class FormEsqueciSenha : Form
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();

        public FormEsqueciSenha()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, insira seu e-mail.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool existe = usuarioDAO.EmailExiste(email);

                if (existe)
                {
                    string mensagemEmail = "Olá, \n\nVocê solicitou a recuperação de senha. " +
                        "Por favor, acesse o sistema e utilize a opção de redefinir senha. " +
                        "Caso não tenha solicitado, ignore esta mensagem.\n\nAtenciosamente,\nSecretaria";

                    EnviarEmailRecuperacao(email, mensagemEmail);

                    MessageBox.Show("Se este e-mail estiver cadastrado, enviaremos instruções para redefinir sua senha.", "Verifique seu e-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("E-mail não encontrado no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar o e-mail:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnviarEmailRecuperacao(string emailDestino, string mensagem)
        {
            try
            {
                var fromAddress = new MailAddress("vortex.esqueci.senha@gmail.com", "Sistema Vortex");
                var toAddress = new MailAddress(emailDestino);
                const string fromPassword = "bdxr oeei vfkj rgoq"; // <-- aqui vai a senha gerada no Gmail
                const string subject = "Recuperação de Senha - Secretaria";

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
                    Subject = subject,
                    Body = mensagem
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
            }
        }
    }
}