using Secretary;
using Secretary.DAO;
using Secretary.Models;
using System;
using System.Data;
using System.IO;
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

            // Preenche os dados
            lblNome.Text = "Nome: " + ticket.NomeAluno;
            lblCPF.Text = "CPF: " + ticket.CPF;
            lblVinculo.Text = "Vínculo: " + ticket.TipoVinculo;
            lblEmail.Text = "E-mail: " + ticket.Email;
            lblAssunto.Text = "Categoria: " + ticket.Categoria;
            lblData.Text = "Data: " + ticket.DataPedido.ToString("dd/MM/yyyy HH:mm");

            if (ticket.TipoVinculo == "Comunidade externa")
            {
                lblRA.Visible = false;
                lblCurso.Visible = false;
            }
            else
            {
                lblRA.Visible = true;
                lblCurso.Visible = true;
                lblRA.Text = "RA: " + ticket.RA;
                lblCurso.Text = "Curso: " + ticket.Curso;
            }

            txtHistorico.Text = "[Visitante]: " + (ticket.Assunto ?? "");

            if (!string.IsNullOrWhiteSpace(ticket.Resposta))
                txtHistorico.AppendText(Environment.NewLine + ticket.Resposta);

            this.Shown += FormChatAtendimento_Shown;
        }
        private void CarregarResposta()
        {
            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    string sql = "SELECT resposta FROM t_tickets WHERE id_ticket = @id";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", ticketId);
                        var resposta = cmd.ExecuteScalar()?.ToString();

                        if (!string.IsNullOrEmpty(resposta))
                        {
                            txtHistorico.AppendText(Environment.NewLine + resposta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar resposta: " + ex.Message);
            }
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
            if (!string.IsNullOrWhiteSpace(txtResposta.Text))
            {
                string novaMensagem = txtResposta.Text.Trim();

                if (novaMensagem.Length < 5)
                {
                    MessageBox.Show("A resposta está muito curta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mensagemFormatada = FormatMensagemSecretaria(novaMensagem);

                // Exibe no histórico
                txtHistorico.AppendText(Environment.NewLine + Environment.NewLine + mensagemFormatada);
                txtHistorico.SelectionStart = txtHistorico.Text.Length;
                txtHistorico.ScrollToCaret();

                try
                {
                    using (var conn = ConexaoBD.ObterConexao())
                    {
                        // Obtém resposta anterior
                        string respostaAnterior = "";
                        string sqlSelect = "SELECT resposta FROM t_tickets WHERE id_ticket = @id";

                        using (var cmdSelect = new MySql.Data.MySqlClient.MySqlCommand(sqlSelect, conn))
                        {
                            cmdSelect.Parameters.AddWithValue("@id", ticketId);
                            var resultado = cmdSelect.ExecuteScalar();
                            respostaAnterior = resultado?.ToString() ?? "";
                        }

                        // Concatena nova resposta
                        string novaResposta = string.IsNullOrWhiteSpace(respostaAnterior)
                            ? mensagemFormatada
                            : respostaAnterior + Environment.NewLine + Environment.NewLine + mensagemFormatada;

                        // Atualiza no banco
                        string sqlUpdate = @"UPDATE t_tickets 
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

                        // Limpa e fecha
                        txtResposta.Clear();
                        AtualizarListas?.Invoke();
                        RegistrarLog($"Ticket {ticketId} respondido por usuário {Sessao.UsuarioId}.");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar resposta: " + ex.Message);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string justificativa = txtResposta.Text.Trim();

            if (string.IsNullOrEmpty(justificativa))
            {
                MessageBox.Show("Por favor, informe a justificativa para exclusão.", "Justificativa necessária", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                        cmd.Parameters.AddWithValue("@justificativa", "[Encerrado]: " + justificativa);
                        cmd.Parameters.AddWithValue("@status", "Encerrado");
                        cmd.Parameters.AddWithValue("@data", DateTime.Now);
                        cmd.Parameters.AddWithValue("@usuarioId", Sessao.UsuarioId);
                        cmd.Parameters.AddWithValue("@id", ticketId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dúvida excluída com justificativa.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarListas?.Invoke();
                            RegistrarLog($"Ticket {ticketId} encerrado por usuário {Sessao.UsuarioId}.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível excluir a dúvida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir a dúvida: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatMensagemSecretaria(string mensagem)
        {
            return $"[Secretaria - {DateTime.Now:dd/MM/yyyy HH:mm}]: {mensagem}";
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