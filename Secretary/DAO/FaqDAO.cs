using MySql.Data.MySqlClient;
using Secretary;
using Secretary.Models;
using System;
using System.Collections.Generic;

public class FaqDAO
{
    public List<Faq> ListarTodos()
    {
        var lista = new List<Faq>();
        using (var conn = ConexaoBD.ObterConexao())
        {
            string sql = @"SELECT f.id_faq, f.pergunta, f.resposta, f.data_criacao, f.data_atualizacao,
                      f.criado_por, f.atualizado_por,
                      c.id AS categoria_id, c.nome AS nome_categoria
               FROM t_faq f
               LEFT JOIN t_faq_categoria c ON f.categoria_id = c.id
               ORDER BY f.id_faq DESC";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int? atualizadoPor = null;
                    int idxAtualizado = reader.GetOrdinal("atualizado_por");
                    if (!reader.IsDBNull(idxAtualizado))
                        atualizadoPor = reader.GetInt32(idxAtualizado);

                    int idCategoria = 0;
                    string nomeCategoria = null;
                    int idxCat = reader.GetOrdinal("categoria_id");
                    if (!reader.IsDBNull(idxCat))
                        idCategoria = reader.GetInt32(idxCat);
                    int idxNomeCat = reader.GetOrdinal("nome_categoria");
                    if (!reader.IsDBNull(idxNomeCat))
                        nomeCategoria = reader.GetString(idxNomeCat);

                    lista.Add(new Faq
                    {
                        Id = reader.GetInt32("id_faq"),
                        Pergunta = reader.GetString("pergunta"),
                        Resposta = reader.GetString("resposta"),
                        DataCriacao = reader.GetDateTime("data_criacao"),
                        DataAtualizacao = reader.GetDateTime("data_atualizacao"),
                        CriadoPor = reader.GetInt32("criado_por"),
                        AtualizadoPor = atualizadoPor,
                        IdCategoria = idCategoria,
                        NomeCategoria = nomeCategoria
                    });
                }
            }
        }
        return lista;
    }
    public void Inserir(Faq faq)
    {
        using (var conn = ConexaoBD.ObterConexao())
        {
            string sql = @"INSERT INTO t_faq (pergunta, resposta, criado_por, categoria_id) 
                           VALUES (@pergunta, @resposta, @criado_por, @id_categoria)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pergunta", faq.Pergunta);
            cmd.Parameters.AddWithValue("@resposta", faq.Resposta);
            cmd.Parameters.AddWithValue("@criado_por", faq.CriadoPor);
            cmd.Parameters.AddWithValue("@id_categoria", faq.IdCategoria);
            cmd.ExecuteNonQuery();
        }
    }
    public bool AtualizarFaq(Faq faq)
    {
        try
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                string sql = @"UPDATE t_faq 
                           SET pergunta = @pergunta, 
                               resposta = @resposta, 
                               atualizado_por = @atualizado_por, 
                               categoria_id = @id_categoria,
                               data_atualizacao = NOW()
                           WHERE id_faq = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pergunta", faq.Pergunta);
                cmd.Parameters.AddWithValue("@resposta", faq.Resposta);

                // Se não tiver valor para AtualizadoPor, envia DBNull
                cmd.Parameters.AddWithValue("@atualizado_por", faq.AtualizadoPor ?? (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@id_categoria", faq.IdCategoria);

                cmd.Parameters.AddWithValue("@id", faq.Id);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
        catch
        {
            return false;
        }
    }
    public void Excluir(int id)
    {
        using (var conn = ConexaoBD.ObterConexao())
        {
            string sql = "DELETE FROM t_faq WHERE id_faq=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
    internal void Atualizar(Faq faqAtualizada)
    {
        throw new NotImplementedException();
    }
    internal Faq ObterPorId(int id)
    {
        throw new NotImplementedException();
    }
    public static List<Categoria> ListarCategoriasOrdenadas()
    {
        var lista = new List<Categoria>();
        using (var conn = ConexaoBD.ObterConexao())
        {
            string sql = @"
            SELECT id, nome
            FROM t_faq_categoria
            ORDER BY (nome = 'Outros') ASC, id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Categoria
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome")
                    });
                }
            }
        }
        return lista;
    }


}