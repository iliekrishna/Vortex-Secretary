using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Secretary.Models;

namespace Secretary.DAO
{
    public class DocumentoDAO
    {
        public bool CadastrarDocumento(DocumentoDisponivel doc)
        {
            using (var conexao = ConexaoBD.ObterConexao())
            {
                string sql = @"INSERT INTO t_disponibilidade_doc (nome_doc, descricao, status_atual)
                               VALUES (@Nome, @Descricao, @Status)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Nome", doc.Nome);
                    cmd.Parameters.AddWithValue("@Descricao", doc.Descricao);
                    cmd.Parameters.AddWithValue("@Status", doc.StatusAtual);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<DocumentoDisponivel> ListarTodos()
        {
            var lista = new List<DocumentoDisponivel>();

            using (var conn = ConexaoBD.ObterConexao())
            {
                string sql = "SELECT * FROM t_disponibilidade_doc ORDER BY status_atual DESC, nome_doc ASC";
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
                            StatusAtual = reader.GetString("status_atual")
                        });
                    }
                }
            }

            return lista;
        }

        public bool ExisteDocumento(string nome)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                string sql = "SELECT COUNT(*) FROM t_disponibilidade_doc WHERE nome_doc = @Nome";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
    }
}
