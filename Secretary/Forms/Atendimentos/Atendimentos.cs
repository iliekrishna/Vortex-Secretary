using Secretary.DAO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Secretary.Forms.Atendimentos
{
    public partial class Atendimentos : Form
    {
        private int usuarioId;
        public Atendimentos(int usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            this.Load += Atendimentos_Load;
            txtBuscar.TextChanged += (s, e) =>
            {
                // Opcional: debounce para evitar buscas a cada tecla
                AplicarFiltros();
            };
            ConfigurarHintTxtBuscar();
        }
        private void Atendimentos_Load(object sender, EventArgs e)
        {
            try
            {
                cbCurso.Items.AddRange(new string[] {
                    "Todos", "Logística Aeroportuária", "Logística Tarde", "Logística Noite",
                    "Gestão Empresarial (EAD)", "Análise e Desenvolvimento de Sistemas",
                    "Comércio Exterior", "Gestão da Produção Industrial"
                });

                cbVinculo.Items.AddRange(new string[] {
                    "Todos", "Aluno", "Ex-aluno", "Comunidade externa"
                });

                cbCategoria.Items.AddRange(new string[] {
                    "Todos", "Matrícula e Trancamento", "Documentos e Emissão", "Passe Escolar",
                    "Estágio", "Gerenciamento de Curso", "Outros"
                });

                cbCurso.SelectedIndex = 0;
                cbVinculo.SelectedIndex = 0;
                cbCategoria.SelectedIndex = 0;

                cbCurso.SelectedIndexChanged += (s, ev) => AplicarFiltros();
                cbVinculo.SelectedIndexChanged += (s, ev) => AplicarFiltros();
                cbCategoria.SelectedIndexChanged += (s, ev) => AplicarFiltros();

                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tickets: " + ex.Message);
            }
        }
        private void AplicarFiltros()
        {
            string curso = cbCurso.SelectedItem?.ToString() ?? "Todos";
            string tipoVinculo = cbVinculo.SelectedItem?.ToString() ?? "Todos";
            string categoria = cbCategoria.SelectedItem?.ToString() ?? "Todos";
            string termoBusca = txtBuscar.Text.Trim();

            // Se txtBuscar estiver vazio ou com texto padrão, envie null para não filtrar por termo
            if (string.IsNullOrWhiteSpace(termoBusca) || termoBusca == "Digite nome, RA ou CPF")
            {
                termoBusca = null;
            }

            try
            {
                DataTable dtAberto = AtendimentoDAO.ListarTickets("aberto", curso, tipoVinculo, categoria, termoBusca);
                DataTable dtRespondido = AtendimentoDAO.ListarTickets("respondido", curso, tipoVinculo, categoria, termoBusca);

                datagvEmAberto.Columns.Clear();
                datagvRespondidos.Columns.Clear();

                datagvEmAberto.DataSource = dtAberto;
                datagvRespondidos.DataSource = dtRespondido;

                MarcarSituacaoRespondido(datagvRespondidos);

                AjustarColunasAberto(datagvEmAberto);
                AjustarColunasRespondido(datagvRespondidos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aplicar filtros: " + ex.Message);
            }        
        }
        private void AjustarColunasAberto(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.HeaderText == "Código")
                {
                    col.Visible = false;
                }
            }
        }
        private void AjustarColunasRespondido(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.HeaderText == "Código")
                {
                    col.Visible = false;
                }
            }
        }
        private void MarcarSituacaoRespondido(DataGridView dgv)
        {
            if (!dgv.Columns.Contains("Situação"))
            {
                dgv.Columns.Add("Situação", "Situação");
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                // Verifica a coluna já vinda do banco
                var status = row.Cells["Situação"].Value?.ToString()?.ToLower();

                if (status == "cancelado")
                    row.Cells["Situação"].Value = "Cancelado";
                else if (status == "respondido")
                    row.Cells["Situação"].Value = "Respondido";
            }
            // Reposiciona a coluna "Situação" depois de "Data da Resposta"
            if (dgv.Columns.Contains("Data da Resposta") && dgv.Columns.Contains("Situação"))
            {
                int indexData = dgv.Columns["Data da Resposta"].DisplayIndex;
                dgv.Columns["Situação"].DisplayIndex = indexData + 1;
            }
        }
        private void AtualizarListas()
        {
            AplicarFiltros();
        }
        private void datagvRespondidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idTicket = Convert.ToInt32(datagvRespondidos.Rows[e.RowIndex].Cells["Código"].Value);

                FormDetalhesAtendimento detalhesForm = new FormDetalhesAtendimento(idTicket);
                detalhesForm.ShowDialog();
            }
        }
        private void datagvEmAberto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var linha = datagvEmAberto.Rows[e.RowIndex];
            string nome = linha.Cells["Nome Completo"].Value?.ToString();
            string ra = linha.Cells["RA"].Value?.ToString();
            string curso = linha.Cells["Curso"].Value?.ToString();
            string categoria = linha.Cells["Categoria"].Value?.ToString();
            string data = Convert.ToDateTime(linha.Cells["Data da Solicitação"].Value).ToString("dd/MM/yyyy HH:mm");
            int ticketId = Convert.ToInt32(linha.Cells["Código"].Value);

            string assunto = "";
            string mensagem = "";

            var chat = new FormChatAtendimento(ticketId, nome, ra, curso, assunto, data, mensagem, AtualizarListas, usuarioId);
            chat.StartPosition = FormStartPosition.CenterScreen;
            chat.ShowDialog();

            AtualizarListas();
        }
        private void datagvRespondidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idTicket = Convert.ToInt32(datagvRespondidos.Rows[e.RowIndex].Cells["Código"].Value);

            FormDetalhesAtendimento detalhesForm = new FormDetalhesAtendimento(idTicket);
            detalhesForm.ShowDialog();
        }
        private void datagvEmAberto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var linha = datagvEmAberto.Rows[e.RowIndex];
            string nome = linha.Cells["Nome Completo"].Value?.ToString();
            string ra = linha.Cells["RA"].Value?.ToString();
            string curso = linha.Cells["Curso"].Value?.ToString();
            string categoria = linha.Cells["Categoria"].Value?.ToString();
            string data = Convert.ToDateTime(linha.Cells["Data da Solicitação"].Value).ToString("dd/MM/yyyy HH:mm");
            int ticketId = Convert.ToInt32(linha.Cells["Código"].Value);

            string assunto = "";
            string mensagem = "";

            var chat = new FormChatAtendimento(ticketId, nome, ra, curso, assunto, data, mensagem, AtualizarListas, usuarioId);
            chat.StartPosition = FormStartPosition.CenterScreen;
            chat.ShowDialog();

            AtualizarListas();
        }

        private string textoHint = "Digite nome, RA ou CPF";

        private void ConfigurarHintTxtBuscar()
        {
            txtBuscar.ForeColor = SystemColors.GrayText;
            txtBuscar.Text = textoHint;

            txtBuscar.Enter += (s, e) =>
            {
                if (txtBuscar.Text == textoHint)
                {
                    txtBuscar.Text = "";
                    txtBuscar.ForeColor = SystemColors.WindowText;
                }
            };

            txtBuscar.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    txtBuscar.Text = textoHint;
                    txtBuscar.ForeColor = SystemColors.GrayText;
                }
            };
        }
    }
}
