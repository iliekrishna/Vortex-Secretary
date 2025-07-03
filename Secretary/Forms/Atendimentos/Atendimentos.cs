using System;
using System.Data;
using System.Windows.Forms;
using Secretary.DAO;

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
                    "Estágio", "Gerenciamento do Curso", "Outros"
                });

                cbCurso.SelectedIndex = 0;
                cbVinculo.SelectedIndex = 0;
                cbCategoria.SelectedIndex = 0;

                cbCurso.SelectedIndexChanged += (s, ev) => AplicarFiltros();
                cbVinculo.SelectedIndexChanged += (s, ev) => AplicarFiltros();
                cbCategoria.SelectedIndexChanged += (s, ev) => AplicarFiltros();

                AplicarFiltros();

                btnSimular.Enabled = false;
                btnSimular.Visible = false;
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

            try
            {
                DataTable dtAberto = AtendimentoDAO.ListarTickets("aberto", curso, tipoVinculo, categoria);
                DataTable dtRespondido = AtendimentoDAO.ListarTickets("respondido", curso, tipoVinculo, categoria);

                datagvEmAberto.Columns.Clear();
                datagvRespondidos.Columns.Clear();

                datagvEmAberto.DataSource = dtAberto;
                datagvRespondidos.DataSource = dtRespondido;

                RenomearColunas(datagvRespondidos);
                RenomearColunas(datagvEmAberto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aplicar filtros: " + ex.Message);
            }
        }

        private void RenomearColunas(DataGridView dgv)
        {
            string[] colunas = { "Código", "Nome do Aluno", "RA", "Curso", "Assunto", "Data do Ticket" };
            foreach (DataGridViewColumn col in datagvRespondidos.Columns)
            {
                Console.WriteLine(col.HeaderText);
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
            string nome = linha.Cells["Nome do Aluno"].Value?.ToString();
            string ra = linha.Cells["RA"].Value?.ToString();
            string curso = linha.Cells["Curso"].Value?.ToString();
            string assunto = linha.Cells["Assunto"].Value?.ToString();
            string data = Convert.ToDateTime(linha.Cells["Data do Ticket"].Value).ToString("dd/MM/yyyy HH:mm");
            int ticketId = Convert.ToInt32(linha.Cells["Código"].Value);
            string mensagem = assunto; // Ou buscar campo "mensagem" se estiver disponível na grid

            var chat = new FormChatAtendimento(ticketId, nome, ra, curso, assunto, data, mensagem, AtualizarListas, usuarioId);
            chat.StartPosition = FormStartPosition.CenterScreen;
            chat.ShowDialog();

            AtualizarListas();
        }

        private void datagvRespondidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            datagvRespondidos_CellContentClick(sender, e);
        }

        private void datagvEmAberto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            datagvEmAberto_CellContentClick(sender, e);
        }

        private void Atendimentos_Load_1(object sender, EventArgs e)
        {

        }
    }
}