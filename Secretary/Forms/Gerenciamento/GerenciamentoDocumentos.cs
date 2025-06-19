using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Secretary.Forms
{
    public partial class GerenciamentoDocumentos : Form
    {
        private void Gerenciamento_Load(object sender, EventArgs e)
        {
            CarregarDocumentosDisponiveis();
        }

        public GerenciamentoDocumentos()
        {
            InitializeComponent();
                    Load += Gerenciamento_Load;
        }

        private void CarregarDocumentosDisponiveis()
        {
            try
            {
                panelFormularios.Controls.Clear(); // Limpa tudo antes de começar

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
                                Font = new Font("Verdana", 10F, FontStyle.Bold)
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

                            btnEditar.Click += BtnEditar_Click;


                            panelDoc.Controls.Add(lblNome);
                            panelDoc.Controls.Add(lblStatus);
                            panelDoc.Controls.Add(lblNome);
                            panelDoc.Controls.Add(btnEditar);
                            panelFormularios.Controls.Add(panelDoc);
                            panelFormularios.Controls.SetChildIndex(panelDoc, 0); // Adiciona no topo
                        }
                    }
                }

                AdicionarBotaoNovoDocumento(); // sempre adiciona só uma vez
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar documentos: " + ex.Message);
            }
        }

        private void AdicionarBotaoNovoDocumento()
        {
            // Painel que conterá o botão
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
            Gerenciamento.FormNovoDocumento form = new Gerenciamento.FormNovoDocumento();
            form.FormClosed += (s, args) => CarregarDocumentosDisponiveis(); // Atualiza a lista
            form.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DocumentoInfo dados = btn.Tag as DocumentoInfo;

            if (dados != null)
            {
                var form = new FormEditarDocumento(dados.Id, dados.Nome, dados.Descricao, dados.Status);
                form.FormClosed += (s, args) => CarregarDocumentosDisponiveis();
                form.ShowDialog();
            }
        }

        // Classe auxiliar para guardar dados do documento (substitui dynamic)
        private class DocumentoInfo
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public string Status { get; set; }
        }
    }
}
