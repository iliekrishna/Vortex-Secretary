using MySql.Data.MySqlClient;
using Secretary;
using Secretary.Models;
using System.Collections.Generic;

public class CategoriaDAO
{
    public List<Categoria> ListarCategorias()
    {
        var lista = new List<Categoria>();
        using (var conn = ConexaoBD.ObterConexao())
        {
            string sql = "SELECT id, nome FROM t_faq_categoria ORDER BY nome";
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
    public void Inserir(string nome)
    {
        using (var conn = ConexaoBD.ObterConexao())
        {
            string sql = "INSERT INTO t_faq_categoria (nome) VALUES (@nome)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.ExecuteNonQuery();
        }
    }

    public void AtualizarNome(int id, string novoNome)
    {
        using (var conn = ConexaoBD.ObterConexao())
        {
            string sql = "UPDATE t_faq_categoria SET nome = @nome WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", novoNome);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
    public void Excluir(int id)
    {
        using (var conn = ConexaoBD.ObterConexao())
        {
            // Excluir todas as perguntas da categoria
            string sqlExcluirFaqs = "DELETE FROM t_faq WHERE categoria_id = @id";
            MySqlCommand cmdExcluirFaqs = new MySqlCommand(sqlExcluirFaqs, conn);
            cmdExcluirFaqs.Parameters.AddWithValue("@id", id);
            cmdExcluirFaqs.ExecuteNonQuery();

            // Excluir a categoria
            string sqlExcluirCategoria = "DELETE FROM t_faq_categoria WHERE id = @id";
            MySqlCommand cmdExcluirCategoria = new MySqlCommand(sqlExcluirCategoria, conn);
            cmdExcluirCategoria.Parameters.AddWithValue("@id", id);
            cmdExcluirCategoria.ExecuteNonQuery();
        }
    }
}
