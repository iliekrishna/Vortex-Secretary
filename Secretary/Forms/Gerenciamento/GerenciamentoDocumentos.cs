using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Secretary.DAO;
using Secretary.Models;
using Secretary.Forms.Gerenciamento;  

namespace Secretary.Forms
{
    public partial class GerenciamentoDocumentos : Form
    {
        public GerenciamentoDocumentos()
        {
            InitializeComponent();
            Load += Gerenciamento_Load;
        }

        private void Gerenciamento_Load(object sender, EventArgs e)
        {
            CarregarDocumentosDisponiveis();
        }

        private void CarregarDocumentosDisponiveis()
        {
            try
            {
                // Remove painel do botão "Novo Documento" para não duplicar
                var painelBotaoExistente = panelFormularios.Controls.Find("panelBotaoNovoDoc", false);
                if (painelBotaoExistente.Length > 0)
                    panelFormularios.Controls.Remove(painelBotaoExistente[0]);

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
                        Font = new Font("Verdana", 10F)
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
                    panelFormularios.Controls.SetChildIndex(panelDoc, 0); // Adiciona no topo
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
                Margin = new Padding(3, 3, 3, 20),
                BackColor = Color.Transparent
            };

            Button btnNovoDocumento = new Button
            {
                Text = "Novo Documento",
                Font = new Font("Verdana", 9.75F, FontStyle.Regular),
                Size = new Size(159, 32),
                FlatStyle = FlatStyle.Standard,
                Dock = DockStyle.Left
            };
            btnNovoDocumento.Click += BtnNovoDocumento_Click;

            panelBotao.Controls.Add(btnNovoDocumento);
            panelFormularios.Controls.Add(panelBotao);
        }

        private void BtnNovoDocumento_Click(object sender, EventArgs e)
        {
            FormNovoDocumento form = new FormNovoDocumento();
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
    }
}
