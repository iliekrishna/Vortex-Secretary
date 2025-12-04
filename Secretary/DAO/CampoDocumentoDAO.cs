using MySql.Data.MySqlClient;
using Secretary.Models;
using System.Collections.Generic;

namespace Secretary.DAO
{
    public class CampoDocumentoDAO
    {
        // INSERIR CAMPO
        public void Inserir(CampoDocumento campo)
        {
            string sql = @"
                INSERT INTO t_campos_documento
                    (id_disponibilidade, nome_campo, obrigatorio_segunda_via)
                VALUES
                    (@id, @nome, @obrigatorio)";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", campo.IdDocumento);
                cmd.Parameters.AddWithValue("@nome", campo.NomeCampo);
                cmd.Parameters.AddWithValue("@obrigatorio", campo.Obrigatorio ? "Sim" : "Não");

                cmd.ExecuteNonQuery();
            }
        }

        // LISTAR CAMPO POR DOCUMENTO
        public List<CampoDocumento> ListarPorDocumento(int idDoc)
        {
            List<CampoDocumento> lista = new List<CampoDocumento>();

            string sql = @"
                SELECT id_campo, nome_campo, obrigatorio_segunda_via
                FROM t_campos_documento
                WHERE id_disponibilidade = @id";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idDoc);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new CampoDocumento
                        {
                            IdCampo = reader.GetInt32("id_campo"),
                            IdDocumento = idDoc,
                            NomeCampo = reader.GetString("nome_campo"),
                            Obrigatorio = reader.GetString("obrigatorio_segunda_via") == "Sim"
                        });
                    }
                }
            }

            return lista;
        }

        // EXCLUIR CAMPO DO DOCUMENTO
        public void Excluir(int idCampo)
        {
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(
                "DELETE FROM t_campos_documento WHERE id_campo = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", idCampo);
                cmd.ExecuteNonQuery();
            }
        }

        // BUSCAR CAMPO DA IMAGEM (1 POR DOCUMENTO)
        public CampoDocumento BuscarCampoImagem(int idDoc)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                string sql = @"
                    SELECT nome_campo, obrigatorio_segunda_via
                    FROM t_campos_documento
                    WHERE id_disponibilidade = @id
                    LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idDoc);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new CampoDocumento
                        {
                            NomeCampo = reader.GetString("nome_campo"),
                            Obrigatorio = reader.GetString("obrigatorio_segunda_via") == "Sim"
                        };
                    }
                }
            }

            return null;
        }
    }
}
