using System;
using System.Collections.Generic;
using System.Data;
using Secretary.Models;
using MySql.Data.MySqlClient;

namespace Secretary.DAO
{
    public class RequerimentoDAO
    {
        private string connStr = "server=localhost;user=root;database=miltonb_fatec_solicitacoes;password=;";

        public List<Requerimento> ListarTodos()
        {
            var lista = new List<Requerimento>();

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM t_requerimentos ORDER BY data_pedido DESC";
                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var r = new Requerimento
                    {



                        Id = reader.GetInt32("id_requerimento"),
                        IdUsuario = reader.IsDBNull(reader.GetOrdinal("id_usuario")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("id_usuario")),
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
                        DataPedido = reader.IsDBNull(reader.GetOrdinal("data_pedido")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("data_pedido")),
                        DataResposta = reader.IsDBNull(reader.GetOrdinal("data_resposta")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("data_resposta")),
                        Resposta = reader["resposta"]?.ToString()
                    };

                    lista.Add(r);
                }
            }

            return lista;
        }
        // BUSCAR POR ID
        public Requerimento BuscarPorId(int id)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM t_requerimentos WHERE id_requerimento = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Requerimento
                        {
                            Id = reader.GetInt32("id_requerimento"),
                            IdUsuario = reader.IsDBNull(reader.GetOrdinal("id_usuario")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("id_usuario")),
                            RA = reader.GetString("ra"),
                            Telefone = reader.GetString("telefone"),
                            Curso = reader.GetString("curso"),
                            Nome = reader.GetString("nome"),
                            CPF = reader.GetString("cpf"),
                            RG = reader.GetString("rg"),
                            Email = reader.GetString("email"),
                            NomeDocumento = reader.GetString("nome_doc"),
                            TipoDocumento = reader.GetString("tipo_doc"),
                            StatusDocumento = reader.GetString("status_doc"),
                            DataPedido = reader.GetDateTime("data_pedido"),
                            DataResposta = reader.IsDBNull(reader.GetOrdinal("data_resposta")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("data_resposta")),
                            Resposta = reader["resposta"]?.ToString()
                        };
                    }
                }
            }

            return null;
        }

        // ATUALIZAR STATUS/RESPOSTA
        public void AtualizarResposta(int idRequerimento, string resposta, string novoStatus, int idUsuario)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = @"UPDATE t_requerimentos 
                                 SET resposta = @Resposta, status_doc = @Status, data_resposta = NOW(), id_usuario = @IdUsuario 
                                 WHERE id_requerimento = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Resposta", resposta);
                cmd.Parameters.AddWithValue("@Status", novoStatus);
                cmd.Parameters.AddWithValue("@Id", idRequerimento);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                cmd.ExecuteNonQuery();
            }
        }

        // INSERIR
        public void Inserir(Requerimento r)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = @"INSERT INTO t_requerimentos 
                                (ra, telefone, curso, nome, cpf, rg, email, nome_doc, tipo_doc, status_doc, data_pedido)
                                VALUES (@Ra, @Telefone, @Curso, @Nome, @Cpf, @Rg, @Email, @NomeDoc, @TipoDoc, @Status, NOW())";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ra", r.RA);
                cmd.Parameters.AddWithValue("@Telefone", r.Telefone);
                cmd.Parameters.AddWithValue("@Curso", r.Curso);
                cmd.Parameters.AddWithValue("@Nome", r.Nome);
                cmd.Parameters.AddWithValue("@Cpf", r.CPF);
                cmd.Parameters.AddWithValue("@Rg", r.RG);
                cmd.Parameters.AddWithValue("@Email", r.Email);
                cmd.Parameters.AddWithValue("@NomeDoc", r.NomeDocumento);
                cmd.Parameters.AddWithValue("@TipoDoc", r.TipoDocumento);
                cmd.Parameters.AddWithValue("@Status", "Pendente");

                cmd.ExecuteNonQuery();
            }
        }
    }
}
