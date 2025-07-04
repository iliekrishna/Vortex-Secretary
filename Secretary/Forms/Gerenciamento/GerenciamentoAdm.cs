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

        private void CarregarDocumentosDisponiveis()
        {
            try
            {
                flowLayoutPanelDocumentos.SuspendLayout();
                flowLayoutPanelDocumentos.Controls.Clear();

                DocumentoDAO dao = new DocumentoDAO();
                List<DocumentoDisponivel> documentos = dao.ListarTodos();

                if (documentos.Count == 0)
                {
                    flowLayoutPanelDocumentos.Controls.Add(CriarLabelMensagem("Nenhum documento cadastrado"));
                    AdicionarBotaoNovoDocumento();
                    return;
                }

                foreach (var doc in documentos)
                {
                    flowLayoutPanelDocumentos.Controls.Add(CriarPanelDocumento(doc));
                }

                AdicionarBotaoNovoDocumento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar documentos: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                flowLayoutPanelDocumentos.ResumeLayout();
            }
        }

        private Panel CriarPanelDocumento(DocumentoDisponivel doc)
        {
            Panel panelDoc = new Panel
            {
                Name = $"panelDoc{doc.Id}",
                Size = new Size(flowLayoutPanelDocumentos.ClientSize.Width - 5, 50),
                Margin = new Padding(0, 0, 0, 10),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblNome = new Label
            {
                Text = doc.Nome,
                AutoSize = true,
                Location = new Point(20, 15),
                Font = new Font("Verdana", 10F),
                Tag = doc.Id,
                ForeColor = Color.Black
            };

            Label lblStatus = new Label
            {
                Text = doc.StatusAtual,
                ForeColor = doc.StatusAtual.Equals("Disponível", StringComparison.OrdinalIgnoreCase) ?
                    Color.Green : Color.Red,
                AutoSize = true,
                Location = new Point(panelDoc.Width - 200, 15),
                Font = new Font("Verdana", 9F, FontStyle.Regular)
            };

            Button btnEditar = new Button
            {
                Text = "Editar",
                Font = new Font("Verdana", 9F),
                Size = new Size(80, 25),
                Location = new Point(panelDoc.Width - 100, 12),
                Tag = doc,
                Cursor = Cursors.Hand,
                BackColor = Color.White
            };
            btnEditar.Click += BtnEditar_Click;

            panelDoc.Controls.Add(lblNome);
            panelDoc.Controls.Add(lblStatus);
            panelDoc.Controls.Add(btnEditar);

            return panelDoc;
        }

        private void AdicionarBotaoNovoDocumento()
        {
            Panel panelBotao = new Panel
            {
                Size = new Size(flowLayoutPanelDocumentos.Width - 40, 60),
                BackColor = Color.Transparent
            };

            Button btnNovoDocumento = new Button
            {
                Text = "Novo Documento",
                Font = new Font("Verdana", 10F),
                Size = new Size(150, 40),
                Location = new Point(20, 10),
                Cursor = Cursors.Hand
            };
            btnNovoDocumento.Click += BtnNovoDocumento_Click;

            panelBotao.Controls.Add(btnNovoDocumento);
            flowLayoutPanelDocumentos.Controls.Add(panelBotao);
        }

        private void BtnNovoDocumento_Click(object sender, EventArgs e)
        {
            using (var form = new FormNovoDocumento())
            {
                form.FormClosed += (s, args) => CarregarDocumentosDisponiveis();
                form.ShowDialog();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is DocumentoDisponivel doc)
            {
                using (var form = new FormEditarDocumento(doc.Id, doc.Nome, doc.Descricao, doc.StatusAtual))
                {
                    form.FormClosed += (s, args) => CarregarDocumentosDisponiveis();
                    form.ShowDialog();
                }
            }
        }

        private void CarregarUsuarios()
        {
            try
            {
                flowLayoutPanelUsuarios.SuspendLayout();
                flowLayoutPanelUsuarios.Controls.Clear();

                string query = "SELECT id_usuario, email_usuario, nome_usuario, tipo_perfil FROM t_usuarios ORDER BY id_usuario";
                DataTable usuarios = ConexaoBD.ExecutarConsulta(query);

                if (usuarios.Rows.Count == 0)
                {
                    flowLayoutPanelUsuarios.Controls.Add(CriarLabelMensagem("Nenhum usuário cadastrado"));
                    AdicionarBotaoNovoUsuario();
                    return;
                }

                foreach (DataRow row in usuarios.Rows)
                {
                    flowLayoutPanelUsuarios.Controls.Add(CriarPanelUsuario(row));
                }

                AdicionarBotaoNovoUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar usuários: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                flowLayoutPanelUsuarios.ResumeLayout();
            }
        }

        private Panel CriarPanelUsuario(DataRow row)
        {
            string nome = row["nome_usuario"].ToString();
            string tipoPerfil = row["tipo_perfil"].ToString();
            int id = Convert.ToInt32(row["id_usuario"]);
            string email = row["email_usuario"].ToString();

            Panel panel = new Panel
            {
                Name = $"panelUsu{id}",
                Size = new Size(flowLayoutPanelUsuarios.Width - 5, 50),
                Margin = new Padding(0, 0, 0, 10),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblNome = new Label
            {
                Text = nome,
                AutoSize = true,
                Location = new Point(20, 15),
                Font = new Font("Verdana", 10F),
                Tag = id
            };

            Label lblInfo = new Label
            {
                Text = $"{email} ({(tipoPerfil == "ADM" ? "Administrador" : "Usuário Comum")})",
                AutoSize = true,
                Location = new Point(250, 15),
                ForeColor = Color.Gray,
                Font = new Font("Verdana", 9F, FontStyle.Regular)
            };

            Button btnEditar = new Button
            {
                Text = "Editar",
                Font = new Font("Verdana", 9F),
                Size = new Size(80, 25),
                Location = new Point(panel.Width - 100, 12),
                Tag = id,
                Cursor = Cursors.Hand,
                BackColor = Color.White
            };
            btnEditar.Click += BtnEditarUsuario_Click;

            panel.Controls.Add(lblNome);
            panel.Controls.Add(lblInfo);
            panel.Controls.Add(btnEditar);

            return panel;
        }
        private Label CriarLabelMensagem(string mensagem)
        {
            return new Label
            {
                Text = mensagem,
                ForeColor = Color.Gray,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 50,
                Font = new Font("Verdana", 10F, FontStyle.Regular)
            };
        }
        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int idUsuario)
            {
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

                                using (var form = new FormEditarUsuario(idUsuario, nome, email, tipo))
                                {
                                    form.FormClosed += (s, args) => CarregarUsuarios();
                                    form.ShowDialog();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuário não encontrado.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados do usuário: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AdicionarBotaoNovoUsuario()
        {
            Panel panelBotao = new Panel
            {
                Size = new Size(flowLayoutPanelUsuarios.Width - 40, 60),
                BackColor = Color.WhiteSmoke
            };

            Button btnNovoUsuario = new Button
            {
                Text = "Novo Usuário",
                Font = new Font("Verdana", 10F),
                Size = new Size(150, 40),
                Location = new Point(20, 10),
                Cursor = Cursors.Hand
            };
            btnNovoUsuario.Click += (s, e) =>
            {
                using (var form = new CriarUsuario())
                {
                    form.FormClosed += (x, y) => CarregarUsuarios();
                    form.ShowDialog();
                }
            };

            panelBotao.Controls.Add(btnNovoUsuario);
            flowLayoutPanelUsuarios.Controls.Add(panelBotao);
        }
    }
}