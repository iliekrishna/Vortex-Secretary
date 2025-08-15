using MySql.Data.MySqlClient;
using Secretary.DAO;
using Secretary.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Secretary
{
    public partial class FormRedefinirSenha : Form
    {

        private string email;
        private UsuarioDAO usuarioDAO = new UsuarioDAO();

        // Constantes para os placeholders
        private const string PlaceholderCodigo = "Código recebido";
        private const string PlaceholderNovaSenha = "Nova senha";
        private const string PlaceholderConfirmarSenha = "Confirmar senha";

        public FormRedefinirSenha(string emailRecebido)
        {
            InitializeComponent();

            // Aplicar placeholders
            txtCodigo.Text = PlaceholderCodigo;
            txtCodigo.ForeColor = Color.Gray;

            txtNovaSenha.Text = PlaceholderNovaSenha;
            txtNovaSenha.ForeColor = Color.Gray;
            txtNovaSenha.UseSystemPasswordChar = false;


            txtConfirmarSenha.Text = PlaceholderConfirmarSenha;
            txtConfirmarSenha.ForeColor = Color.Gray;
            txtConfirmarSenha.UseSystemPasswordChar = false;


            email = emailRecebido;
            txtEmail.Text = email;

            //Cantos Arredondados
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30)); // Raio dos cantos
        }

        // Cantos arredondados no formulário
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft, int nTop, int nRight, int nBottom,
            int nWidthEllipse, int nHeightEllipse);

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Top, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FormLogin Login = new FormLogin();
            Login.ShowDialog();
            this.Close();
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Text == PlaceholderCodigo)
            {
                txtCodigo.Text = "";
                txtCodigo.ForeColor = Color.Black;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                txtCodigo.Text = PlaceholderCodigo;
                txtCodigo.ForeColor = Color.Gray;
            }
        }

        private void txtNovaSenha_Enter(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text == PlaceholderNovaSenha)
            {
                txtNovaSenha.Text = "";
                txtNovaSenha.ForeColor = Color.Black;
                txtNovaSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtNovaSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNovaSenha.Text))
            {
                txtNovaSenha.Text = PlaceholderNovaSenha;
                txtNovaSenha.ForeColor = Color.Gray;
                txtNovaSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmarSenha_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text == PlaceholderConfirmarSenha)
            {
                txtConfirmarSenha.Text = "";
                txtConfirmarSenha.ForeColor = Color.Black;
                txtConfirmarSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmarSenha.Text))
            {
                txtConfirmarSenha.Text = PlaceholderConfirmarSenha;
                txtConfirmarSenha.ForeColor = Color.Gray;
                txtConfirmarSenha.UseSystemPasswordChar = false;
            }
        }

        private void cboxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtNovaSenha.UseSystemPasswordChar = !cboxMostrarSenha.Checked;
            txtConfirmarSenha.UseSystemPasswordChar = !cboxMostrarSenha.Checked;
        }

        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string novaSenha = txtNovaSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            // Verifica se os campos foram preenchidos corretamente (não só não vazios, mas diferentes do placeholder)
            if (string.IsNullOrWhiteSpace(codigo) || codigo == PlaceholderCodigo ||
                string.IsNullOrWhiteSpace(novaSenha) || novaSenha == PlaceholderNovaSenha ||
                string.IsNullOrWhiteSpace(confirmarSenha) || confirmarSenha == PlaceholderConfirmarSenha)
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (novaSenha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    // Busca o ID do usuário pelo e-mail
                    int idUsuario = -1;
                    string sqlBuscarId = "SELECT id_usuario FROM t_usuarios WHERE email_usuario = @Email";
                    using (var cmdBuscar = new MySqlCommand(sqlBuscarId, conn))
                    {
                        cmdBuscar.Parameters.AddWithValue("@Email", email);
                        var result = cmdBuscar.ExecuteScalar();
                        if (result != null)
                            idUsuario = Convert.ToInt32(result);
                        else
                        {
                            MessageBox.Show("E-mail não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Verifica se o código é válido e ainda não expirou
                    string sql = @"SELECT codigo, expira_em, usado FROM t_recuperacao_senha 
                       WHERE id_usuario = @IdUsuario AND codigo = @Codigo AND usado = 0
                       ORDER BY id DESC LIMIT 1";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@Codigo", codigo);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DateTime expiracao = reader.GetDateTime("expira_em");
                                bool usado = reader.GetBoolean("usado");

                                if (DateTime.Now > expiracao)
                                {
                                    MessageBox.Show("Este código expirou. Solicite um novo.", "Código expirado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Código inválido ou já utilizado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    // Atualiza a senha
                    string novaSenhaHash = BCrypt.Net.BCrypt.HashPassword(novaSenha);
                    string atualizarSenhaSql = "UPDATE t_usuarios SET senha = @Senha WHERE id_usuario = @IdUsuario";
                    using (var cmdUpdate = new MySqlCommand(atualizarSenhaSql, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@Senha", novaSenhaHash);
                        cmdUpdate.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    // Marca o código como usado
                    string marcarCodigoSql = "UPDATE t_recuperacao_senha SET usado = 1 WHERE id_usuario = @IdUsuario AND codigo = @Codigo";
                    using (var cmdCodigo = new MySqlCommand(marcarCodigoSql, conn))
                    {
                        cmdCodigo.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        cmdCodigo.Parameters.AddWithValue("@Codigo", codigo);
                        cmdCodigo.ExecuteNonQuery();
                    }

                    MessageBox.Show("Senha redefinida com sucesso! Agora você pode fazer login.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormLogin Login = new FormLogin();
                    Login.ShowDialog();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao redefinir a senha:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtConfirmarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnRedefinir.PerformClick();
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtNovaSenha.Focus();
            }
        }

        private void txtNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtConfirmarSenha.Focus();
            }
        }
    }
}