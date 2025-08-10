using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Secretary.DAO;
using Secretary.Models;

namespace Secretary
{
    public partial class FormLogin : Form
    {
        // Constantes para os placeholders
        private const string PlaceholderEmail = "Inserir e-mail";
        private const string PlaceholderSenha = "Inserir senha";

        // Importa função nativa para criar uma região com cantos arredondados
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public FormLogin()
        {
            InitializeComponent();

            // Aplicar placeholders
            txtUsuario.Text = PlaceholderEmail;
            txtUsuario.ForeColor = Color.Gray;

            txtSenha.Text = PlaceholderSenha;
            txtSenha.ForeColor = Color.Gray;
            txtSenha.UseSystemPasswordChar = false;

            // Layout visual
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));

            // Acessibilidade
            this.AcceptButton = btnEntrar;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == PlaceholderEmail)
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = PlaceholderEmail;
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == PlaceholderSenha)
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
                txtSenha.UseSystemPasswordChar = true;
            }
        }
        private void txtSenha_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.Text = PlaceholderSenha;
                txtSenha.ForeColor = Color.Gray;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private bool CamposValidos(out string mensagemErro)
        {
            mensagemErro = "";

            string email = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            bool emailVazio = string.IsNullOrWhiteSpace(email) || email == PlaceholderEmail;
            bool senhaVazia = string.IsNullOrWhiteSpace(senha) || senha == PlaceholderSenha;

            if (emailVazio && senhaVazia)
            {
                mensagemErro = "Informe o e-mail e a senha.";
                return false;
            }
            if (emailVazio)
            {
                mensagemErro = "Informe o e-mail.";
                return false;
            }
            if (senhaVazia)
            {
                mensagemErro = "Informe a senha.";
                return false;
            }

            return true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!CamposValidos(out string mensagemErro))
            {
                MessageBox.Show(mensagemErro, "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            try
            {
                UsuarioDAO usuarioDAO = new UsuarioDAO();

                if (!usuarioDAO.EmailExiste(email))
                {
                    MessageBox.Show("E-mail não cadastrado.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Usuario usuarioAutenticado = usuarioDAO.Autenticar(email, senha);

                if (usuarioAutenticado != null)
                {
                    Sessao.UsuarioId = usuarioAutenticado.Id;
                    Sessao.UsuarioLogado = usuarioAutenticado;

                    this.Hide();
                    Inicial inicial = new Inicial(usuarioAutenticado);
                    inicial.ShowDialog();  
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Senha incorreta.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar login:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cboxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !cboxMostrarSenha.Checked;
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }
        private void linkLabelEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormEsqueciSenha formEsqueciSenha = new FormEsqueciSenha(this); // Passa o próprio login
            formEsqueciSenha.ShowDialog();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnEntrar.PerformClick();
            }
        }
    }
}
