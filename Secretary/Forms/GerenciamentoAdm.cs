using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System;
using MySql.Data.MySqlClient;

namespace Secretary.Forms
{
    public partial class GerenciamentoAdm : Form
    {
        public GerenciamentoAdm()
        {
            InitializeComponent();
        }
        private void btnNovoUsuario_Click_1(object sender, EventArgs e)
        {
            Form overlay = new Form();
            overlay.FormBorderStyle = FormBorderStyle.None;
            overlay.BackColor = Color.Black;
            overlay.Opacity = 0.5;
            overlay.StartPosition = FormStartPosition.Manual;
            overlay.Bounds = Screen.PrimaryScreen.Bounds;
            overlay.ShowInTaskbar = false;
            overlay.TopMost = true;

            overlay.Show();

            CriarUsuario chat = new CriarUsuario();
            chat.StartPosition = FormStartPosition.CenterScreen;
            chat.TopMost = true;
            chat.ShowDialog();
            overlay.Close();
        }

        private void GerenciamentoAdm_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
            CarregarDocumentosDisponiveis();
        }

        private void CarregarDocumentosDisponiveis()
        {
            try
            {
                using (var conexao = ConexaoBD.ObterConexao())
                {
                    string query = "SELECT id_disponibilidade, nome_doc, descricao, status_atual FROM t_disponibilidade_doc";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    panelFormularios.Controls.Clear();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id_disponibilidade");
                        string nome = reader.GetString("nome_doc");
                        string descricao = reader.GetString("descricao");
                        string status = reader.GetString("status_atual");

                        Panel panelDoc = new Panel
                        {
                            Name = $"panelDoc{id}",
                            Size = new Size(1219, 50),
                            Dock = DockStyle.Top,
                            Padding = new Padding(5, 10, 300, 15),
                            BackColor = Color.Transparent
                        };

                        Label lblNome = new Label
                        {
                            Name = $"lblNome{id}",
                            Text = nome,
                            AutoSize = true,
                            Dock = DockStyle.Left,
                            Padding = new Padding(70, 5, 0, 0)
                        };

                        Button btnEditar = new Button
                        {
                            Name = $"btnEditar{id}",
                            Text = "Editar detalhes",
                            Font = new Font("Verdana", 9.75F),
                            Dock = DockStyle.Right,
                            Size = new Size(123, 25),
                            Tag = new { Id = id, Nome = nome, Descricao = descricao, Status = status }
                        };
                        btnEditar.Click += BtnEditar_Click;

                        panelDoc.Controls.Add(btnEditar);
                        panelDoc.Controls.Add(lblNome);
                        panelFormularios.Controls.Add(panelDoc);
                        panelFormularios.Controls.SetChildIndex(panelDoc, 0);
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar documentos: " + ex.Message);
            }
            // Cria o botão "Novo Documento"
            Button btnNovoDocumento = new Button
            {
                Name = "btnNovoDocumento",
                Text = "Novo Documento",
                Dock = DockStyle.Left,
                Font = new Font("Verdana", 9.75F, FontStyle.Regular),
                Size = new Size(159, 32),
                Padding = new Padding(0),
                Margin = new Padding(0),
                FlatStyle = FlatStyle.Standard
            };
            btnNovoDocumento.Click += BtnNovoDocumento_Click;

            // Cria o painel que vai conter o botão
            Panel panelBotaoNovoDoc = new Panel
            {
                Name = "panelBotaoNovoDoc",
                Dock = DockStyle.Bottom,
                Padding = new Padding(80, 15, 15, 15),
                Size = new Size(1219, 62),
                Margin = new Padding(3, 3, 3, 20),
                BackColor = Color.Transparent
            };

            // Adiciona o botão ao painel
            panelBotaoNovoDoc.Controls.Add(btnNovoDocumento);

            // Adiciona o painel com botão ao container principal
            panelFormularios.Controls.Add(panelBotaoNovoDoc);
            panelFormularios.Controls.SetChildIndex(panelBotaoNovoDoc, panelFormularios.Controls.Count - 1);

        }

        private void BtnNovoDocumento_Click(object sender, EventArgs e)
        {
            FormEditarDocumento form = new FormEditarDocumento(
                id: 0, // ou -1 para representar novo
                nome: "",
                descricao: "",
                status: "Ativo" // ou qualquer valor padrão
            );

            form.FormClosed += (s, args) => CarregarDocumentosDisponiveis(); // Recarrega ao fechar
            form.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            dynamic dados = btn.Tag;

            FormEditarDocumento form = new FormEditarDocumento(
                dados.Id,
                dados.Nome,
                dados.Descricao,
                dados.Status
            );

            form.FormClosed += (s, args) => CarregarDocumentosDisponiveis(); // Recarrega ao fechar
            form.ShowDialog();
        }


        private void CarregarUsuarios()
        {
            try
            {
                ConexaoBD conexao = new ConexaoBD();
                string query = "SELECT id_usuario, email_usuario FROM t_usuarios ORDER BY id_usuario";
                DataTable usuarios = ConexaoBD.ExecutarConsulta(query);

                panelUsuarios.Controls.Clear();

                foreach (DataRow row in usuarios.Rows)
                {
                    string email = row["email_usuario"].ToString();
                    int idUsuario = Convert.ToInt32(row["id_usuario"]);

                    Panel panel = new Panel
                    {
                        Name = $"panelUsu{idUsuario}",
                        Size = new Size(1219, 50),
                        Dock = DockStyle.Top,
                        Padding = new Padding(5, 10, 300, 15),
                        BackColor = Color.Transparent
                    };

                    Label lbl = new Label
                    {
                        Name = $"lblUsu{idUsuario}",
                        Text = email,
                        AutoSize = true,
                        Dock = DockStyle.Left,
                        Padding = new Padding(70, 5, 0, 0)
                    };

                    Button btn = new Button
                    {
                        Name = $"btnEditarUsu{idUsuario}",
                        Text = "Editar detalhes",
                        Font = new Font("Verdana", 9.75F, FontStyle.Regular),
                        Dock = DockStyle.Right,
                        Size = new Size(123, 25),
                        Tag = idUsuario
                    };
                    btn.Click += BtnEditar_Click;

                    panel.Controls.Add(btn);
                    panel.Controls.Add(lbl);
                    panelUsuarios.Controls.Add(panel);
                    panelUsuarios.Controls.SetChildIndex(panel, 0);
                }
                // Cria o botão
                Button btnNovoUsuario = new Button
                {
                    Name = "btnNovoUsuario",
                    Text = "Novo Usuário",
                    Dock = DockStyle.Left,
                    Font = new Font("Verdana", 9.75F, FontStyle.Regular),
                    Size = new Size(159, 32),
                    Padding = new Padding(0),
                    Margin = new Padding(0),
                    FlatStyle = FlatStyle.Standard
                };
                btnNovoUsuario.Click += btnNovoUsuario_Click_1; // Usa o mesmo evento do botão original

                // Cria o painel que vai conter o botão
                Panel panelBotaoNovoUsu = new Panel
                {
                    Name = "panelBotaoNovoUsu",
                    Dock = DockStyle.Bottom,
                    Padding = new Padding(80, 15, 15, 15),
                    Size = new Size(1219, 62),
                    Margin = new Padding(3, 3, 3, 20),
                    BackColor = Color.Transparent
                };

                // Adiciona o botão ao painel
                panelBotaoNovoUsu.Controls.Add(btnNovoUsuario);

                // Adiciona o painel com botão ao container principal
                panelUsuarios.Controls.Add(panelBotaoNovoUsu);
                panelUsuarios.Controls.SetChildIndex(panelBotaoNovoUsu, panelUsuarios.Controls.Count - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar usuários: " + ex.Message);
            }
        }

        private void btnAdicionarRequerimento_Click(object sender, EventArgs e)
        {

        }
    }
}
