using System;
using System.Windows.Forms;
using Secretary.DAO;
using Secretary.Models;

namespace Secretary.Forms.Atendimentos
{
    public partial class FormDetalhesAtendimento : Form
    {
        private int ticketId;

        public FormDetalhesAtendimento(int ticketId)
        {
            InitializeComponent();
            this.ticketId = ticketId;
        }

        private void FormDetalhesAtendimento_Load(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = AtendimentoDAO.BuscarPorId(ticketId);

                if (ticket == null)
                {
                    MessageBox.Show("Ticket não encontrado.");
                    this.Close();
                    return;
                }

                txtNome.Text = $"{ticket.NomeAluno}";
                txtCPF.Text = $"{ticket.CPF}";
                txtVinculo.Text = $"{ticket.TipoVinculo}";
                txtCategoria.Text = $"{ticket.Categoria}";
                txtEmail.Text = $"{ticket.Email}";
                txtStatus.Text = $"{ticket.Status}";
                txtDataResposta.Text = $"{(ticket.DataResposta.HasValue ? ticket.DataResposta.Value.ToString("dd/MM/yyyy") : "Não respondido")}";
                lblRespondidoPor.Text = $"Respondido por: {(string.IsNullOrWhiteSpace(ticket.UsuarioResposta) ? "Ainda não respondido" : ticket.UsuarioResposta)}";
                txtDataEnvio.Text = $"{ticket.DataPedido.ToString("dd/MM/yyyy")}";

                txtHistorico.Text = ticket.Assunto;
                txtRespostaEnviada.Text = string.IsNullOrWhiteSpace(ticket.Resposta) ? "Ainda não houve resposta." : ticket.Resposta;

                // Mostra RA e Curso, exceto para Comunidade Externa
                if (ticket.TipoVinculo == "Comunidade externa")
                {
                    lblRA.Visible = false;
                    txtRA.Visible = false;
                    lblCurso.Visible = false;
                    txtCurso.Visible = false;
                }
                else
                {
                    lblRA.Visible = true;
                    lblCurso.Visible = true;
                    txtRA.Visible = true;
                    txtCurso.Visible = true;
                    txtRA.Text = $"{ticket.RA}";
                    txtCurso.Text = $"{ticket.Curso}";
                }
                this.Select();  // seleciona o form
                this.ActiveControl = null; // remove foco do controle interno
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os detalhes do atendimento:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
    }
}