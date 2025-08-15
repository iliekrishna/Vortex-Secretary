using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Secretary.DAO;
using Secretary.Models;
using Secretary.Forms.Gerenciamento;

namespace Secretary.Forms
{
    public partial class GerenciamentoUser : Form
    {
        public GerenciamentoUser()
        {
            InitializeComponent();
            Load += GerenciamentoUser_Load;
            Resize += (s, e) => AjustarLarguraDosPanels();
        }

        private void GerenciamentoUser_Load(object sender, EventArgs e)
        {
            CarregarDocumentosDisponiveis();
            CarregarFaq();
            AjustarLarguraDosPanels();
        }

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
                Size = new Size(flowLayoutPanelDocumentos.Width - 5, 50),
                Margin = new Padding(0, 0, 0, 10),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Nome do documento
            Label lblNome = new Label
            {
                Text = doc.Nome,
                AutoSize = true,
                Location = new Point(20, 15),
                Font = new Font("Verdana", 10F),
                Tag = doc.Id,
                ForeColor = Color.Black
            };

            // Status
            Label lblStatus = new Label
            {
                Text = doc.StatusAtual,
                ForeColor = doc.StatusAtual.Equals("Disponível", StringComparison.OrdinalIgnoreCase) ? Color.Green : Color.Red,
                AutoSize = true,
                Font = new Font("Verdana", 9F, FontStyle.Regular)
            };
            lblStatus.Location = new Point(lblNome.Right + 10, lblNome.Top);

            // Botão editar
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
                using (var form = new FormEditarDocumento(doc.Id, doc.Nome, doc.Descricao, doc.StatusAtual))
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

        #region ====== FAQ ======
        private void CarregarFaq()
        {
            try
            {
                flowLayoutPanelFaq.SuspendLayout();
                flowLayoutPanelFaq.Controls.Clear();

                FaqDAO dao = new FaqDAO();
                List<Faq> listaFaq = dao.ListarTodos();

                if (listaFaq.Count == 0)
                {
                    flowLayoutPanelFaq.Controls.Add(CriarLabelMensagem("Nenhum FAQ cadastrado"));
                    AdicionarBotaoNovoFaq();
                    return;
                }

                foreach (var faq in listaFaq)
                {
                    flowLayoutPanelFaq.Controls.Add(CriarPanelFaq(faq));
                }

                AdicionarBotaoNovoFaq();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar FAQ: " + ex.Message);
            }
            finally
            {
                flowLayoutPanelFaq.ResumeLayout();
            }
        }

        private Panel CriarPanelFaq(Faq faq)
        {
            Panel panel = new Panel
            {
                Name = $"panelFaq{faq.Id}",
                Size = new Size(flowLayoutPanelFaq.Width - 5, 50),
                Margin = new Padding(0, 0, 0, 10),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblPergunta = new Label
            {
                Text = faq.Pergunta,
                AutoSize = true,
                Location = new Point(20, 15),
                Font = new Font("Verdana", 10F)
            };

            Button btnEditar = new Button
            {
                Text = "Editar",
                Font = new Font("Verdana", 9F),
                Size = new Size(80, 25),
                Location = new Point(panel.Width - 100, 12),
                Tag = faq,
                Cursor = Cursors.Hand,
                BackColor = Color.White
            };
            btnEditar.Click += BtnEditarFaq_Click;

            panel.Controls.Add(lblPergunta);
            panel.Controls.Add(btnEditar);

            return panel;
        }

        private void BtnEditarFaq_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Faq faq)
            {
                using (var form = new FormEditarFaq(faq))
                {
                    form.FormClosed += (s, args) => CarregarFaq();
                    form.ShowDialog();
                }
            }
        }

        private void AdicionarBotaoNovoFaq()
        {
            Panel panelBotao = new Panel
            {
                Size = new Size(flowLayoutPanelFaq.Width - 40, 60),
                BackColor = Color.Transparent
            };

            Button btnNovoFaq = new Button
            {
                Text = "Novo FAQ",
                Font = new Font("Verdana", 10F),
                Size = new Size(150, 40),
                Location = new Point(20, 10),
                Cursor = Cursors.Hand
            };
            btnNovoFaq.Click += (s, e) =>
            {
                using (var form = new FormNovaFaq(Sessao.UsuarioLogado))
                {
                    form.FormClosed += (x, y) => CarregarFaq();
                    form.ShowDialog();
                }
            };

            panelBotao.Controls.Add(btnNovoFaq);
            flowLayoutPanelFaq.Controls.Add(panelBotao);
        }
        #endregion

        #region ====== LAYOUT E DESENHO ======
        private void AjustarLarguraDosPanels()
        {
            // Ajusta painéis de documentos
            foreach (Control ctrl in flowLayoutPanelDocumentos.Controls)
            {
                if (ctrl is Panel panel && panel.Name.StartsWith("panelDoc"))
                {
                    panel.Width = flowLayoutPanelDocumentos.Width - 5;
                    Label lblNome = null;
                    Label lblStatus = null;

                    foreach (Control innerCtrl in panel.Controls)
                    {
                        if (innerCtrl is Label lbl)
                        {
                            if (lbl.Tag != null && lbl.Tag is int)
                                lblNome = lbl;
                            else
                                lblStatus = lbl;
                        }
                        else if (innerCtrl is Button btn)
                        {
                            btn.Location = new Point(panel.Width - 100, 12);
                        }
                    }

                    if (lblNome != null) lblNome.Location = new Point(20, 15);
                    if (lblStatus != null && lblNome != null) lblStatus.Location = new Point(lblNome.Right + 10, lblNome.Top);
                }
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