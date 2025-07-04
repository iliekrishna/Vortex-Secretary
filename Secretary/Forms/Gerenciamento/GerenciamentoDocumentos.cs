using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Secretary.DAO;
using Secretary.Forms.Gerenciamento;
using Secretary.Models;

namespace Secretary.Forms
{

    public partial class GerenciamentoDocumentos : Form
    {
        public GerenciamentoDocumentos()
        {
            InitializeComponent();
            Load += Gerenciamento_Load;
            Resize += (s, e) => AjustarLayout();
            this.AutoScaleMode = AutoScaleMode.Dpi; // Melhor suporte a diferentes DPIs
        }

        private void Gerenciamento_Load(object sender, EventArgs e)
        {
            CarregarDocumentosDisponiveis();
        }

        private void AjustarLayout()
        {
            if (panelFormularios.Controls.Count == 0) return;

            var scrollPanel = panelFormularios.Controls[0] as Panel;
            if (scrollPanel?.Controls.Count > 0 && scrollPanel.Controls[0] is FlowLayoutPanel container)
            {
                container.SuspendLayout();

                // Ajusta a largura do container principal
                container.Width = Math.Max(panelFormularios.Width - 40, 100);

                foreach (Control item in container.Controls)
                {
                    if (item is Panel itemPanel)
                    {
                        // Ajusta a largura do painel do item
                        itemPanel.Width = container.Width - 5;

                        // Encontra os controles internos
                        RichTextBox rtb = null;
                        Button btn = null;

                        foreach (Control subControl in itemPanel.Controls)
                        {
                            if (subControl is RichTextBox) rtb = subControl as RichTextBox;
                            else if (subControl is Button && subControl.Text == "Editar detalhes")
                                btn = subControl as Button;
                        }

                        if (rtb != null && btn != null)
                        {
                            rtb.Width = itemPanel.Width - btn.Width - 30;
                            btn.Left = rtb.Right + 2; 
                            btn.Top = (itemPanel.Height - btn.Height) / 2;
                        }
                    }
                }

                container.ResumeLayout();
            }
        }

        private void CarregarDocumentosDisponiveis()
        {
            try
            {
                panelFormularios.SuspendLayout();

                // Limpa controles antigos
                foreach (Control ctrl in panelFormularios.Controls)
                {
                    ctrl.Dispose();
                }
                panelFormularios.Controls.Clear();

                // Painel principal com scroll
                Panel scrollPanel = new Panel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    Padding = new Padding(20)
                };

                // Container dos itens
                FlowLayoutPanel container = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    Dock = DockStyle.Top,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    WrapContents = false,
                    Width = panelFormularios.Width - 40
                };

                DocumentoDAO dao = new DocumentoDAO();
                List<DocumentoDisponivel> documentos = dao.ListarTodos();

                foreach (var doc in documentos)
                {
                    // Painel para cada item
                    Panel itemPanel = new Panel
                    {
                        Width = container.Width - 5,
                        Height = 60,
                        Margin = new Padding(10, 0, 0, 0),
                        BackColor = Color.WhiteSmoke
                    };

                    // RichTextBox (nome + status)
                    RichTextBox rtbDocumento = new RichTextBox
                    {
                        Text = $"• {doc.Nome}",
                        Font = new Font("Verdana", 10),
                        Location = new Point(15, 15),
                        Width = itemPanel.Width - 140, 
                        Height = 30,
                        BorderStyle = BorderStyle.None,
                        BackColor = Color.WhiteSmoke,
                        ReadOnly = true,
                        ScrollBars = RichTextBoxScrollBars.None
                    };

                    // Adiciona o status com cor condicional
                    string statusText = doc.StatusAtual == "Disponível" ? " (Disponível) " : " (Indisponível) ";
                    rtbDocumento.AppendText($" {statusText}");
                    rtbDocumento.Select(rtbDocumento.Text.Length - statusText.Length, statusText.Length);
                    rtbDocumento.SelectionColor = doc.StatusAtual == "Disponível" ? Color.Green : Color.Red;
                    rtbDocumento.Select(0, 0);

                    // Botão Editar
                    Button btnEditar = new Button
                    {
                        Text = "Editar detalhes",
                        Font = new Font("Verdana", 9),
                        Size = new Size(120, 30),
                        Location = new Point(0, 15),
                        Tag = doc,
                        Anchor = AnchorStyles.Top 
                    };
                    btnEditar.Click += BtnEditar_Click;

                    itemPanel.Controls.Add(rtbDocumento);
                    itemPanel.Controls.Add(btnEditar);
                    container.Controls.Add(itemPanel);
                }

                // Botão Novo Documento
                Button btnNovo = new Button
                {
                    Text = "Novo Documento",
                    Font = new Font("Verdana", 10),
                    Size = new Size(150, 40),
                    Margin = new Padding(20, 20, 0, 0)
                };
                btnNovo.Click += BtnNovoDocumento_Click;

                container.Controls.Add(btnNovo);
                scrollPanel.Controls.Add(container);
                panelFormularios.Controls.Add(scrollPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar documentos: " + ex.Message, "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                panelFormularios.ResumeLayout();
                AjustarLayout();
            }
        }
        private void BtnNovoDocumento_Click(object sender, EventArgs e)
        {
            FormNovoDocumento form = new FormNovoDocumento();
            form.FormClosed += (s, args) => CarregarDocumentosDisponiveis();
            form.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is DocumentoDisponivel doc)
            {
                var form = new FormEditarDocumento(doc.Id, doc.Nome, doc.Descricao, doc.StatusAtual);
                form.FormClosed += (s, args) => CarregarDocumentosDisponiveis();
                form.ShowDialog();
            }
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}