using MySql.Data.MySqlClient;
using Secretary.Models;
using System;
using System.Collections.Generic;

namespace Secretary.DAO
{
    public class BuscaDAO
    {
        public static List<ResultadoBusca> BuscarGlobal(string termo)
        {
            var resultados = new List<ResultadoBusca>();

            if (string.IsNullOrWhiteSpace(termo))
                return resultados;

            string termoBusca = "%" + termo.Trim() + "%";

            // Buscar Requerimentos
            resultados.AddRange(BuscarRequerimentos(termoBusca));

            // Buscar Tickets/Atendimentos
            resultados.AddRange(BuscarTickets(termoBusca));

            // Buscar Usuários
            resultados.AddRange(BuscarUsuarios(termoBusca));

            return resultados;
        }

        private static List<ResultadoBusca> BuscarRequerimentos(string termo)
        {
            var lista = new List<ResultadoBusca>();
            string sql = @"SELECT id_requerimento, nome, ra, cpf, curso, nome_doc, status_doc, data_pedido
                           FROM t_requerimentos
                           WHERE nome LIKE @termo OR ra LIKE @termo OR cpf LIKE @termo 
                              OR email LIKE @termo OR curso LIKE @termo OR nome_doc LIKE @termo
                           ORDER BY data_pedido DESC LIMIT 50";

            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@termo", termo);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ResultadoBusca
                            {
                                Id = reader.GetInt32("id_requerimento"),
                                Tipo = "Requerimento",
                                Nome = reader["nome"]?.ToString() ?? "",
                                Descricao = reader["nome_doc"]?.ToString() ?? "",
                                Status = reader["status_doc"]?.ToString() ?? "",
                                Data = reader.IsDBNull(reader.GetOrdinal("data_pedido")) ? null : (DateTime?)reader.GetDateTime("data_pedido"),
                                Detalhes = $"RA: {reader["ra"]} | Curso: {reader["curso"]}"
                            });
                        }
                    }
                }
            }
            catch { }

            return lista;
        }

        private static List<ResultadoBusca> BuscarTickets(string termo)
        {
            var lista = new List<ResultadoBusca>();
            string sql = @"SELECT id_ticket, nome_aluno, ra, cpf, curso, categoria, assunto, status, data_pedido
                           FROM t_tickets
                           WHERE nome_aluno LIKE @termo OR ra LIKE @termo OR cpf LIKE @termo 
                              OR email LIKE @termo OR curso LIKE @termo OR categoria LIKE @termo OR assunto LIKE @termo
                           ORDER BY data_pedido DESC LIMIT 50";

            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@termo", termo);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ResultadoBusca
                            {
                                Id = reader.GetInt32("id_ticket"),
                                Tipo = "Atendimento",
                                Nome = reader["nome_aluno"]?.ToString() ?? "",
                                Descricao = $"{reader["categoria"]} - {reader["assunto"]}",
                                Status = reader["status"]?.ToString() ?? "",
                                Data = reader.IsDBNull(reader.GetOrdinal("data_pedido")) ? null : (DateTime?)reader.GetDateTime("data_pedido"),
                                Detalhes = $"RA: {reader["ra"]} | Curso: {reader["curso"]}"
                            });
                        }
                    }
                }
            }
            catch { }

            return lista;
        }

        private static List<ResultadoBusca> BuscarUsuarios(string termo)
        {
            var lista = new List<ResultadoBusca>();
            string sql = @"SELECT id_usuario, nome_usuario, email_usuario, tipo_perfil, criado_em, ativo
                           FROM t_usuarios
                           WHERE nome_usuario LIKE @termo OR email_usuario LIKE @termo
                           ORDER BY nome_usuario LIMIT 50";

            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@termo", termo);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ResultadoBusca
                            {
                                Id = reader.GetInt32("id_usuario"),
                                Tipo = "Usuário",
                                Nome = reader["nome_usuario"]?.ToString() ?? "",
                                Descricao = reader["email_usuario"]?.ToString() ?? "",
                                Status = reader.GetBoolean("ativo") ? "Ativo" : "Inativo",
                                Data = reader.IsDBNull(reader.GetOrdinal("criado_em")) ? null : (DateTime?)reader.GetDateTime("criado_em"),
                                Detalhes = $"Perfil: {reader["tipo_perfil"]}"
                            });
                        }
                    }
                }
            }
            catch { }

            return lista;
        }
    }
}
