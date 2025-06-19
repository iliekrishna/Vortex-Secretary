using Secretary.Models;
using Secretary.DAO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Secretary.Forms
{
    public partial class CriarUsuario : Form
    {

        private const string PlaceholderNome = "Digite o nome completo";
        private const string PlaceholderEmail = "Digite o e-mail";
        private const string PlaceholderSenha = "Digite a senha";
        public CriarUsuario()
        {
            InitializeComponent();

            AplicarPlaceholder(txtNome, PlaceholderNome);
            AplicarPlaceholder(txtEmail, PlaceholderEmail);
            AplicarPlaceholder(txtSenha, PlaceholderSenha);
        }

        private void AplicarPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
                if (textBox == txtSenha)
                    textBox.UseSystemPasswordChar = false;
            }
        }

        private void RemoverPlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                if (textBox == txtSenha)
                    textBox.UseSystemPasswordChar = true;
            }
            if (textBox == txtSenha)
                textBox.UseSystemPasswordChar = !cboxMostrarSenha.Checked;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;
            string tipoSelecionado = cboxTipoUsuario.SelectedItem?.ToString();

            if (nome == PlaceholderNome || email == PlaceholderEmail || senha == PlaceholderSenha)
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(senha) ||
                string.IsNullOrWhiteSpace(tipoSelecionado))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (senha.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoUsuario = tipoSelecionado == "Administrador" ? "ADM" : "USER";

            Usuario novoUsuario = new Usuario
            {
                Nome = nome,
                Email = email,
                Senha = senha, // A DAO se encarrega de aplicar o hash
                TipoPerfil = tipoUsuario
            };

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            if (usuarioDAO.EmailExiste(email))
            {
                MessageBox.Show("E-mail já cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool sucesso = usuarioDAO.CadastrarUsuario(novoUsuario);

            if (sucesso)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                cboxTipoUsuario.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            RemoverPlaceholder(txtNome, PlaceholderNome);
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            AplicarPlaceholder(txtNome, PlaceholderNome);
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            RemoverPlaceholder(txtEmail, PlaceholderEmail);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            AplicarPlaceholder(txtEmail, PlaceholderEmail);
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            RemoverPlaceholder(txtSenha, PlaceholderSenha);
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            AplicarPlaceholder(txtSenha, PlaceholderSenha);

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.Text = PlaceholderSenha;
                txtSenha.ForeColor = Color.Gray;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void cboxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != PlaceholderSenha)
                txtSenha.UseSystemPasswordChar = !cboxMostrarSenha.Checked;
        }
    }
}
