using MySql.Data.MySqlClient;
using Secretary.DAO;
using Secretary.Forms.Gerenciamento;
using Secretary.Forms.Gerenciamento.FAQ;
using Secretary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Secretary.Forms
{
    public partial class GerenciamentoAdm : Form
    {
        public GerenciamentoAdm()
        {
            InitializeComponent();

            // Eventos do Form
            Load += GerenciamentoAdm_Load;
            Resize += (s, e) => AjustarLarguraDosPanels();
        }

        #region ====== EVENTO DE CARREGAMENTO ======
        private void GerenciamentoAdm_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
            CarregarDocumentosDisponiveis();
            CarregarUsuariosInativos();
            CarregarFaq();
            AjustarLarguraDosPanels();
        }
        #endregion

        #region ====== DOCUMENTOS ======
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
                AjustarLarguraDosPanels();
            }
        }
        private Panel CriarPanelDocumento(DocumentoDisponivel doc)
        {
            Panel panelDoc = new Panel
            {
                Name = $"panelDoc{doc.Id}",
                Height = 50,
                Width = flowLayoutPanelDocumentos.ClientSize.Width - 10,
                Margin = new Padding(0, 0, 0, 10),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Nome do documento
            Label lblNome = new Label
            {
                Text = doc.Nome,
                AutoSize = false,  
                AutoEllipsis = true,  
                MaximumSize = new Size(550, 0),  
                Size = new Size(550, 20),  
                Location = new Point(20, 15),
                Font = new Font("Verdana", 10F),
                ForeColor = Color.Black
            };

            // Status
            Label lblStatus = new Label
            {
                Text = doc.StatusAtual,
                ForeColor = doc.StatusAtual.Equals("Disponível", StringComparison.OrdinalIgnoreCase) ? Color.Green : Color.Red,
                AutoSize = false,
                AutoEllipsis = true,
                MaximumSize = new Size(120, 0),
                Size = new Size(120, 20),
                Font = new Font("Verdana", 9F, FontStyle.Regular)
            };
            int espacoMinimo = 10;
            lblStatus.Location = new Point(lblNome.Right + espacoMinimo, 15);

            int alturaNecessaria = Math.Max(50, lblNome.Bottom + 10);
            panelDoc.Height = alturaNecessaria;

            Button btnEditar = new Button
            {
                Text = "Editar",
                Font = new Font("Verdana", 9F),
                Size = new Size(80, 25),
                Tag = doc,
                Cursor = Cursors.Hand,
                BackColor = Color.White
            };
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Location = new Point(panelDoc.ClientSize.Width - btnEditar.Width - 20, 12);
            btnEditar.Click += BtnEditar_Click;

            // Adiciona controles ao painel
            panelDoc.Controls.Add(lblNome);
            panelDoc.Controls.Add(lblStatus);
            panelDoc.Controls.Add(btnEditar);

            return panelDoc;
        }
        private void BtnNovoDocumento_Click(object sender, EventArgs e)
        {
            using (var form = new FormNovoDocumento())
            {
                form.FormClosed += (s, args) =>
                {
                    CarregarDocumentosDisponiveis();
                    AjustarLarguraDosPanels();
                };
                form.ShowDialog();
            }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is DocumentoDisponivel doc)
            {
                using (var form = new FormEditarDocumento(
                    doc.Id,
                    doc.Nome,
                    doc.Descricao,
                    doc.StatusAtual,
                    doc.PrecisaPagamentoSegundaVia,
                    doc.TipoGratuidade
                ))
                {
                    form.FormClosed += (s, args) =>
                    {
                        CarregarDocumentosDisponiveis();
                        AjustarLarguraDosPanels();
                    };

                    form.ShowDialog();
                }
            }
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
        #endregion

        #region ====== USUÁRIOS ======
        private void CarregarUsuarios()
        {
            try
            {
                flowLayoutPanelUsuarios.SuspendLayout();
                flowLayoutPanelUsuarios.Controls.Clear();

                string query = "SELECT id_usuario, email_usuario, nome_usuario, tipo_perfil FROM t_usuarios WHERE ativo = 1 ORDER BY id_usuario";
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
                AjustarLarguraDosPanels();
            }
        }

        private void CarregarUsuariosInativos()
        {
            try
            {
                flowLayoutPanelUsuariosInativos.SuspendLayout();
                flowLayoutPanelUsuariosInativos.Controls.Clear();

                string query = "SELECT id_usuario, email_usuario, nome_usuario, tipo_perfil FROM t_usuarios WHERE ativo = 0 ORDER BY id_usuario";
                DataTable usuarios = ConexaoBD.ExecutarConsulta(query);

                if (usuarios.Rows.Count == 0)
                {
                    flowLayoutPanelUsuariosInativos.Controls.Add(CriarLabelMensagem("Nenhum usuário inativo encontrado"));
                    return;
                }

                foreach (DataRow row in usuarios.Rows)
                {
                    flowLayoutPanelUsuariosInativos.Controls.Add(CriarPanelUsuarioInativo(row));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar usuários inativos: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                flowLayoutPanelUsuariosInativos.ResumeLayout();
                AjustarLarguraDosPanels();
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
                Height = 50,
                Width = flowLayoutPanelUsuarios.ClientSize.Width - 10,
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
                Text = $"{email} ({(tipoPerfil == "ADM" ? "Administrador" : "Usuário")})",
                AutoSize = false,
                AutoEllipsis = true,
                MaximumSize = new Size(400, 0),
                Size = new Size(300, 20),
                Location = new Point(250, 15),
                ForeColor = Color.Gray,
                Font = new Font("Verdana", 9F, FontStyle.Regular)
            };

            Button btnEditar = new Button
            {
                Text = "Editar",
                Font = new Font("Verdana", 9F),
                Size = new Size(80, 25),
                Tag = id,
                Cursor = Cursors.Hand,
                BackColor = Color.White
            };
            btnEditar.Click += BtnEditarUsuario_Click;
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Location = new Point(panel.ClientSize.Width - btnEditar.Width - 20, 12);

            panel.Controls.Add(lblNome);
            panel.Controls.Add(lblInfo);
            panel.Controls.Add(btnEditar);

            return panel;
        }

        private Panel CriarPanelUsuarioInativo(DataRow row)
        {
            string nome = row["nome_usuario"].ToString();
            string tipoPerfil = row["tipo_perfil"].ToString();
            int id = Convert.ToInt32(row["id_usuario"]);
            string email = row["email_usuario"].ToString();

            Panel panel = new Panel
            {
                Name = $"panelUsu{id}",
                Height = 50,
                Width = flowLayoutPanelUsuariosInativos.ClientSize.Width - 10,
                Margin = new Padding(0, 0, 0, 10),
                BackColor = Color.Gainsboro,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblNome = new Label
            {
                Text = nome,
                AutoSize = false,
                AutoEllipsis = true,
                MaximumSize = new Size(400, 0),
                Location = new Point(20, 15),
                Font = new Font("Verdana", 10F),
                Tag = id
            };

            Label lblInfo = new Label
            {
                Text = $"{email} ({(tipoPerfil == "ADM" ? "Administrador" : "Usuário")})",
                AutoSize = false,
                AutoEllipsis = true,
                MaximumSize = new Size(400, 0),
                Size = new Size(300, 20),
                Location = new Point(250, 15),
                ForeColor = Color.Gray,
                Font = new Font("Verdana", 9F, FontStyle.Regular)
            };


            Button btnReativar = new Button
            {
                Text = "Reativar",
                Font = new Font("Verdana", 9F),
                Size = new Size(80, 25),
                Tag = id,
                Cursor = Cursors.Hand,
                BackColor = Color.White
            };
            btnReativar.Click += BtnReativarUsuario_Click;
            btnReativar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReativar.Location = new Point(panel.ClientSize.Width - btnReativar.Width - 20, 12);

            panel.Controls.Add(lblNome);
            panel.Controls.Add(lblInfo);
            panel.Controls.Add(btnReativar);

            return panel;
        }
        private void BtnReativarUsuario_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int idUsuario)
            {
                UsuarioDAO usuarioDAO = new UsuarioDAO();

                bool reativado = usuarioDAO.ReativarUsuarioPorId(idUsuario);
                if (reativado)
                {
                    MessageBox.Show("Usuário reativado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualiza as listas
                    CarregarUsuarios();
                    CarregarUsuariosInativos();
                }
                else
                {
                    MessageBox.Show("Falha ao reativar o usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                BackColor = Color.Transparent
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
        #endregion

        #region ====== FAQ ======
        private void CarregarFaq()
        {
            try
            {
                flowLayoutPanelFaq.SuspendLayout();
                flowLayoutPanelFaq.Controls.Clear();

                CategoriaDAO categoriaDao = new CategoriaDAO();
                List<Categoria> categorias = FaqDAO.ListarCategoriasOrdenadas();

                if (categorias.Count == 0)
                {
                    flowLayoutPanelFaq.Controls.Add(CriarLabelMensagem("Nenhuma categoria cadastrada"));
                    AdicionarBotaoNovaCategoria();
                    return;
                }

                foreach (var categoria in categorias)
                {
                    flowLayoutPanelFaq.Controls.Add(CriarPanelCategoria(categoria));
                }

                AdicionarBotaoNovaCategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
            }
            finally
            {
                flowLayoutPanelFaq.ResumeLayout();
            }
        }
        private Panel CriarPanelCategoria(Categoria categoria)
        {
            Panel panelCategoria = new Panel
            {
                Name = $"panelCategoria{categoria.Id}",
                Size = new Size(flowLayoutPanelFaq.Width - 5, 50),
                Margin = new Padding(0, 0, 0, 10),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblCategoria = new Label
            {
                Text = categoria.Nome,
                AutoSize = true,
                MaximumSize = new Size(400, 0),
                Location = new Point(20, 15),
                Font = new Font("Verdana", 10F)
            };

            Button btnMostrarPerguntas = new Button
            {
                Text = "Mostrar Perguntas",
                Font = new Font("Verdana", 9F),
                Size = new Size(150, 30),
                Location = new Point(panelCategoria.Width - 170, 9),
                Tag = categoria,
                Cursor = Cursors.Hand,
                BackColor = Color.White
            };
            btnMostrarPerguntas.Click += (s, e) => AbrirFormFaqs(categoria);

            panelCategoria.Controls.Add(lblCategoria);
            panelCategoria.Controls.Add(btnMostrarPerguntas);

            return panelCategoria;
        }
        private void AdicionarBotaoNovaCategoria()
        {
            Panel panelBotao = new Panel
            {
                Size = new Size(flowLayoutPanelFaq.Width - 40, 60),
                BackColor = Color.Transparent
            };

            Button btnNovoFaq = new Button
            {
                Text = "Nova Categoria",
                Font = new Font("Verdana", 10F),
                Size = new Size(150, 40),
                Location = new Point(20, 10),
                Cursor = Cursors.Hand
            };

            btnNovoFaq.Click += BtnNovoFaq_Click;
            panelBotao.Controls.Add(btnNovoFaq);
            flowLayoutPanelFaq.Controls.Add(panelBotao);
        }
        private void BtnNovoFaq_Click(object sender, EventArgs e)
        {
            if (Sessao.UsuarioLogado == null)
            {
                MessageBox.Show("Usuário não está logado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var formNovaCategoria = new FormNovaCategoria(Sessao.UsuarioLogado))
            {
                formNovaCategoria.FormClosed += (s, args) => CarregarFaq();
                formNovaCategoria.ShowDialog();
            }
        }
        private void AbrirFormFaqs(Categoria categoria)
        {
            using (var formFaqs = new FormFaqs(categoria))
            {
                formFaqs.FormClosed += (s, args) => CarregarFaq();
                formFaqs.ShowDialog();
            }
        }

        #endregion

        #region ====== LAYOUT E DESENHO ======
        private void AjustarLarguraDosPanels()
        {
            AjustarFlow(flowLayoutPanelDocumentos);
            AjustarFlow(flowLayoutPanelUsuarios);
            AjustarFlow(flowLayoutPanelUsuariosInativos);
            AjustarFlow(flowLayoutPanelFaq);
        }

        private void AjustarFlow(FlowLayoutPanel flow)
        {
            if (flow.ClientSize.Width <= 0)
                return;

            foreach (Control ctrl in flow.Controls)
            {
                if (ctrl is Panel p)
                    p.Width = flow.ClientSize.Width - 10;
            }
        }


        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabControl = (TabControl)sender;
            var tabPage = tabControl.TabPages[e.Index];
            var rect = tabControl.GetTabRect(e.Index);
            var textRect = new Rectangle(rect.Left + 20, rect.Top, rect.Width - 20, rect.Height);

            bool isSelected = tabControl.SelectedIndex == e.Index;
            Color backColor = isSelected ? Color.White : Color.FromArgb(240, 240, 240);
            Color textColor = isSelected ? Color.FromArgb(0, 118, 137) : Color.Gray;
            Font textFont = isSelected ? new Font("Segoe UI", 10, FontStyle.Bold) : new Font("Segoe UI", 9, FontStyle.Regular);

            using (var brush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            TextRenderer.DrawText(e.Graphics, tabPage.Text, textFont, textRect, textColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

            if (isSelected)
            {
                using (var pen = new Pen(Color.FromArgb(0, 118, 137), 3))
                {
                    e.Graphics.DrawLine(pen, rect.Left, rect.Bottom - 1, rect.Right, rect.Bottom - 1);
                }
            }
        }
        #endregion

        #region ====== UTILITÁRIOS ======
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

        private void AdicionarFaqItem(string pergunta, string resposta)
        {
            Panel itemPanel = new Panel
            {
                Width = flowLayoutPanelFaq.ClientSize.Width - 30,
                Height = 70,
                BackColor = Color.White,
                Margin = new Padding(5),
                Padding = new Padding(10)
            };

            Label lblPergunta = new Label
            {
                Text = pergunta,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Dock = DockStyle.Top,
                ForeColor = Color.FromArgb(0, 118, 137),
                Height = 25
            };

            Label lblResposta = new Label
            {
                Text = resposta,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Dock = DockStyle.Fill,
                ForeColor = Color.Gray
            };

            itemPanel.Controls.Add(lblResposta);
            itemPanel.Controls.Add(lblPergunta);
            flowLayoutPanelFaq.Controls.Add(itemPanel);
        }
        #endregion
    }
}