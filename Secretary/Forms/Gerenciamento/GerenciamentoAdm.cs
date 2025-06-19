using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Secretary.Forms
{
    public partial class GerenciamentoAdm : Form
    {
        public GerenciamentoAdm()
        {
            InitializeComponent();
        }

        private void GerenciamentoAdm_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
            CarregarDocumentosDisponiveis();
        }

        private void btnNovoUsuario_Click_1(object sender, EventArgs e)
        {
            Form overlay = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.Black,
                Opacity = 0.5,
                StartPosition = FormStartPosition.Manual,
                Bounds = Screen.PrimaryScreen.Bounds,
                ShowInTaskbar = false,
                TopMost = true
            };

            overlay.Show();

            CriarUsuario chat = new CriarUsuario
            {
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true
            };

            chat.ShowDialog();
            overlay.Close();

            CarregarUsuarios(); // Recarrega após novo usuário
        }

        // ----------------------------- DOCUMENTOS -----------------------------
        private void CarregarDocumentosDisponiveis()
        {
            try
            {
                panelFormularios.Controls.Clear();

                using (var conexao = ConexaoBD.ObterConexao())
                {
                    string query = "SELECT id_disponibilidade, nome_doc, descricao, status_atual FROM t_disponibilidade_doc";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
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
                                Text = nome,
                                AutoSize = true,
                                Dock = DockStyle.Left,
                                Padding = new Padding(70, 5, 0, 0),
                                Font = new Font("Verdana", 10F)
                            };

                            Label lblStatus = new Label
                            {
                                Text = status, // "Disponível" ou "Indisponível"
                                ForeColor = status == "Disponível" ? Color.Green : Color.Red,
                                AutoSize = true,
                                Dock = DockStyle.Right,
                                Padding = new Padding(15, 5, 120, 0),
                                Font = new Font("Verdana", 9F, FontStyle.Regular)
                            };

                            Button btnEditar = new Button
                            {
                                Text = "Editar detalhes",
                                Font = new Font("Verdana", 9.75F),
                                Dock = DockStyle.Right,
                                Size = new Size(123, 25),
                                Tag = new DocumentoInfo { Id = id, Nome = nome, Descricao = descricao, Status = status }
                            };

                            btnEditar.Click += BtnEditarDocumento_Click;

                            panelDoc.Controls.Add(lblNome);
                            panelDoc.Controls.Add(lblStatus);
                            panelDoc.Controls.Add(lblNome);
                            panelDoc.Controls.Add(btnEditar);
                            panelFormularios.Controls.Add(panelDoc);
                            panelFormularios.Controls.SetChildIndex(panelDoc, 0);
                        }
                    }
                }

                AdicionarBotaoNovoDocumento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar documentos: " + ex.Message);
            }
        }

        private void BtnEditarDocumento_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DocumentoInfo doc = btn.Tag as DocumentoInfo;

            var form = new FormEditarDocumento(doc.Id, doc.Nome, doc.Descricao, doc.Status);
            form.FormClosed += (s, args) => CarregarDocumentosDisponiveis();
            form.ShowDialog();
        }

        private void AdicionarBotaoNovoDocumento()
        {
            Panel panelBotao = new Panel
            {
                Name = "panelBotaoNovoDoc",
                Dock = DockStyle.Bottom,
                Padding = new Padding(80, 15, 15, 15),
                Size = new Size(1219, 62),
                BackColor = Color.Transparent
            };

            Button btnNovoDocumento = new Button
            {
                Text = "Novo Documento",
                Font = new Font("Verdana", 9.75F),
                Size = new Size(159, 32),
                Dock = DockStyle.Left,
                FlatStyle = FlatStyle.Standard
            };
            btnNovoDocumento.Click += (s, e) =>
            {
                var form = new FormEditarDocumento(0, "", "", "Ativo");
                form.FormClosed += (x, y) => CarregarDocumentosDisponiveis();
                form.ShowDialog();
            };

            panelBotao.Controls.Add(btnNovoDocumento);
            panelFormularios.Controls.Add(panelBotao);
        }
        private void BtnNovoDocumento_Click(object sender, EventArgs e)
        {
            Gerenciamento.FormNovoDocumento form = new Gerenciamento.FormNovoDocumento();
            form.FormClosed += (s, args) => CarregarDocumentosDisponiveis(); // Atualiza a lista
            form.ShowDialog();
        }

        // ----------------------------- USUÁRIOS -----------------------------
        private void CarregarUsuarios()
        {
            try
            {
                panelUsuarios.Controls.Clear();

                string query = "SELECT id_usuario, email_usuario, nome_usuario, tipo_perfil FROM t_usuarios ORDER BY id_usuario";
                DataTable usuarios = ConexaoBD.ExecutarConsulta(query);

                foreach (DataRow row in usuarios.Rows)
                {
                    string nome = row["nome_usuario"].ToString();
                    string tipoPerfil = row["tipo_perfil"].ToString(); // "ADM" ou "USER"
                    int id = Convert.ToInt32(row["id_usuario"]);
                    string email = row["email_usuario"].ToString();

                    Panel panel = new Panel
                    {
                        Name = $"panelUsu{id}",
                        Size = new Size(1219, 50),
                        Dock = DockStyle.Top,
                        Padding = new Padding(5, 10, 300, 15),
                        BackColor = Color.Transparent
                    };

                    Label lbl = new Label
                    {
                        Text = nome,
                        AutoSize = true,
                        Dock = DockStyle.Left,
                        Padding = new Padding(70, 5, 0, 0),
                        Font = new Font("Verdana", 10F)
                    };

                    Label lblInfo = new Label
                    {
                        Text = $" - {email} ({(tipoPerfil == "ADM" ? "Administrador" : "Usuário Comum")})",
                        ForeColor = Color.Gray,
                        AutoSize = true,
                        Dock = DockStyle.Left,
                        Padding = new Padding(5, 5, 0, 0),
                        Font = new Font("Verdana", 10F)
                    };

                    Button btn = new Button
                    {
                        Text = "Editar detalhes",
                        Font = new Font("Verdana", 9.75F),
                        Dock = DockStyle.Right,
                        Size = new Size(123, 25),
                        Tag = id
                    };
                    btn.Click += BtnEditarUsuario_Click;

                    panel.Controls.Add(btn);
                    panel.Controls.Add(lbl);
                    panel.Controls.Add(lblInfo);
                    panel.Controls.Add(lbl);
                    panelUsuarios.Controls.Add(panel);
                    panelUsuarios.Controls.SetChildIndex(panel, 0);
                }

                AdicionarBotaoNovoUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar usuários: " + ex.Message);
            }
        }
        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int idUsuario = (int)btn.Tag;

            try
            {
                using (var conexao = ConexaoBD.ObterConexao())
                {
                    string query = "SELECT nome_usuario, email_usuario, tipo_perfil FROM t_usuarios WHERE id_usuario = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@id", idUsuario);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nome = reader.GetString("nome_usuario");
                            string email = reader.GetString("email_usuario");
                            string tipo = reader.GetString("tipo_perfil");

                            var form = new FormEditarUsuario(idUsuario, nome, email, tipo);
                            form.FormClosed += (s, args) => CarregarUsuarios();
                            form.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do usuário: " + ex.Message);
            }
        }

        private void AdicionarBotaoNovoUsuario()
        {
            Panel panelBotao = new Panel
            {
                Name = "panelBotaoNovoUsu",
                Dock = DockStyle.Bottom,
                Padding = new Padding(80, 15, 15, 15),
                Size = new Size(1219, 62),
                BackColor = Color.Transparent
            };

            Button btnNovoUsuario = new Button
            {
                Text = "Novo Usuário",
                Font = new Font("Verdana", 9.75F),
                Size = new Size(159, 32),
                Dock = DockStyle.Left,
                FlatStyle = FlatStyle.Standard
            };
            btnNovoUsuario.Click += btnNovoUsuario_Click_1;

            panelBotao.Controls.Add(btnNovoUsuario);
            panelUsuarios.Controls.Add(panelBotao);
        }

        private void btnAdicionarRequerimento_Click(object sender, EventArgs e)
        {
             Gerenciamento.FormNovoDocumento form = new Gerenciamento.FormNovoDocumento();
             form.FormClosed += (s, args) => CarregarDocumentosDisponiveis(); // Atualiza a lista
             form.ShowDialog();           
        }

        // Classe auxiliar segura para editar documentos
        private class DocumentoInfo
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public string Status { get; set; }
        }
    }
}
