using System;
using System.Data;
using System.Windows.Forms;
using Secretary.DAO;
using Secretary.Forms;


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
                    "Todos", "matricula_trancamento", "documentos_emissao", "passe_escolar",
                    "estagio", "gerenciamento_curso", "outros"
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
                DataTable dtAberto = AtendimentoDAO.ListarTicketsEmAberto(curso, tipoVinculo, categoria);
                DataTable dtRespondido = AtendimentoDAO.ListarTicketsRespondidos(curso, tipoVinculo, categoria);

                datagvEmAberto.Columns.Clear();
                datagvRespondidos.Columns.Clear();

                datagvEmAberto.DataSource = dtAberto;
                datagvRespondidos.DataSource = dtRespondido;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aplicar filtros: " + ex.Message);
            }
        }

        private void datagvEmAberto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow linha = datagvEmAberto.Rows[e.RowIndex];

            int ticketId = Convert.ToInt32(linha.Cells["id_ticket"].Value);
            string nome = linha.Cells["nome_aluno"].Value?.ToString();
            string ra = linha.Cells["ra"].Value?.ToString();
            string curso = linha.Cells["curso"].Value?.ToString();
            string assunto = linha.Cells["assunto"].Value?.ToString();
            string data = DateTime.Now.ToShortDateString();
            string mensagem = assunto;

            var chat = new FormChatAtendimento(ticketId, nome, ra, curso, assunto, data, mensagem, AtualizarListas, usuarioId);
            chat.StartPosition = FormStartPosition.CenterScreen;
            chat.ShowDialog();

            AtualizarListas();
        }

        private void datagvRespondidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow linha = datagvRespondidos.Rows[e.RowIndex];

            int ticketId = Convert.ToInt32(linha.Cells["id_ticket"].Value);
            string nome = linha.Cells["nome_aluno"].Value?.ToString();
            string ra = linha.Cells["ra"].Value?.ToString();
            string curso = linha.Cells["curso"].Value?.ToString();
            string assunto = linha.Cells["assunto"].Value?.ToString();
            string data = DateTime.Now.ToShortDateString();
            string mensagem = assunto;

            var chat = new FormChatAtendimento(ticketId, nome, ra, curso, assunto, data, mensagem, AtualizarListas, usuarioId);
            chat.StartPosition = FormStartPosition.CenterScreen;
            chat.ShowDialog();

            AtualizarListas();
        }

        private void AtualizarListas()
        {
            AplicarFiltros();
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
