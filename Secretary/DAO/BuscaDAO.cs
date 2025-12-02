using MySql.Data.MySqlClient;
using Secretary.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Secretary.DAO
{
    /// <summary>
    /// DAO responsável por realizar buscas globais no sistema
    /// </summary>
    public class BuscaDAO
    {
        /// <summary>
        /// Busca global em todas as tabelas principais do sistema
        /// </summary>
        /// <param name="termo">Termo de busca</param>
        /// <returns>Lista de resultados encontrados</returns>
        public static List<ResultadoBusca> BuscarGlobal(string termo)
        {
            List<ResultadoBusca> resultados = new List<ResultadoBusca>();

            if (string.IsNullOrWhiteSpace(termo))
                return resultados;

            string termoLike = "%" + termo.Trim() + "%";

            // Buscar em Requerimentos
            resultados.AddRange(BuscarEmRequerimentos(termoLike));

            // Buscar em Tickets
            resultados.AddRange(BuscarEmTickets(termoLike));

            // Buscar em Usuários
            resultados.AddRange(BuscarEmUsuarios(termoLike));

            return resultados;
        }

        /// <summary>
        /// Busca em requerimentos
        /// </summary>
        private static List<ResultadoBusca> BuscarEmRequerimentos(string termoLike)
        {
            List<ResultadoBusca> resultados = new List<ResultadoBusca>();

            string sql = @"
                SELECT 
                    id_requerimento,
                    nome,
                    ra,
                    cpf,
                    curso,
                    nome_doc,
                    status_doc,
                    data_pedido,
                    email
                FROM t_requerimentos
                WHERE nome LIKE @termo 
                   OR ra LIKE @termo 
                   OR cpf LIKE @termo 
                   OR email LIKE @termo 
                   OR curso LIKE @termo 
                   OR nome_doc LIKE @termo
                ORDER BY data_pedido DESC
                LIMIT 50";

            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@termo", termoLike);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resultados.Add(new ResultadoBusca
                            {
                                Id = reader.GetInt32("id_requerimento"),
                                Tipo = "Requerimento",
                                Titulo = reader["nome"]?.ToString() ?? "Sem nome",
                                Descricao = $"Documento: {reader["nome_doc"]}",
                                Status = reader["status_doc"]?.ToString() ?? "",
                                Data = reader.IsDBNull(reader.GetOrdinal("data_pedido")) ? (DateTime?)null : reader.GetDateTime("data_pedido"),
                                InfoAdicional = $"RA: {reader["ra"]} | CPF: {reader["cpf"]} | Curso: {reader["curso"]}"
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erro ao buscar requerimentos: " + ex.Message);
            }

            return resultados;
        }

        /// <summary>
        /// Busca em tickets de atendimento
        /// </summary>
        private static List<ResultadoBusca> BuscarEmTickets(string termoLike)
        {
            List<ResultadoBusca> resultados = new List<ResultadoBusca>();

            string sql = @"
                SELECT 
                    id_ticket,
                    nome_aluno,
                    ra,
                    cpf,
                    curso,
                    categoria,
                    assunto,
                    status,
                    data_pedido,
                    email
                FROM t_tickets
                WHERE nome_aluno LIKE @termo 
                   OR ra LIKE @termo 
                   OR cpf LIKE @termo 
                   OR email LIKE @termo 
                   OR curso LIKE @termo 
                   OR categoria LIKE @termo
                   OR assunto LIKE @termo
                ORDER BY data_pedido DESC
                LIMIT 50";

            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@termo", termoLike);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resultados.Add(new ResultadoBusca
                            {
                                Id = reader.GetInt32("id_ticket"),
                                Tipo = "Atendimento",
                                Titulo = reader["nome_aluno"]?.ToString() ?? "Sem nome",
                                Descricao = $"Categoria: {reader["categoria"]} - {reader["assunto"]}",
                                Status = reader["status"]?.ToString() ?? "",
                                Data = reader.IsDBNull(reader.GetOrdinal("data_pedido")) ? (DateTime?)null : reader.GetDateTime("data_pedido"),
                                InfoAdicional = $"RA: {reader["ra"]} | CPF: {reader["cpf"]} | Curso: {reader["curso"]}"
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erro ao buscar tickets: " + ex.Message);
            }

            return resultados;
        }

        /// <summary>
        /// Busca em usuários do sistema
        /// </summary>
        private static List<ResultadoBusca> BuscarEmUsuarios(string termoLike)
        {
            List<ResultadoBusca> resultados = new List<ResultadoBusca>();

            string sql = @"
                SELECT 
                    id_usuario,
                    nome_usuario,
                    email_usuario,
                    tipo_perfil,
                    criado_em,
                    ativo
                FROM t_usuarios
                WHERE nome_usuario LIKE @termo 
                   OR email_usuario LIKE @termo
                ORDER BY nome_usuario ASC
                LIMIT 50";

            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@termo", termoLike);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bool ativo = reader.GetBoolean("ativo");
                            resultados.Add(new ResultadoBusca
                            {
                                Id = reader.GetInt32("id_usuario"),
                                Tipo = "Usuário",
                                Titulo = reader["nome_usuario"]?.ToString() ?? "Sem nome",
                                Descricao = $"Email: {reader["email_usuario"]}",
                                Status = ativo ? "Ativo" : "Inativo",
                                Data = reader.IsDBNull(reader.GetOrdinal("criado_em")) ? (DateTime?)null : reader.GetDateTime("criado_em"),
                                InfoAdicional = $"Perfil: {reader["tipo_perfil"]}"
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erro ao buscar usuários: " + ex.Message);
            }

            return resultados;
        }

        /// <summary>
        /// Conta total de resultados por tipo
        /// </summary>
        public static Dictionary<string, int> ContarResultadosPorTipo(string termo)
        {
            Dictionary<string, int> contagem = new Dictionary<string, int>
            {
                { "Requerimento", 0 },
                { "Atendimento", 0 },
                { "Usuário", 0 }
            };

            if (string.IsNullOrWhiteSpace(termo))
                return contagem;

            string termoLike = "%" + termo.Trim() + "%";

            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    // Contar Requerimentos
                    string sqlReq = @"SELECT COUNT(*) FROM t_requerimentos 
                                      WHERE nome LIKE @termo OR ra LIKE @termo OR cpf LIKE @termo 
                                         OR email LIKE @termo OR curso LIKE @termo OR nome_doc LIKE @termo";
                    using (var cmd = new MySqlCommand(sqlReq, conn))
                    {
                        cmd.Parameters.AddWithValue("@termo", termoLike);
                        contagem["Requerimento"] = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                using (var conn = ConexaoBD.ObterConexao())
                {
                    // Contar Tickets
                    string sqlTicket = @"SELECT COUNT(*) FROM t_tickets 
                                         WHERE nome_aluno LIKE @termo OR ra LIKE @termo OR cpf LIKE @termo 
                                            OR email LIKE @termo OR curso LIKE @termo OR categoria LIKE @termo OR assunto LIKE @termo";
                    using (var cmd = new MySqlCommand(sqlTicket, conn))
                    {
                        cmd.Parameters.AddWithValue("@termo", termoLike);
                        contagem["Atendimento"] = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                using (var conn = ConexaoBD.ObterConexao())
                {
                    // Contar Usuários
                    string sqlUser = @"SELECT COUNT(*) FROM t_usuarios 
                                       WHERE nome_usuario LIKE @termo OR email_usuario LIKE @termo";
                    using (var cmd = new MySqlCommand(sqlUser, conn))
                    {
                        cmd.Parameters.AddWithValue("@termo", termoLike);
                        contagem["Usuário"] = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erro ao contar resultados: " + ex.Message);
            }

            return contagem;
        }
    }
}
