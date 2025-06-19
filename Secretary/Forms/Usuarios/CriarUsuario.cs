using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretary.Forms
{

    public partial class CriarUsuario : Form
    {

        public CriarUsuario()
        {
            InitializeComponent();

            // Define o texto padrão e a cor cinza no campo de nome
            txtNome.Text = "Digite o nome completo";
            txtNome.ForeColor = Color.Gray;

            // Define o texto padrão e a cor cinza no campo de email
            txtEmail.Text = "Digite o e-mail";
            txtEmail.ForeColor = Color.Gray;

            // Define o texto padrão e a cor cinza no campo de senha
            txtSenha.Text = "Digite a senha";
            txtSenha.ForeColor = Color.Gray;

        }

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;
            string tipoSelecionado = cboxTipoUsuario.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(tipoSelecionado))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoUsuario = tipoSelecionado == "Administrador" ? "ADM" : "USER";
            string senhaHash = BCrypt.Net.BCrypt.HashPassword(senha);

            try
            {
                using (MySqlConnection conn = ConexaoBD.ObterConexao())
                {
                    string sql = @"INSERT INTO t_usuarios 
                        (nome_usuario, email_usuario, senha, tipo_perfil, criado_em) 
                        VALUES (@nome, @email, @senha, @tipo, NOW())";


                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", senhaHash);
                        cmd.Parameters.AddWithValue("@tipo", tipoUsuario);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            // Se estiver com o texto padrão, limpa o campo e muda a cor para preta
            if (txtNome.Text == "Digite o nome completo")
            {
                txtNome.Text = "";
                txtNome.ForeColor = Color.Black;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            // Se o campo estiver vazio, restaura o texto padrão e a cor cinza
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                txtNome.Text = "Digite o nome completo";
                txtNome.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            // Se estiver com o texto padrão, limpa o campo e muda a cor para preta
            if (txtEmail.Text == "Digite o e-mail")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            // Se o campo estiver vazio, restaura o texto padrão e a cor cinza
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Digite o e-mail";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            // Se estiver com o texto padrão, limpa o campo e muda a cor para preta
            if (txtSenha.Text == "Digite a senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            // Se o campo estiver vazio, restaura o texto padrão e a cor cinza
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.Text = "Digite a senha";
                txtSenha.ForeColor = Color.Gray;
            }
        }
    }
}
