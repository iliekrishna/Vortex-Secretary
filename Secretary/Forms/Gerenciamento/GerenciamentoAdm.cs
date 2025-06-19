using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Secretary.DAO;
using Secretary.Models;
using Secretary.Forms.Gerenciamento;


namespace Secretary.Forms
{
    public partial class GerenciamentoAdm : Form
    {
        public GerenciamentoAdm()
        {
            InitializeComponent();
            Load += GerenciamentoAdm_Load;
        }

        private void GerenciamentoAdm_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
            CarregarDocumentosDisponiveis();
        }

        // --- Seu método para carregar documentos ---
        private void CarregarDocumentosDisponiveis()
        {
            try
            {
                panelFormularios.Controls.Clear();

                DocumentoDAO dao = new DocumentoDAO();
                List<DocumentoDisponivel> documentos = dao.ListarTodos();

                foreach (var doc in documentos)
                {
                    Panel panelDoc = new Panel
                    {
                        Name = $"panelDoc{doc.Id}",
                        Size = new Size(1219, 50),
                        Dock = DockStyle.Top,
                        Padding = new Padding(5, 10, 300, 15),
                        BackColor = Color.Transparent
                    };

                    Label lblNome = new Label
                    {
                        Text = doc.Nome,
                        AutoSize = true,
                        Dock = DockStyle.Left,
                        Padding = new Padding(70, 5, 0, 0),
                        Font = new Font("Verdana", 10F, FontStyle.Bold)
                    };

                    Label lblStatus = new Label
                    {
                        Text = doc.StatusAtual,
                        ForeColor = doc.StatusAtual == "Disponível" ? Color.Green : Color.Red,
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
                        Tag = doc
                    };
                    btnEditar.Click += BtnEditar_Click;

                    panelDoc.Controls.Add(lblNome);
                    panelDoc.Controls.Add(lblStatus);
                    panelDoc.Controls.Add(btnEditar);
                    panelFormularios.Controls.Add(panelDoc);
                    panelFormularios.Controls.SetChildIndex(panelDoc, 0);
                }

                AdicionarBotaoNovoDocumento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar documentos: " + ex.Message);
            }
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

            // Aqui está o evento que abre o formulário correto:
            btnNovoDocumento.Click += BtnNovoDocumento_Click;

            panelBotao.Controls.Add(btnNovoDocumento);
            panelFormularios.Controls.Add(panelBotao);
        }

        private void BtnNovoDocumento_Click(object sender, EventArgs e)
        {
            // Instancia e abre seu formulário de cadastro de documento
            var form = new Secretary.Forms.Gerenciamento.FormNovoDocumento();
            form.FormClosed += (s, args) => CarregarDocumentosDisponiveis();
            form.ShowDialog();
        }      

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DocumentoDisponivel doc = btn.Tag as DocumentoDisponivel;

            if (doc != null)
            {
                var form = new FormEditarDocumento(doc.Id, doc.Nome, doc.Descricao, doc.StatusAtual);
                form.FormClosed += (s, args) => CarregarDocumentosDisponiveis();
                form.ShowDialog();
            }
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
                        Text = $"{email} ({(tipoPerfil == "ADM" ? "Administrador" : "Usuário Comum")})",
                        AutoSize = true,
                        Dock = DockStyle.Right,
                        Padding = new Padding(15, 5, 80, 0),
                        ForeColor = Color.Gray,
                        Font = new Font("Verdana", 9F, FontStyle.Regular)
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

                    panel.Controls.Add(lblInfo);
                    panel.Controls.Add(lbl);
                    panel.Controls.Add(btn);
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
                Padding = new Padding(80, 25, 15, 25),
                Size = new Size(1219, 80),
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

            btnNovoUsuario.Click += (s, e) =>
            {
                var form = new Secretary.Forms.CriarUsuario();
                form.FormClosed += (x, y) => CarregarUsuarios(); // Atualiza a lista após cadastrar
                form.ShowDialog();
            };

            panelBotao.Controls.Add(btnNovoUsuario);
            panelUsuarios.Controls.Add(panelBotao);
        }

        private void btnAdicionarRequerimento_Click(object sender, EventArgs e)
        {
            Gerenciamento.FormNovoDocumento form = new Gerenciamento.FormNovoDocumento();
            form.FormClosed += (s, args) => CarregarDocumentosDisponiveis(); // Atualiza a lista
            form.ShowDialog();
        }
    }
}