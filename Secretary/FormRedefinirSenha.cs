using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Secretary.DAO;
using Secretary.Models;

namespace Secretary
{
    public partial class FormRedefinirSenha : Form
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();

        public FormRedefinirSenha()
        {
            InitializeComponent();
        }

        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string codigoDigitado = txtCodigo.Text.Trim();
            string novaSenha = txtNovaSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(codigoDigitado) ||
                string.IsNullOrEmpty(novaSenha) || string.IsNullOrEmpty(confirmarSenha))
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (novaSenha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = ConexaoBD.ObterConexao())
            {
                // Verifica se o e-mail existe e pega o ID do usuário
                Usuario usuario = usuarioDAO.BuscarPorEmail(email, conn);

                if (usuario == null)
                {
                    MessageBox.Show("E-mail não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verifica se o código bate com algum ainda válido
                string sql = @"SELECT id FROM t_recuperacao_senha 
                               WHERE id_usuario = @idUsuario 
                                 AND codigo = @codigo 
                                 AND usado = FALSE 
                                 AND expira_em > NOW()
                               LIMIT 1";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", usuario.Id);
                    cmd.Parameters.AddWithValue("@codigo", codigoDigitado);

                    var resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        // Atualiza senha do usuário
                        string senhaHash = BCrypt.Net.BCrypt.HashPassword(novaSenha);

                        string updateUsuario = "UPDATE t_usuarios SET senha = @senha WHERE id_usuario = @id";
                        using (var cmdUpdate = new MySqlCommand(updateUsuario, conn))
                        {
                            cmdUpdate.Parameters.AddWithValue("@senha", senhaHash);
                            cmdUpdate.Parameters.AddWithValue("@id", usuario.Id);
                            cmdUpdate.ExecuteNonQuery();
                        }

                        // Marca o código como usado
                        string updateToken = "UPDATE t_recuperacao_senha SET usado = TRUE WHERE id = @idToken";
                        using (var cmdToken = new MySqlCommand(updateToken, conn))
                        {
                            cmdToken.Parameters.AddWithValue("@idToken", Convert.ToInt32(resultado));
                            cmdToken.ExecuteNonQuery();
                        }

                        MessageBox.Show("Senha redefinida com sucesso!", "Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Código inválido ou expirado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}