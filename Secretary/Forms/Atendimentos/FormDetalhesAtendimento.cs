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

                lblNome.Text = $"Nome: {ticket.NomeAluno}";
                lblCPF.Text = $"CPF: {ticket.CPF}";
                lblVinculo.Text = $"Vínculo: {ticket.TipoVinculo}";
                lblCategoria.Text = $"Categoria: {ticket.Categoria}";
                lblEmail.Text = $"Email: {ticket.Email}";
                lblDataResposta.Text = $"Data da resposta: {(ticket.DataResposta.HasValue ? ticket.DataResposta.Value.ToString("dd/MM/yyyy HH:mm") : "Não respondido")}";
                lblUsuarioResposta.Text = $"Respondido por: {(string.IsNullOrWhiteSpace(ticket.UsuarioResposta) ? "Ainda não respondido" : ticket.UsuarioResposta)}";
                lblDataTicket.Text = $"Data do envio: {ticket.DataPedido.ToString("dd/MM/yyyy HH:mm")}";

                txtMensagem.Text = ticket.Assunto;
                txtResposta.Text = string.IsNullOrWhiteSpace(ticket.Resposta) ? "Ainda não houve resposta." : ticket.Resposta;

                // Mostra RA e Curso, exceto para Comunidade Externa
                if (ticket.TipoVinculo == "Comunidade externa")
                {
                    lblRA.Visible = false;
                    lblCurso.Visible = false;
                }
                else
                {
                    lblRA.Visible = true;
                    lblEmail.Visible = true;
                    lblRA.Text = $"RA: {ticket.RA}";
                    lblCurso.Text = $"Curso: {ticket.Curso}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os detalhes do atendimento:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}