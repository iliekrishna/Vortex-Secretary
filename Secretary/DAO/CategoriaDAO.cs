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
}
