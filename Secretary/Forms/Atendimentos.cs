using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeuProjeto;
using Secretary;




namespace Secretary.Forms
{
    public partial class Atendimentos : Form
    {

        private int usuarioId;  // armazena o id do usuario

       

        private void CarregarTicketsEmAberto()
        {
            // Não usado no inicio atualmente
            string sql = "SELECT * FROM t_tickets WHERE resposta IS NULL OR resposta = ''";
            DataTable dtTickets = ConexaoBD.ExecutarConsulta(sql);
            datagvEmAberto.Columns.Clear();
            datagvEmAberto.DataSource = dtTickets;
        }

        private void CarregarTicketsRespondidos()
        {
            // Não usado no inicio atualmente
            string sql = "SELECT * FROM t_tickets WHERE status = 'Respondido' AND resposta IS NOT NULL AND resposta <> ''";
            DataTable dtTickets = ConexaoBD.ExecutarConsulta(sql);
            datagvRespondidos.Columns.Clear();
            datagvRespondidos.DataSource = dtTickets;
        }
        public Atendimentos(int usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            this.Load += Atendimentos_Load; // garante que o forms é carregado
        }

        private void Atendimentos_Load(object sender, EventArgs e)
        {
            try
            {
                // Adiciona as opções aos ComboBox
                cbCurso.Items.AddRange(new string[] { "Todos", "Logística Aeroportuária", "Logística Tarde", "Logística Noite", "Gestão Empresarial (EAD)", "Análise e Desenvolvimento de Sistemas", "Comércio Exterior", "Gestão da Produção Industrial" });
                cbVinculo.Items.AddRange(new string[] { "Todos", "Aluno", "Ex-aluno", "Comunidade externa" });
                cbCategoria.Items.AddRange(new string[] { "Todos", "matricula_trancamento", "documentos_emissao", "passe_escolar", "estagio", "gerenciamento_curso", "outros" });

                // Inicia com os filtros desativados
                cbCurso.SelectedIndex = 0;
                cbVinculo.SelectedIndex = 0;
                cbCategoria.SelectedIndex = 0;

                // Aplicação automatica do filtro
                cbCurso.SelectedIndexChanged += (s, ev) => AplicarFiltros();
                cbVinculo.SelectedIndexChanged += (s, ev) => AplicarFiltros();
                cbCategoria.SelectedIndexChanged += (s, ev) => AplicarFiltros();

                // Carrega os dados já com filtro aplicado
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tickets: " + ex.Message);
            }

            btnSimular.Enabled = false;
            btnSimular.Visible = false;   // Desativa o botão de simular atendimento
        }

        private void datagvEmAberto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Pega a linha clicada
                DataGridViewRow linha = datagvEmAberto.Rows[e.RowIndex];

                // Extrai os dados da linha
                string nome = linha.Cells["nome_aluno"].Value?.ToString();
                string ra = linha.Cells["ra"].Value?.ToString();
                string curso = linha.Cells["curso"].Value?.ToString();
                string assunto = linha.Cells["assunto"].Value?.ToString();
                string data = DateTime.Now.ToShortDateString();
                string mensagem = assunto; 

                // Abre o formulário com os dados
                int ticketId = Convert.ToInt32(linha.Cells["id_ticket"].Value); // pega o id da linha clicada
                FormChatAtendimento chat = new FormChatAtendimento(ticketId, nome, ra, curso, assunto, data, mensagem, AtualizarListas, this.usuarioId);
                chat.StartPosition = FormStartPosition.CenterScreen;
                chat.ShowDialog(); 

                
                AtualizarListas();
            }
        }

        private void datagvRespondidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Pega a linha clicada
                DataGridViewRow linha = datagvRespondidos.Rows[e.RowIndex];

                // Extrai os dados da linha
                string nome = linha.Cells["nome_aluno"].Value?.ToString();
                string ra = linha.Cells["ra"].Value?.ToString();
                string curso = linha.Cells["curso"].Value?.ToString();
                string assunto = linha.Cells["assunto"].Value?.ToString();
                string data = DateTime.Now.ToShortDateString(); 
                string mensagem = assunto; 

                // Abre o formulário com os dados
                int ticketId = Convert.ToInt32(linha.Cells["id_ticket"].Value); 
                FormChatAtendimento chat = new FormChatAtendimento(ticketId, nome, ra, curso, assunto, data, mensagem, AtualizarListas, this.usuarioId);
                chat.StartPosition = FormStartPosition.CenterScreen;
                chat.ShowDialog(); // Aguarda o fechamento do chat

                
                AtualizarListas();
            }
        }



        private void AtualizarListas()
        {
            CarregarTicketsEmAberto();
            CarregarTicketsRespondidos();
        }

        private void AplicarFiltros()
        {
            string curso = cbCurso.SelectedItem?.ToString();
            string tipoVinculo = cbVinculo.SelectedItem?.ToString();
            string categoria = cbCategoria.SelectedItem?.ToString();

            // Recarrega tudo
            string sql = "SELECT * FROM t_tickets WHERE 1=1";

            if (curso != "Todos")
                sql += $" AND curso = '{curso}'";
            if (tipoVinculo != "Todos")
                sql += $" AND tipo_vinculo = '{tipoVinculo}'";
            if (categoria != "Todos")
                sql += $" AND categoria = '{categoria}'";

            try
            {
                DataTable dtAberto = ConexaoBD.ExecutarConsulta(sql + " AND (resposta IS NULL OR resposta = '')");
                DataTable dtRespondido = ConexaoBD.ExecutarConsulta(sql + " AND status = 'respondido' AND resposta IS NOT NULL AND resposta <> ''");

                // Remove colunas extras
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

        private void label4_Click(object sender, EventArgs e)
        {
            // NADA, não apaga isso pq eu quase perdi o forms td e tive que voltar no backup
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //NADA, terceira vez q faço isso
        }

        private void cbVinculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //NADA, dnv
        }


        // SIMULAR ATENDIMENTO
        /* private void btnSimular_Click(object sender, EventArgs e)
         {
                 // Cria o fundo escurecido pegando a tela toda
                 Form overlay = new Form();
                 overlay.FormBorderStyle = FormBorderStyle.None;
                 overlay.BackColor = Color.Black;
                 overlay.Opacity = 0.5;
                 overlay.StartPosition = FormStartPosition.Manual;
                 overlay.Bounds = Screen.PrimaryScreen.Bounds;
                 overlay.ShowInTaskbar = false;
                 overlay.TopMost = true; // Garante que fique por cima

                 // Mostra o fundo escurecido
                 overlay.Show();

                 // Cria e configura o formulário de atendimento centralizado na tela
                 FormChatAtendimento chat = new FormChatAtendimento(
                     0, // id falso
                     "Lucas da Silva",
                     "123456",
                     "ADS",
                     "Solicitação de Histórico",
                     "23/05/2025",
                     "Olá, gostaria de saber como solicitar meu histórico escolar.",
                     null,
                     this.usuarioId
                 );
                 chat.StartPosition = FormStartPosition.CenterScreen;
                 chat.TopMost = true; // Garante que fique sobre a overlay

                 // Mostra o formulário de atendimento
                 chat.ShowDialog();

                 // Fecha o fundo escurecido após o atendimento
                 overlay.Close();
         }*/
    }
}
