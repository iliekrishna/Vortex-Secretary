using System;
using System.Collections.Generic;
using System.Data;
using Secretary.Models;
using MySql.Data.MySqlClient;

namespace Secretary.DAO
{
    public class AtendimentoDAO
    {
        public static DataTable ListarTicketsEmAberto(string curso, string vinculo, string categoria)
        {
            string sql = "SELECT * FROM t_tickets WHERE (resposta IS NULL OR resposta = '')";

            if (curso != "Todos") sql += $" AND curso = '{curso}'";
            if (vinculo != "Todos") sql += $" AND tipo_vinculo = '{vinculo}'";
            if (categoria != "Todos") sql += $" AND categoria = '{categoria}'";

            return ConexaoBD.ExecutarConsulta(sql);
        }

        public static DataTable ListarTicketsRespondidos(string curso, string vinculo, string categoria)
        {
            string sql = "SELECT * FROM t_tickets WHERE status = 'respondido' AND resposta IS NOT NULL AND resposta <> ''";

            if (curso != "Todos") sql += $" AND curso = '{curso}'";
            if (vinculo != "Todos") sql += $" AND tipo_vinculo = '{vinculo}'";
            if (categoria != "Todos") sql += $" AND categoria = '{categoria}'";

            return ConexaoBD.ExecutarConsulta(sql);
        }

        public static Ticket BuscarPorId(int id)
        {
            string sql = $"SELECT * FROM t_tickets WHERE id_ticket = {id}";
            DataTable dt = ConexaoBD.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Ticket
                {
                    Id = Convert.ToInt32(row["id_ticket"]),
                    NomeAluno = row["nome_aluno"].ToString(),
                    RA = row["ra"].ToString(),
                    Curso = row["curso"].ToString(),
                    Assunto = row["assunto"].ToString(),
                    Mensagem = row["mensagem"].ToString(),
                    Resposta = row["resposta"].ToString(),
                    Status = row["status"].ToString(),
                    TipoVinculo = row["tipo_vinculo"].ToString(),
                    Categoria = row["categoria"].ToString(),
                    DataPedido = Convert.ToDateTime(row["data_pedido"]),
                    DataResposta = row["data_resposta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["data_resposta"])
                };
            }

            return null;
        }

        public static void Inserir(Ticket ticket)
        {
            string sql = "INSERT INTO t_tickets (nome_aluno, ra, curso, assunto, mensagem, resposta, status, tipo_vinculo, categoria, data_pedido) " +
                         "VALUES (@nome_aluno, @ra, @curso, @assunto, @mensagem, @resposta, @status, @tipo_vinculo, @categoria, @data_pedido)";

            MySqlCommand cmd = new MySqlCommand(sql, ConexaoBD.ObterConexao());
            cmd.Parameters.AddWithValue("@nome_aluno", ticket.NomeAluno);
            cmd.Parameters.AddWithValue("@ra", ticket.RA);
            cmd.Parameters.AddWithValue("@curso", ticket.Curso);
            cmd.Parameters.AddWithValue("@assunto", ticket.Assunto);
            cmd.Parameters.AddWithValue("@mensagem", ticket.Mensagem);
            cmd.Parameters.AddWithValue("@resposta", ticket.Resposta ?? "");
            cmd.Parameters.AddWithValue("@status", ticket.Status ?? "Pendente");
            cmd.Parameters.AddWithValue("@tipo_vinculo", ticket.TipoVinculo);
            cmd.Parameters.AddWithValue("@categoria", ticket.Categoria);
            cmd.Parameters.AddWithValue("@data_pedido", ticket.DataPedido);

            cmd.ExecuteNonQuery();
        }

        public static void AtualizarResposta(int ticketId, string resposta, string status, DateTime? dataResposta = null)
        {
            string sql = "UPDATE t_tickets SET resposta = @resposta, status = @status, data_resposta = @data_resposta WHERE id_ticket = @id";

            MySqlCommand cmd = new MySqlCommand(sql, ConexaoBD.ObterConexao());
            cmd.Parameters.AddWithValue("@resposta", resposta);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@data_resposta", dataResposta ?? DateTime.Now);
            cmd.Parameters.AddWithValue("@id", ticketId);

            cmd.ExecuteNonQuery();
        }
    }
}