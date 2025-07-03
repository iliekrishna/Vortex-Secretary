using System;
using System.Collections.Generic;
using System.Data;
using Secretary.Models;
using MySql.Data.MySqlClient;

namespace Secretary.DAO
{
    public class AtendimentoDAO
    {
        public static DataTable ListarTickets(string status, string curso, string vinculo, string categoria)
        {
            string sql = @" 
                           SELECT 
                              data_pedido AS 'Data do Ticket',
                              nome_aluno AS 'Nome do Aluno',
                              categoria AS 'Categoria',
                              curso AS 'Curso',
                              ra AS 'RA',
                              id_ticket AS 'Código',
                              assunto AS 'Assunto'
                            FROM t_tickets


                          WHERE 1=1";

            List<MySqlParameter> parametros = new List<MySqlParameter>();

            if (status == "aberto")
                sql += " AND (resposta IS NULL OR resposta = '')";
            else if (status == "respondido")
                sql += " AND status = 'respondido' AND resposta IS NOT NULL AND resposta <> ''";

            if (curso != "Todos") { sql += " AND curso = @curso"; parametros.Add(new MySqlParameter("@curso", curso)); }
            if (vinculo != "Todos") { sql += " AND tipo_vinculo = @vinculo"; parametros.Add(new MySqlParameter("@vinculo", vinculo)); }
            if (categoria != "Todos") { sql += " AND categoria = @categoria"; parametros.Add(new MySqlParameter("@categoria", categoria)); }

            return ConexaoBD.ExecutarConsultaComParametros(sql, parametros);
        }

        public static Ticket BuscarPorId(int id)
        {
            string sql = @"
        SELECT t.*, u.nome_usuario AS nome_usuario_resposta
        FROM t_tickets t
        LEFT JOIN t_usuarios u ON t.id_usuario = u.id_usuario
        WHERE t.id_ticket = @id";

            List<MySqlParameter> parametros = new List<MySqlParameter> { new MySqlParameter("@id", id) };

            DataTable dt = ConexaoBD.ExecutarConsultaComParametros(sql, parametros);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Ticket
                {
                    Id = Convert.ToInt32(row["id_ticket"]),
                    NomeAluno = row["nome_aluno"]?.ToString() ?? "",
                    RA = row["ra"]?.ToString() ?? "",
                    Curso = row["curso"]?.ToString() ?? "",
                    Assunto = row["assunto"]?.ToString() ?? "",
                    Resposta = row["resposta"]?.ToString() ?? "",
                    Status = row["status"]?.ToString() ?? "",
                    TipoVinculo = row["tipo_vinculo"]?.ToString() ?? "",
                    Categoria = row["categoria"]?.ToString() ?? "",
                    Email = row["email"]?.ToString() ?? "",  
                    CPF = row["cpf"]?.ToString() ?? "",      
                    DataPedido = Convert.ToDateTime(row["data_pedido"]),
                    DataResposta = row["data_resposta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["data_resposta"]),
                    UsuarioResposta = row["nome_usuario_resposta"]?.ToString() ?? ""
                };
            }

            return null;
        }


        public static void Inserir(Ticket ticket)
        {
            string sql = @"INSERT INTO t_tickets (nome_aluno, ra, curso, assunto, resposta, status, tipo_vinculo, categoria, data_pedido) 
                           VALUES (@nome_aluno, @ra, @curso, @assunto, @resposta, @status, @tipo_vinculo, @categoria, @data_pedido)";

            using (var cmd = new MySqlCommand(sql, ConexaoBD.ObterConexao()))
            {
                cmd.Parameters.AddWithValue("@nome_aluno", ticket.NomeAluno);
                cmd.Parameters.AddWithValue("@ra", ticket.RA);
                cmd.Parameters.AddWithValue("@curso", ticket.Curso);
                cmd.Parameters.AddWithValue("@assunto", ticket.Assunto);
                cmd.Parameters.AddWithValue("@resposta", ticket.Resposta ?? "");
                cmd.Parameters.AddWithValue("@status", ticket.Status ?? "Pendente");
                cmd.Parameters.AddWithValue("@tipo_vinculo", ticket.TipoVinculo);
                cmd.Parameters.AddWithValue("@categoria", ticket.Categoria);
                cmd.Parameters.AddWithValue("@data_pedido", ticket.DataPedido);
                cmd.ExecuteNonQuery();
            }
        }

        public static void AtualizarResposta(int ticketId, string resposta, string status, DateTime? dataResposta = null)
        {
            string sql = @"UPDATE t_tickets 
                           SET resposta = @resposta, status = @status, data_resposta = @data_resposta 
                           WHERE id_ticket = @id";

            using (var cmd = new MySqlCommand(sql, ConexaoBD.ObterConexao()))
            {
                cmd.Parameters.AddWithValue("@resposta", resposta);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@data_resposta", dataResposta ?? DateTime.Now);
                cmd.Parameters.AddWithValue("@id", ticketId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
