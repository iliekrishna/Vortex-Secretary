using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Secretary.Models;

namespace Secretary.DAO
{
    public class RequerimentoDAO
    {
        // Listar requerimentos com filtros e status (aberto ou respondido)
        public static DataTable ListarRequerimentos(string status, string curso, string documento)
        {
            string sql = "";
            List<MySqlParameter> parametros = new List<MySqlParameter>();

            if (status.ToLower() == "aberto")
            {
                sql = @"
                SELECT 
                    id_requerimento AS 'ID',
                    data_pedido AS 'Data',
                    nome AS 'Nome',
                    ra AS 'RA',
                    curso AS 'Curso',
                    nome_doc AS 'Documento Solicitado'
                FROM t_requerimentos
                WHERE (status_doc = 'Pendente' OR status_doc = 'Aberto' OR status_doc = 'Em Aberto')";
            }
            else if (status.ToLower() == "respondido")
            {
                sql = @"
                SELECT 
                    id_requerimento AS 'ID',
                    data_resposta AS 'Data de Resposta',
                    nome AS 'Nome',
                    ra AS 'RA',
                    curso AS 'Curso',
                    nome_doc AS 'Documento Solicitado',
                    (SELECT nome FROM t_usuarios WHERE id = r.id_usuario) AS 'Respondido Por'
                FROM t_requerimentos r
                WHERE (status_doc = 'Respondido' OR status_doc = 'Concluído' OR status_doc = 'Atendido')";
            }
            else
            {
                throw new ArgumentException("Status inválido. Use 'aberto' ou 'respondido'.");
            }

            if (!string.IsNullOrEmpty(curso) && curso != "Todos")
            {
                sql += " AND curso = @curso";
                parametros.Add(new MySqlParameter("@curso", curso));
            }

            if (!string.IsNullOrEmpty(documento) && documento != "Todos")
            {
                sql += " AND nome_doc = @documento";
                parametros.Add(new MySqlParameter("@documento", documento));
            }

            sql += " ORDER BY data_pedido DESC";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (parametros.Count > 0)
                    cmd.Parameters.AddRange(parametros.ToArray());

                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        // Buscar requerimento por ID, incluindo nome do usuário que respondeu
        public static Requerimento BuscarPorId(int id)
        {
            string sql = @"
                SELECT r.*, u.nome AS nome_usuario_resposta
                FROM t_requerimentos r
                LEFT JOIN t_usuarios u ON r.id_usuario = u.id
                WHERE r.id_requerimento = @id";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Requerimento
                        {
                            Id = reader.GetInt32("id_requerimento"),
                            IdUsuario = reader.IsDBNull(reader.GetOrdinal("id_usuario")) ? (int?)null : reader.GetInt32("id_usuario"),
                            RA = reader["ra"]?.ToString(),
                            Telefone = reader["telefone"]?.ToString(),
                            Curso = reader["curso"]?.ToString(),
                            Nome = reader["nome"]?.ToString(),
                            CPF = reader["cpf"]?.ToString(),
                            RG = reader["rg"]?.ToString(),
                            Email = reader["email"]?.ToString(),
                            NomeDocumento = reader["nome_doc"]?.ToString(),
                            TipoDocumento = reader["tipo_doc"]?.ToString(),
                            StatusDocumento = reader["status_doc"]?.ToString(),
                            DataPedido = reader.IsDBNull(reader.GetOrdinal("data_pedido")) ? (DateTime?)null : reader.GetDateTime("data_pedido"),
                            DataResposta = reader.IsDBNull(reader.GetOrdinal("data_resposta")) ? (DateTime?)null : reader.GetDateTime("data_resposta"),
                            Resposta = reader["resposta"]?.ToString()
                        };
                    }
                }
            }

            return null;
        }

        // Inserir novo requerimento
        public static void Inserir(Requerimento r)
        {
            string sql = @"
                INSERT INTO t_requerimentos 
                (ra, telefone, curso, nome, cpf, rg, email, nome_doc, tipo_doc, status_doc, data_pedido)
                VALUES (@ra, @telefone, @curso, @nome, @cpf, @rg, @email, @nome_doc, @tipo_doc, @status_doc, NOW())";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ra", r.RA);
                cmd.Parameters.AddWithValue("@telefone", r.Telefone);
                cmd.Parameters.AddWithValue("@curso", r.Curso);
                cmd.Parameters.AddWithValue("@nome", r.Nome);
                cmd.Parameters.AddWithValue("@cpf", r.CPF);
                cmd.Parameters.AddWithValue("@rg", r.RG);
                cmd.Parameters.AddWithValue("@email", r.Email);
                cmd.Parameters.AddWithValue("@nome_doc", r.NomeDocumento);
                cmd.Parameters.AddWithValue("@tipo_doc", r.TipoDocumento);
                cmd.Parameters.AddWithValue("@status_doc", "Pendente");

                cmd.ExecuteNonQuery();
            }
        }

        // Atualizar resposta e status do requerimento
        public static void AtualizarResposta(int idRequerimento, string resposta, string novoStatus, int idUsuario)
        {
            string sql = @"
                UPDATE t_requerimentos 
                SET resposta = @resposta, 
                    status_doc = @status_doc, 
                    data_resposta = NOW(), 
                    id_usuario = @id_usuario
                WHERE id_requerimento = @id";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@resposta", resposta);
                cmd.Parameters.AddWithValue("@status_doc", novoStatus);
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                cmd.Parameters.AddWithValue("@id", idRequerimento);

                cmd.ExecuteNonQuery();
            }
        }
    }
}