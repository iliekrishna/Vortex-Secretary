using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace Secretary.Forms
{
    public partial class Requerimentos : Form
    {
        public Requerimentos()
        {
            InitializeComponent();
            this.Load += Requerimentos_Load;
        }

        public void Requerimentos_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();

            foreach (var req in ObterRequerimentos())
            {
                if (req != null)
                {
                    var painel = CriarPainel(req);
                    flowLayoutPanel1.Controls.Add(painel);
                }
            }
            flowLayoutPanel1.ResumeLayout();
            CarregarTotaisStatus();

        }


        private void CarregarTotaisStatus()
        {
            int novas = 0, andamento = 0, canceladas = 0;

            using (MySqlConnection conn = ConexaoBD.ObterConexao())
            {
                string sql = "SELECT status_doc, COUNT(*) AS total FROM t_requerimentos GROUP BY status_doc";
                using (var cmd = new MySqlCommand(sql, conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        switch (rdr["status_doc"].ToString())
                        {
                            case "Novo": novas = rdr.GetInt32("total"); break;
                            case "Pendente": andamento = rdr.GetInt32("total"); break;
                            case "Cancelado": canceladas = rdr.GetInt32("total"); break;
                        }
                    }
                }
            }
        }

        public class RequerimentoInfo
        {
            public int Id { get; set; }
            public string TipoDocumento { get; set; }
            public string StatusAtual { get; set; }
            public DateTime DataSolic { get; set; }
            public string Nome { get; set; }
            public string RA { get; set; }
            public string RG { get; set; }
            public string Telefone { get; set; }
            public string Curso { get; set; }
            public string Email { get; set; }
        }

        public List<RequerimentoInfo> ObterRequerimentos()
        {
            var lista = new List<RequerimentoInfo>();

            using (var conn = ConexaoBD.ObterConexao())
            {
                string sql = @"
            SELECT  id_requerimento,
                    tipo_doc,
                    status_doc,
                    data_pedido,
                    nome,
                    ra,
                    rg,
                    telefone,
                    curso,
                    email
            FROM    t_requerimentos
            ORDER BY data_pedido DESC";

                using (var cmd = new MySqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var req = new RequerimentoInfo
                        {
                            Id = reader.GetInt32("id_requerimento"),
                            TipoDocumento = reader.IsDBNull(reader.GetOrdinal("tipo_doc")) ? "" : reader.GetString("tipo_doc"),
                            StatusAtual = reader.IsDBNull(reader.GetOrdinal("status_doc")) ? "" : reader.GetString("status_doc"),
                            DataSolic = reader.IsDBNull(reader.GetOrdinal("data_pedido")) ? DateTime.MinValue : reader.GetDateTime("data_pedido"),
                            Nome = reader.IsDBNull(reader.GetOrdinal("nome")) ? "" : reader.GetString("nome"),
                            RA = reader.IsDBNull(reader.GetOrdinal("ra")) ? "" : reader.GetString("ra"),
                            RG = reader.IsDBNull(reader.GetOrdinal("rg")) ? "" : reader.GetString("rg"),
                            Telefone = reader.IsDBNull(reader.GetOrdinal("telefone")) ? "" : reader.GetString("telefone"),
                            Curso = reader.IsDBNull(reader.GetOrdinal("curso")) ? "" : reader.GetString("curso"),
                            Email = reader.IsDBNull(reader.GetOrdinal("email")) ? "" : reader.GetString("email")
                        };

                        lista.Add(req);
                    }
                }
            }

            return lista;
        }



        private MaterialSkin.Controls.MaterialExpansionPanel CriarPainel(RequerimentoInfo r)
        {
            var painel = new MaterialSkin.Controls.MaterialExpansionPanel
            {
                Title = r.TipoDocumento,
                Description = r.StatusAtual,
                ValidationButtonText = "Responder",
                CancelButtonText = "Cancelar",
                ExpandHeight = 341,
                Collapse = true,
                Dock = DockStyle.Top,
                Padding = new Padding(24, 64, 24, 15),
                Margin = new Padding(16, 1, 16, 0)
            };

            painel.SaveClick += materialExpansionPanel1_SaveClick;
            painel.CancelClick += materialExpansionPanel1_CancelClick_1;

            painel.Controls.Add(NovoLabelTop($"Data: {r.DataSolic:dd/MM/yyyy}", "label17", ContentAlignment.MiddleRight));
            painel.Controls.Add(NovoLabelTop($"E-mail: {r.Email}", "label16"));
            painel.Controls.Add(NovoLabelTop($"RG: {r.RG}", "label15"));
            painel.Controls.Add(NovoLabelTop($"Curso: {r.Curso}", "label14"));
            painel.Controls.Add(NovoLabelTop($"Telefone: {r.Telefone}", "label13"));
            painel.Controls.Add(NovoLabelTop($"RA: {r.RA}", "label12"));
            painel.Controls.Add(NovoLabelTop($"Nome: {r.Nome}", "label11"));

            var btn = new Button
            {
                Text = "Copiar e-mail",
                Dock = DockStyle.Top,
                Height = 21,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Verdana", 8.25f)
            };
            btn.Click += (s, e) =>
            {
                Clipboard.SetText(r.Email);
                MessageBox.Show("E-mail copiado!");
            };
            painel.Controls.Add(btn);

            return painel;
        }

        private Label NovoLabelTop(string texto, string name, ContentAlignment align = ContentAlignment.MiddleLeft)
        {
            return new Label
            {
                Name = name,
                Text = texto,
                Dock = DockStyle.Top,
                Padding = new Padding(0, 3, 3, 3),
                Font = new Font("Verdana", 12f),
                AutoSize = true,
                TextAlign = align
            };
        }

        private void materialExpansionPanel1_SaveClick(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir tela de detalhes para esta solicitação.");

            var respostaForm = new ResponderSolicitacao();
            if (respostaForm.ShowDialog() == DialogResult.OK)
            {
                string mensagem = respostaForm.Resposta;
                MessageBox.Show("Mensagem registrada:\n" + mensagem);
                // Aqui você pode salvar no banco de dados
            }
        }

        private void materialExpansionPanel1_CancelClick_1(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Deseja CANCELAR esta solicitação?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {

                MessageBox.Show("Solicitação cancelada com sucesso.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label16.Text);
            MessageBox.Show("E-mail copiado para a área de transferência!");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void materialExpansionPanel1_Paint(object sender, PaintEventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            Requerimentos_Load(sender, e);
            // 1. Obter os filtros selecionados
            string status = comboBox2.SelectedItem?.ToString() ?? "Todos";
            string documento = comboBox3.SelectedItem?.ToString() ?? "Todos";
            string ordenarPor = comboBox1.SelectedItem?.ToString() ?? "Mais recente";
            DateTime dataSelecionada = dateTimePicker1.Value.Date;

            // 2. Limpar os cards antigos
            flowLayoutPanel1.Controls.Clear();

            // 3. Buscar os dados filtrados do banco (exemplo com MySQL)
            using (MySqlConnection conn = ConexaoBD.ObterConexao())
            {
                string query = "SELECT * FROM t_requerimentos WHERE 1=1";

                // Aplicar filtros dinâmicos
                if (status != "Todos")
                    query += " AND status_doc = @status";

                if (documento != "Todos")
                    query += " AND tipo_doc = @documento";

                query += " AND data_doc = @data";

                if (ordenarPor == "Mais recente")
                    query += " ORDER BY data_doc DESC";
                else
                    query += " ORDER BY data_doc ASC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Passar os parâmetros
                    if (status != "Todos")
                        cmd.Parameters.AddWithValue("@status", status);

                    if (documento != "Todos")
                        cmd.Parameters.AddWithValue("@documento", documento);

                    cmd.Parameters.AddWithValue("@data", dataSelecionada);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            MaterialExpansionPanel novoCard = new MaterialExpansionPanel();
                            novoCard.Title = reader["tipo_doc"].ToString();
                            novoCard.Description = reader["status_doc"].ToString();


                            flowLayoutPanel1.Controls.Add(novoCard);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0; // Ex: "Todos"

            // Resetar ComboBox de Documento (comboBox3)
            if (comboBox3.Items.Count > 0)
                comboBox3.SelectedIndex = 0;

            // Resetar ComboBox de Ordenar por (comboBox1)
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

            // Resetar Data para hoje
            dateTimePicker1.Value = DateTime.Today;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Obter os filtros selecionados
            string status = comboBox2.SelectedItem?.ToString() ?? "Todos";
            string documento = comboBox3.SelectedItem?.ToString() ?? "Todos";
            string ordenarPor = comboBox1.SelectedItem?.ToString() ?? "Mais recente";
            DateTime dataSelecionada = dateTimePicker1.Value.Date;

            // Limpar os cards existentes
            flowLayoutPanel1.Controls.Clear();

            using (MySqlConnection conn = ConexaoBD.ObterConexao())
            {
                string query = "SELECT * FROM t_requerimentos WHERE 1=1";

                // Aplicar filtros
                if (status != "Todos")
                    query += " AND status_doc = @status";

                if (documento != "Todos")
                    query += " AND tipo_doc = @documento";

                query += " AND DATE(data_pedido) = @data"; // Corrigido para usar o campo correto

                // Ordenação
                if (ordenarPor == "Mais recente")
                    query += " ORDER BY data_pedido DESC";
                else
                    query += " ORDER BY data_pedido ASC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (status != "Todos")
                        cmd.Parameters.AddWithValue("@status", status);

                    if (documento != "Todos")
                        cmd.Parameters.AddWithValue("@documento", documento);

                    cmd.Parameters.AddWithValue("@data", dataSelecionada);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var req = new RequerimentoInfo
                            {
                                Id = Convert.ToInt32(reader["id_requerimento"]),
                                TipoDocumento = reader["tipo_doc"].ToString(),
                                StatusAtual = reader["status_doc"].ToString(),
                                DataSolic = Convert.ToDateTime(reader["data_pedido"]),
                                Nome = reader["nome"].ToString(),
                                RA = reader["ra"].ToString(),
                                RG = reader["rg"].ToString(),
                                Telefone = reader["telefone"].ToString(),
                                Curso = reader["curso"].ToString(),
                                Email = reader["email"].ToString()
                            };

                            var painel = CriarPainel(req);
                            flowLayoutPanel1.Controls.Add(painel);
                        }
                    }
                }
            }
        }
    }
}