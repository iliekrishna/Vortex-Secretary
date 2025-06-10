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
        }
        private void Inicial_Load(object sender, EventArgs e)
        {
            // Carregar lista de atendimentos/tickets ao abrir a tela inicial
            CarregarAtendimentos();
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
            
            // String de conexão com o banco de dados MySQL
            string conexaoString = "server=localhost;port=3306;user=root;password=;database=fatec_solicitacoes;";

            // Query para selecionar todos os tickets, ordenando do mais recente para o mais antigo
            string email = lblUsuario.Text;
            string query = "SELECT nome FROM T_USUARIOS WHERE email = @email ;";

            // Usando bloco using para garantir fechamento da conexão mesmo em caso de erro
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    // Abre conexão com banco de dados
                    conexao.Open();

                    // Executa comando SQL para leitura dos dados
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Itera por cada registro retornado da consulta
                    while (reader.Read())
                    {
                        Label lblSaudacao = new Label
                        {
                            Text = "Nome: " + reader["nome"].ToString(),
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            Location = new Point(10, 10),
                            AutoSize = true
                        };
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar tickets: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


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
            OpenChildForm(new Forms.Gerenciamento(), sender);
            ActivateButton(sender);
        }
        
        // Evento do botão Recentes (segunda definição, pode ser duplicado no designer): abre formulário Recentes e ativa botão
        private void btnRecentes_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GerenciamentoAdm(), sender);
            ActivateButton(sender);
        }
        
        // Evento do botão Atualizar Atendimentos: recarrega os atendimentos e ativa botão
        private void BtnAtualizarAtendimentos_Click(object sender, EventArgs e)
        {
            CarregarAtendimentos();
            ActivateButton(sender);
        }

        // Método para carregar os atendimentos da base de dados e exibir na interface
        private void CarregarAtendimentos()
        {
            // String de conexão com o banco de dados MySQL
            string conexaoString = "server=localhost;port=3306;user=root;password=;database=fatec_solicitacoes;";
            
            // Query para selecionar todos os tickets, ordenando do mais recente para o mais antigo
            string query = "SELECT * FROM tickets ORDER BY data_envio DESC";

            // Usando bloco using para garantir fechamento da conexão mesmo em caso de erro
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    // Abre conexão com banco de dados
                    conexao.Open();

                    // Executa comando SQL para leitura dos dados
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Itera por cada registro retornado da consulta
                    while (reader.Read())
                    {
                        string ra = reader["ra"].ToString();

                        // Cria o painel para exibir o atendimento
                        Panel painel = new Panel
                        {
                            BorderStyle = BorderStyle.FixedSingle,
                            Width = 320,
                            Height = 240,
                            Margin = new Padding(10)
                        };

                        Label lblNome = new Label
                        {
                            Text = "Nome: " + reader["nome"].ToString(),
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            Location = new Point(10, 10),
                            AutoSize = true
                        };

                        Label lblCurso = new Label
                        {
                            Text = "Curso: " + reader["curso"].ToString(),
                            Location = new Point(10, 35),
                            AutoSize = true
                        };

                        Label lblRa = new Label
                        {
                            Text = "RA: " + ra,
                            Location = new Point(10, 60),
                            AutoSize = true
                        };

                        Label lblEmail = new Label
                        {
                            Text = "Email: " + reader["email"].ToString(),
                            Location = new Point(10, 85),
                            AutoSize = true
                        };

                        Label lblAssunto = new Label
                        {
                            Text = "Assunto: " + reader["assunto"].ToString(),
                            Location = new Point(10, 110),
                            AutoSize = true
                        };

                        TextBox txtResposta = new TextBox
                        {
                            Multiline = true,
                            Width = 290,
                            Height = 50,
                            Location = new Point(10, 135),
                            Name = "txtResposta_" + ra
                        };

                        Button btnResponder = new Button
                        {
                            Text = "Responder",
                            Width = 120,
                            Height = 40,
                            Location = new Point(10, 193)
                        };

                        btnResponder.Click += (s, ev) =>
                        {
                            string respostaTexto = txtResposta.Text.Trim();

                            if (string.IsNullOrEmpty(respostaTexto))
                            {
                                MessageBox.Show("Digite uma resposta antes de enviar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            try
                            {
                                using (MySqlConnection con = new MySqlConnection(conexaoString))
                                {
                                    con.Open();
                                    string updateQuery = "UPDATE tickets SET resposta = @resposta WHERE ra = @ra";
                                    MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, con);
                                    cmdUpdate.Parameters.AddWithValue("@resposta", respostaTexto);
                                    cmdUpdate.Parameters.AddWithValue("@ra", ra);
                                    cmdUpdate.ExecuteNonQuery();
                                }

                                MessageBox.Show("Resposta enviada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao enviar resposta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        };

                        painel.Controls.Add(lblNome);
                        painel.Controls.Add(lblCurso);
                        painel.Controls.Add(lblRa);
                        painel.Controls.Add(lblEmail);
                        painel.Controls.Add(lblAssunto);
                        painel.Controls.Add(txtResposta);
                        painel.Controls.Add(btnResponder);

                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar tickets: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}