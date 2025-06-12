using MySql.Data.MySqlClient;
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
using System.Globalization;
using Secretary.Forms;
using System.Security.Cryptography.X509Certificates;


namespace Secretary
{
    public partial class Inicial : Form
    {
        // Campos para controle do botão ativo e do formulário filho aberto
        private Button currentButton;
        private Form activeForm;

        // Construtor que recebe o nome do usuário para exibir na tela
        public Inicial(string loginRecebido)
        {
            InitializeComponent();    
            string loginUsuario = loginRecebido;
            lblUsuario.Text = loginRecebido;

            // Formatar nome com capitalização correta
            var textoInfo = CultureInfo.CurrentCulture.TextInfo;

            // Exibir nome formatado
            btnPerfil.Text = "  " + loginUsuario;

            // Configurar cultura pt-BR para formatação de data
            CultureInfo cultura = new CultureInfo("pt-BR");

            // Formatar data com a primeira letra maiúscula e horário
            string dataFormatada = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);
            dataFormatada = char.ToUpper(dataFormatada[0]) + dataFormatada.Substring(1);
            string horario = DateTime.Now.ToString("HH:mm");
            lblDataAtual.Text = $"{dataFormatada} | {horario}";

            // Definir saudação com base na hora
            int hora = DateTime.Now.Hour;
            string saudacao = hora < 12 ? "Bom dia" : (hora < 18 ? "Boa tarde" : "Boa noite");
            lblSaudacao.Text = $"{saudacao}, {loginUsuario}!";
            AtualizarContadores();// Só pra ter certeza que vai iniciar junto com o programa. 
        }
        private void Inicial_Load(object sender, EventArgs e)
        {
            AtualizarContadores(); //Vai atualizar os contadores quando iniciar ;)
        }
        private void AtualizarContadores()
        {
            int novas = 0, andamento = 0, canceladas = 0;

            try
            {
                using (MySqlConnection conn = ConexaoBD.ObterConexao()) //conexão com o bd
                {
                    string sql = "SELECT status_doc, COUNT(*) AS total FROM t_requerimentos GROUP BY status_doc";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string status = reader["status_doc"].ToString();
                            int total = Convert.ToInt32(reader["total"]);

                            switch (status)
                            {
                                case "Novo":
                                    novas = total;
                                    break;
                                case "Andamento":
                                    andamento = total;
                                    break;
                                case "Cancelado":
                                    canceladas = total;
                                    break;
                            }
                        }
                    }
                }

                // Atualiza os labels na interface e exibe a quantidade de solicitações
                lblNovasSolicitacoes.Text ="Novas Solicitações: " + novas.ToString();
                lblEmAndamento.Text = "Em Andamento: " + andamento.ToString();
                lblCanceladas.Text = "Canceladas: " + canceladas.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os contadores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensagem caso não carregue os contadores
            }
        }

        // Método para abrir um formulário filho dentro do painel principal da tela inicial
        private void OpenChildForm(Form childForm, object btnSender)
        {
            // Fechar o formulário filho que estiver aberto, se houver
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Definir o novo formulário filho como ativo
            activeForm = childForm;

            // Configurações para o formulário filho ficar integrado ao painel principal
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Adiciona o formulário filho ao painel principal e o exibe na frente
            this.panelPrincipal.Controls.Add(childForm);
            this.panelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Evento do botão Requerimentos: abre o formulário Requerimentos dentro do painel principal
        private void Requerimentos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Requerimentos(), sender);
        }

        // Método para ativar visualmente o botão do menu que foi clicado
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                // Só muda se for um botão diferente do que já está ativo
                if (currentButton != (Button)btnSender)
                {
                    DisableButton(); // Desativa os estilos dos botões anteriores
                    
                    // Define o botão atual e altera seu estilo para indicar que está ativo
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(57, 57, 57);
                    currentButton.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        // Método para resetar o estilo de todos os botões do menu para o padrão (desativado)
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                // Aplica apenas para controles do tipo botão
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(102, 102, 102);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        // Evento do botão Recentes: atualiza a exibição da data, hora e saudação e fecha formulário filho aberto
        private void btnRecentes_Click(object sender, EventArgs e)
        {
            // Configurar cultura pt-BR para formatação de data
            CultureInfo cultura = new CultureInfo("pt-BR");

            // Formatar data com a primeira letra maiúscula e horário
            string dataFormatada = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);
            dataFormatada = char.ToUpper(dataFormatada[0]) + dataFormatada.Substring(1);
            string horario = DateTime.Now.ToString("HH:mm");
            lblDataAtual.Text = $"{dataFormatada} | {horario}";

            // Definir saudação com base na hora
            int hora = DateTime.Now.Hour;
            string saudacao = hora < 12 ? "Bom dia" : (hora < 18 ? "Boa tarde" : "Boa noite");
            lblSaudacao.Text = $"{saudacao}, {lblUsuario.Text}!";
            


                        // Fecha o formulário ativo, se existir
                        if (activeForm != null)
                activeForm.Close();

            // Reseta os estilos dos botões do menu
            Reset();        
        }

        // Método para resetar o estado visual dos botões do menu (chama DisableButton)
        private void Reset()
        {
            DisableButton();
        }

        private void btnRequerimentos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Requerimentos(), sender);
            ActivateButton(sender);
        }

        // Evento do botão Atendimentos: abre formulário Atendimentos e ativa botão visualmente
        private void btnAtendimentos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Atendimentos(), sender);
            ActivateButton(sender);
        }

        // Evento do botão Histórico: abre formulário Histórico e ativa botão visualmente
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Historico(), sender);
            ActivateButton(sender);
        }

        // Evento do botão Gerenciamento: abre formulário Gerenciamento e ativa botão visualmente
        private void btnGerenciamento_Click(object sender, EventArgs e)
        {   
            string server = "162.241.40.214";
            string port = "3306";
            string user = "miltonb_userVortex";
            string password = "gWLQqb~dRO0M";
            string database = "miltonb_fatec_solicitacoes";

            // Conexão com banco só acontece se todos os campos estiverem preenchidos
            string connectionString = $"server={server};port={port};user={user};password={password};database={database};";

            string email_usu_logago = lblUsuario.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT tipo_perfil FROM t_usuarios WHERE email_usuario = @email_usu_logago LIMIT 1;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@email_usu_logago", email_usu_logago);
                        object result = cmd.ExecuteScalar();

                        if (result.ToString() == "ADM")
                        {
                            OpenChildForm(new Forms.GerenciamentoAdm(), sender);
                            ActivateButton(sender);
                        }
                        else
                        {
                            OpenChildForm(new Forms.Gerenciamento(), sender);
                            ActivateButton(sender);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // Evento do botão Recentes (segunda definição, pode ser duplicado no designer): abre formulário Recentes e ativa botão
        private void btnRecentes_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Recentes(), sender);
            ActivateButton(sender);
        }
        
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            menuOpcoes.Show(btnPerfil, new Point(0, btnPerfil.Height));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Tamanhos originais para restaurar depois
        private Size originalSize;
        private Point originalLocation;
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            originalSize = pboxNovasSolicitacoes.Size;
            originalLocation = pboxNovasSolicitacoes.Location;

            // Aumenta a imagem em 10% (ajustável)
            int zoom = 10;
            pboxNovasSolicitacoes.Size = new Size(pboxNovasSolicitacoes.Width + zoom, pboxNovasSolicitacoes.Height + zoom);

            // Centraliza o novo tamanho no lugar do antigo
            pboxNovasSolicitacoes.Location = new Point(
                pboxNovasSolicitacoes.Location.X - zoom / 2,
                pboxNovasSolicitacoes.Location.Y - zoom / 2
                );
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pboxNovasSolicitacoes.Size = originalSize;
            pboxNovasSolicitacoes.Location = originalLocation;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            originalSize = pboxEmAndamento.Size;
            originalLocation = pboxEmAndamento.Location;

            // Aumenta a imagem em 10% (ajustável)
            int zoom = 10;
            pboxEmAndamento.Size = new Size(pboxEmAndamento.Width + zoom, pboxEmAndamento.Height + zoom);

            // Centraliza o novo tamanho no lugar do antigo
            pboxEmAndamento.Location = new Point(
                pboxEmAndamento.Location.X - zoom / 2,
                pboxEmAndamento.Location.Y - zoom / 2
            );
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pboxEmAndamento.Size = originalSize;
            pboxEmAndamento.Location = originalLocation;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            originalSize = pboxCanceladas.Size;
            originalLocation = pboxCanceladas.Location;

            // Aumenta a imagem em 10% (ajustável)
            int zoom = 10;
            pboxCanceladas.Size = new Size(pboxCanceladas.Width + zoom, pboxCanceladas.Height + zoom);

            // Centraliza o novo tamanho no lugar do antigo
            pboxCanceladas.Location = new Point(
                pboxCanceladas.Location.X - zoom / 2,
                pboxCanceladas.Location.Y - zoom / 2
            );
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pboxCanceladas.Size = originalSize;
            pboxCanceladas.Location = originalLocation;
        }

        private void trocarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPerfil_Click_1(object sender, EventArgs e)
        {
            //Ao clicar no botão com a foto de perfil, abre o menu de opções
            menuOpcoes.Show(Cursor.Position);
            menuOpcoes.Show(btnPerfil, new Point(0, btnPerfil.Height));
        }
        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Envia os dados do usuário para o FormPerfilUsuario.cs
            OpenChildForm(new Forms.FormPerfilUsuario(lblUsuario.Text, lblUsuario.Text), sender);
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pboxNovasSolicitacoes_Click(object sender, EventArgs e)
        {

        }
    }
}