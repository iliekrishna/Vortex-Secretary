using Secretary;
using Secretary.DAO;
using Secretary.Models;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Secretary.Forms.Atendimentos
{
    public partial class FormChatAtendimento : Form
    {
        private int ticketId;
        private Action AtualizarListas;

        public FormChatAtendimento(int ticketId, string nome, string ra, string curso, string assunto, string data, string conteudo, Action AtualizarListas, int usuarioId)
        {
            InitializeComponent();

            this.ticketId = ticketId;
            Sessao.UsuarioId = usuarioId;
            this.AtualizarListas = AtualizarListas;

            Ticket ticket = AtendimentoDAO.BuscarPorId(ticketId);

            if (ticket == null)
            {
                MessageBox.Show("Ticket não encontrado.");
                this.Close();
                return;
            }

            PreencherDadosTicket(ticket);
            CarregarHistorico(ticket);

            this.Shown += FormChatAtendimento_Shown;
        }

        private void PreencherDadosTicket(Ticket ticket)
        {
            txtNome.Text = ticket.NomeAluno;
            txtCPF.Text = ticket.CPF;
            txtVinculo.Text = ticket.TipoVinculo;
            txtEmail.Text = ticket.Email;
            txtAssunto.Text = ticket.Categoria;
            txtData.Text = ticket.DataPedido.ToString("dd/MM/yyyy");

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
                txtRA.Visible = true;
                lblCurso.Visible = true;
                txtCurso.Visible = true;
                txtRA.Text = ticket.RA;
                txtCurso.Text = ticket.Curso;
            }
        }

        private void CarregarHistorico(Ticket ticket)
        {
            // Limpa histórico antes de carregar
            txtHistorico.Clear();

            // Mensagem inicial do visitante (aluno), sem data/hora, mas com prefixo simples
            txtHistorico.AppendText($"[Visitante]: {ticket.Assunto ?? ""}");

            // Se houver resposta salva, carrega com prefixos e quebras de linha
            if (!string.IsNullOrWhiteSpace(ticket.Resposta))
            {
                txtHistorico.AppendText(Environment.NewLine + Environment.NewLine + FormatHistoricoExibicao(ticket.Resposta));
            }
        }

        private string FormatHistoricoExibicao(string textoSalvo)
        {
            // O texto salvo no banco é só mensagens puras separadas por quebras
            return textoSalvo;
        }

        private void FormChatAtendimento_Shown(object sender, EventArgs e)
        {
            txtHistorico.SelectionStart = txtHistorico.Text.Length;
            txtHistorico.SelectionLength = 0;
            txtHistorico.ScrollToCaret();
            txtResposta.Focus();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResposta.Text))
            {
                MessageBox.Show("Digite uma resposta antes de enviar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string novaMensagem = txtResposta.Text.Trim();

            if (novaMensagem.Length < 5)
            {
                MessageBox.Show("A resposta está muito curta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Adiciona no histórico a mensagem formatada
            AdicionarMensagemNoHistorico("Secretaria", novaMensagem);

            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    // Busca a resposta atual
                    string sqlSelect = "SELECT resposta FROM t_tickets WHERE id_ticket = @id";
                    string respostaAnterior = "";

                    using (var cmdSelect = new MySql.Data.MySqlClient.MySqlCommand(sqlSelect, conn))
                    {
                        cmdSelect.Parameters.AddWithValue("@id", ticketId);
                        var resultado = cmdSelect.ExecuteScalar();
                        respostaAnterior = resultado?.ToString() ?? "";
                    }

                    // Concatena a nova mensagem pura (sem prefixo)
                    var sb = new StringBuilder();
                    if (!string.IsNullOrWhiteSpace(respostaAnterior))
                        sb.Append(respostaAnterior.TrimEnd() + Environment.NewLine + Environment.NewLine);
                    sb.Append(novaMensagem);

                    string novaResposta = sb.ToString();

                    // Atualiza o banco
                    string sqlUpdate = @"
                        UPDATE t_tickets
                        SET resposta = @resposta, 
                            data_resposta = @dataResposta, 
                            status = @status, 
                            id_usuario = @idUsuario 
                        WHERE id_ticket = @id";

                    using (var cmdUpdate = new MySql.Data.MySqlClient.MySqlCommand(sqlUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@resposta", novaResposta);
                        cmdUpdate.Parameters.AddWithValue("@dataResposta", DateTime.Now);
                        cmdUpdate.Parameters.AddWithValue("@status", "Respondido");
                        cmdUpdate.Parameters.AddWithValue("@idUsuario", Sessao.UsuarioId);
                        cmdUpdate.Parameters.AddWithValue("@id", ticketId);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    // Limpa campo resposta e atualiza listas
                    txtResposta.Clear();
                    AtualizarListas?.Invoke();
                    RegistrarLog($"Ticket {ticketId} respondido por usuário {Sessao.UsuarioId}.");
                    MessageBox.Show("Resposta enviada com sucesso.", "Respondido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar resposta: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string justificativa = txtResposta.Text.Trim();

            if (string.IsNullOrEmpty(justificativa))
            {
                MessageBox.Show("Por favor, informe a justificativa para cancelamento.", "Justificativa necessária", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show("Deseja realmente cancelar este ticket?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes)
                return;

            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    string sqlUpdate = @"
                        UPDATE t_tickets
                        SET resposta = @justificativa,
                            status = @status,
                            data_resposta = @data,
                            id_usuario = @usuarioId
                        WHERE id_ticket = @id";

                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlUpdate, conn))
                    {
                        // Salva só a justificativa pura no banco
                        cmd.Parameters.AddWithValue("@justificativa", justificativa);
                        cmd.Parameters.AddWithValue("@status", "Cancelado");
                        cmd.Parameters.AddWithValue("@data", DateTime.Now);
                        cmd.Parameters.AddWithValue("@usuarioId", Sessao.UsuarioId);
                        cmd.Parameters.AddWithValue("@id", ticketId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Adiciona no histórico com prefixo e data
                            AdicionarMensagemNoHistorico("Cancelado", justificativa);

                            MessageBox.Show("Dúvida cancelada com justificativa.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarListas?.Invoke();
                            RegistrarLog($"Ticket {ticketId} cancelado por usuário {Sessao.UsuarioId}.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível cancelar a dúvida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cancelar a dúvida: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Adiciona mensagem ao histórico txtHistorico com prefixo e data/hora.
        /// </summary>
        private void AdicionarMensagemNoHistorico(string remetente, string mensagem)
        {
            string prefixo = $"[{remetente} - {DateTime.Now:dd/MM/yyyy}]: ";
            txtHistorico.AppendText(Environment.NewLine + Environment.NewLine + prefixo + mensagem);
            txtHistorico.SelectionStart = txtHistorico.Text.Length;
            txtHistorico.ScrollToCaret();
        }

        private void RegistrarLog(string mensagem)
        {
            try
            {
                File.AppendAllText("logs_respostas.txt", $"{DateTime.Now:dd/MM/yyyy HH:mm:ss} - {mensagem}{Environment.NewLine}");
            }
            catch
            {
                // Falha ao registrar log não deve quebrar o sistema
            }
        }
    }
}
