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
        private FormLogin formLogin;

        public FormEsqueciSenha(FormLogin login)
        {
            InitializeComponent();
            this.formLogin = login;
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
                if (!usuarioDAO.EmailExiste(email))
                {
                    MessageBox.Show("E-mail não encontrado no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gera código e salva via método DAO
                string codigo = new Random().Next(100000, 999999).ToString();
                usuarioDAO.SalvarCodigoRedefinicao(email, codigo);

                string mensagemEmail = $"Olá,\n\nSeu código de recuperação de senha é: {codigo}.\nEle é válido por 10 minutos.\n\nAtenciosamente,\nEquipe Vortex";
                EnviarEmailRecuperacao(email, mensagemEmail);

                MessageBox.Show("Código enviado! Verifique seu e-mail.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fecha os formulários e abre o de redefinir senha
                this.Hide();
                formLogin.Hide();
                FormRedefinirSenha redefinirSenha = new FormRedefinirSenha(email);
                redefinirSenha.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar solicitação: " + ex.Message);
            }
        }

        private void EnviarEmailRecuperacao(string emailDestino, string mensagem)
        {
            try
            {
                var fromAddress = new MailAddress("vortex.esqueci.senha@gmail.com", "Sistema Vortex");
                var toAddress = new MailAddress(emailDestino);
                const string fromPassword = "bdxr oeei vfkj rgoq";
                const string subject = "Código de Redefinição de Senha";

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
                MessageBox.Show("Erro ao enviar e-mail:\n" + ex.Message);
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnEnviar.PerformClick();
            }
        }
    }
}
