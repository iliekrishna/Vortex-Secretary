using Secretary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SeuProjeto
{
    public partial class FormChatAtendimento : Form
    {


        private int ticketId;
        private Action AtualizarListas;

        public FormChatAtendimento(int ticketId, string nome, string ra, string curso, string assunto, string data, string conteudo, Action AtualizarListas, int usuarioId)
        {
            InitializeComponent();

            this.ticketId = ticketId;

            // Setar Sessao.UsuarioId aqui
            Sessao.UsuarioId = usuarioId;

            //MessageBox.Show("ID do usuário logado: " + Sessao.UsuarioId);

            this.AtualizarListas = AtualizarListas;

            lblNome.Text = "Nome: " + nome;
            lblRA.Text = "RA: " + ra;
            lblCurso.Text = "Curso: " + curso;
            lblAssunto.Text = "Assunto: " + assunto;
            lblData.Text = "Data: " + data;
            txtHistorico.Text = "[Visitante]: " + conteudo;



            CarregarResposta(); // Carrega respostas salvas se tiver



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
            txtResposta.Focus();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(txtResposta.Text))
            {
                string resposta = txtResposta.Text.Trim();

                // Adiciona no histórico da tela
                txtHistorico.AppendText(Environment.NewLine + Environment.NewLine + "[Secretaria - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "]: " + resposta);

                try
                {
                    using (var conn = ConexaoBD.ObterConexao())
                    {
                        // Busca a resposta anterior se existir
                        string sqlSelect = "SELECT resposta FROM t_tickets WHERE id_ticket = @id";
                        string respostaAnterior = "";

                        using (var cmdSelect = new MySql.Data.MySqlClient.MySqlCommand(sqlSelect, conn))
                        {
                            cmdSelect.Parameters.AddWithValue("@id", ticketId);
                            var resultado = cmdSelect.ExecuteScalar();
                            respostaAnterior = resultado != null ? resultado.ToString() : "";
                        }

                        // Junta com a nova resposta
                        string novaResposta = respostaAnterior;
                        if (!string.IsNullOrWhiteSpace(respostaAnterior))
                            novaResposta += Environment.NewLine + Environment.NewLine + "[Secretaria]: " + resposta;
                        else
                            novaResposta = "[Secretaria]: " + resposta;

                        // Atualiza a hora da resposta
                        DateTime dataHoraResposta = DateTime.Now;

                        // Atualiza o status
                        string status = "Respondido";

                        // Atualiza no banco com as duas respostas
                        string sqlUpdate = "UPDATE t_tickets SET resposta = @resposta, data_resposta = @dataResposta, status = @status, id_usuario = @idUsuario WHERE id_ticket = @id ";
                        using (var cmdUpdate = new MySql.Data.MySqlClient.MySqlCommand(sqlUpdate, conn))
                        {
                            cmdUpdate.Parameters.AddWithValue("@resposta", novaResposta);
                            cmdUpdate.Parameters.AddWithValue("@dataResposta", dataHoraResposta);
                            cmdUpdate.Parameters.AddWithValue("@status", status);
                            cmdUpdate.Parameters.AddWithValue("@idUsuario", Sessao.UsuarioId);
                            cmdUpdate.Parameters.AddWithValue("@id", ticketId);
                            //MessageBox.Show("ID do usuário na sessão: " + Sessao.UsuarioId); teste de id do usuario
                            cmdUpdate.ExecuteNonQuery();
                            txtResposta.Clear();
                            this.Close();
                        }
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

        private void lblAssunto_Click(object sender, EventArgs e)
        {
            // NADA, msm do outro
        }
    }
}
