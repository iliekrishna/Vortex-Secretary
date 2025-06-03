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

namespace Secretary
{
    public partial class FormLogin : Form
    {
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

            string senha = "Senha123!";
            string senhaHash = BCrypt.Net.BCrypt.HashPassword(senha);
            Console.WriteLine(senhaHash);


            // Define o texto padrão e a cor cinza no campo de usuário
            txtUsuario.Text = "Inserir usuário";
            txtUsuario.ForeColor = Color.Gray;

            // Define o texto padrão e a cor cinza no campo de senha
            txtSenha.Text = "Senha";
            txtSenha.ForeColor = Color.Gray;

            // Teste: Gera e imprime no console a versão hasheada da senha "Senha123!"
            string senhaEmTexto = "Senha123!";
            string senhaHasheada = BCrypt.Net.BCrypt.HashPassword(senhaEmTexto);
            Console.WriteLine("senha: " + senhaHasheada);

            // Remove bordas do formulário e aplica cantos arredondados
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
        }

        // Evento ao focar (entrar) no campo txtUsuario
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            // Se estiver com o texto padrão, limpa o campo e muda a cor para preta
            if (txtUsuario.Text == "Inserir usuário")
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
                txtUsuario.Text = "Inserir usuário";
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

        // Evento de clique no botão de entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text.Trim();
            string senhaDigitada = txtSenha.Text;

            if (nome == "Inserir usuário" || string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Por favor, insira o nome de usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(senhaDigitada) || senhaDigitada == "Senha")
            {
                MessageBox.Show("Por favor, insira a senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // String de conexão (sem senha definida)
            string connectionString = "server=localhost;port=3306;user=root;password=;database=fatec_solicitacoes;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Query segura com parâmetros
                    string sql = "SELECT COUNT(*) FROM t_usuarios WHERE email = @nome AND senha = @senhaDigitada;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@senhaDigitada", senhaDigitada);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            Inicial telaInicial = new Inicial(nome);
                            telaInicial.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}