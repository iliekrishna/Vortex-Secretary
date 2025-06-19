using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using Secretary.Models;
using Secretary.DAO;



namespace Secretary
{
    
    public partial class FormLogin : Form
    {
        string server = "162.241.40.214";
        string port = "3306";
        string user = "miltonb_userVortex";
        string password = "gWLQqb~dRO0M";
        string database = "miltonb_fatec_solicitacoes";

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

            // Define o texto padrão e a cor cinza no campo de usuário
            txtUsuario.Text = "Inserir e-mail";
            txtUsuario.ForeColor = Color.Gray;

            // Define o texto padrão e a cor cinza no campo de senha
            txtSenha.Text = "Senha";
            txtSenha.ForeColor = Color.Gray;

            

            // Remove bordas do formulário e aplica cantos arredondados
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
        }

        // Evento ao focar (entrar) no campo txtUsuario
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            // Se estiver com o texto padrão, limpa o campo e muda a cor para preta
            if (txtUsuario.Text == "Inserir e-mail")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        // Evento ao perder o foco (sair) do campo txtUsuario
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            // Se o campo estiver vazio, restaura o texto padrão e a cor cinza
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "Inserir e-mail";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        // Evento ao focar (entrar) no campo txtSenha
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            // Se estiver com o texto padrão, limpa o campo e muda a cor para preta
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
            }
        }

        // Evento ao perder o foco (sair) do campo txtSenha
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            // Se o campo estiver vazio, restaura o texto padrão e a cor cinza
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Gray;
            }
        }

        // Evento de clique no botão de fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        // Evento de clique no botão de minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimiza o formulário
        }

        // Evento de clique no botão "Entrar"
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string emailDigitado = txtUsuario.Text.Trim();
            string senhaDigitada = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(emailDigitado) || emailDigitado == "Inserir e-mail" ||
                string.IsNullOrWhiteSpace(senhaDigitada) || senhaDigitada == "Senha")
            {
                MessageBox.Show("Preencha todos os campos.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = ConexaoBD.ObterConexao())
                {
                    // aqui a conexão já estará aberta
                    string sql = "SELECT id_usuario, nome_usuario, email_usuario, senha, tipo_perfil FROM t_usuarios WHERE email_usuario = @email LIMIT 1;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", emailDigitado);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string senhaHashBanco = reader.GetString("senha");
                                bool senhaCorreta = BCrypt.Net.BCrypt.Verify(senhaDigitada, senhaHashBanco);

                                if (senhaCorreta)
                                {
                                    Sessao.UsuarioId = reader.GetInt32("id_usuario");
                                    Sessao.UsuarioLogado = new Usuario
                                    {
                                        Id = reader.GetInt32("id_usuario"),
                                        Nome = reader.GetString("nome_usuario"),
                                        Email = reader.GetString("email_usuario"),
                                        SenhaHash = senhaHashBanco,
                                        Tipo = reader.GetString("tipo_perfil")
                                    };

                                    this.Hide();
                                    Inicial telaInicial = new Inicial(Sessao.UsuarioLogado);
                                    telaInicial.Show();

                                }
                                else
                                {
                                    MessageBox.Show("Senha incorreta.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuário não encontrado.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // Evento de clique na checkbox para mostrar ou ocultar senha
        private void cboxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            // Alterna a visibilidade da senha com base no checkbox
            txtSenha.UseSystemPasswordChar = !cboxMostrarSenha.Checked;
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick(); // Simula o clique no botão de login
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus(); // Foco no campo da senha após apertar "Enter"
            }
        }
    }
}