using MySql.Data.MySqlClient;
using Secretary.Models;
using System;
using System.Collections.Generic;

namespace Secretary.DAO
{
    public class DocumentoDAO
    {
        public void Inserir(DocumentoDisponivel doc)
        {
            string sql = @"
                INSERT INTO t_disponibilidade_doc 
                    (nome_doc, descricao, status_atual, precisa_pagamento_segunda_via)
                VALUES 
                    (@nome, @desc, @status, @pagamento)";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@nome", doc.Nome);
                cmd.Parameters.AddWithValue("@desc", doc.Descricao);
                cmd.Parameters.AddWithValue("@status", doc.StatusAtual);
                cmd.Parameters.AddWithValue("@pagamento", doc.PrecisaPagamentoSegundaVia);

                cmd.ExecuteNonQuery();
            }
        }

        public int ObterUltimoIdInserido()
        {
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool ExisteDocumento(string nome)
        {
            string sql = "SELECT COUNT(*) FROM t_disponibilidade_doc WHERE nome_doc = @nome";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@nome", nome);

                int qtd = Convert.ToInt32(cmd.ExecuteScalar());
                return qtd > 0;
            }
        }

        public List<DocumentoDisponivel> ListarTodos()
        {
            var lista = new List<DocumentoDisponivel>();

            string sql = @"
                SELECT 
                    id_disponibilidade, 
                    nome_doc, 
                    descricao, 
                    status_atual,
                    precisa_pagamento_segunda_via
                FROM t_disponibilidade_doc
                ORDER BY nome_doc ASC";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new DocumentoDisponivel
                    {
                        Id = reader.GetInt32("id_disponibilidade"),
                        Nome = reader.GetString("nome_doc"),
                        Descricao = reader.GetString("descricao"),
                        StatusAtual = reader.GetString("status_atual"),
                        PrecisaPagamentoSegundaVia = reader.GetInt32("precisa_pagamento_segunda_via")
                    });
                }
            }

            return lista;
        }

        public DocumentoDisponivel BuscarPorId(int id)
        {
            string sql = @"
        SELECT id_disponibilidade, nome_doc, descricao, status_atual, precisa_pagamento_segunda_via
        FROM t_disponibilidade_doc
        WHERE id_disponibilidade = @id";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new DocumentoDisponivel
                        {
                            Id = reader.GetInt32("id_disponibilidade"),
                            Nome = reader.GetString("nome_doc"),
                            Descricao = reader.GetString("descricao"),
                            StatusAtual = reader.GetString("status_atual"),
                            PrecisaPagamentoSegundaVia = reader.GetInt32("precisa_pagamento_segunda_via")
                        };
                    }
                }
            }

            return null;
        }

        public void Atualizar(DocumentoDisponivel doc)
        {
            string sql = @"
        UPDATE t_disponibilidade_doc
        SET nome_doc = @nome,
            descricao = @desc,
            status_atual = @status,
            precisa_pagamento_segunda_via = @pagamento
        WHERE id_disponibilidade = @id";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", doc.Id);
                cmd.Parameters.AddWithValue("@nome", doc.Nome);
                cmd.Parameters.AddWithValue("@desc", doc.Descricao);
                cmd.Parameters.AddWithValue("@status", doc.StatusAtual);
                cmd.Parameters.AddWithValue("@pagamento", doc.PrecisaPagamentoSegundaVia);

                cmd.ExecuteNonQuery();
            }
        }

        public bool ExisteDocumentoExcetoId(string nome, int idExcluir)
        {
            string sql = "SELECT COUNT(*) FROM t_disponibilidade_doc WHERE nome_doc = @nome AND id_disponibilidade != @id";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@id", idExcluir);

                int qtd = Convert.ToInt32(cmd.ExecuteScalar());
                return qtd > 0;
            }
        }

    }
}
