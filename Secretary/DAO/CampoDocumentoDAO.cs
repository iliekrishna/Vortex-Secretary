using MySql.Data.MySqlClient;
using Secretary.Models;
using System;
using System.Collections.Generic;

namespace Secretary.DAO
{
    public class CampoDocumentoDAO
    {
        // =============================================
        // INSERIR - retorna ID do campo criado
        // =============================================
        public int Inserir(CampoDocumento campo)
        {
            string sql = @"
        INSERT INTO t_campos_documento
        (id_disponibilidade, nome_campo, tipo_campo, opcoes_combobox, campo_obrigatorio)
        VALUES
        (@id, @nome, @tipo, @opcoes, @obrigatorio);
        SELECT LAST_INSERT_ID();";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", campo.IdDocumento);
                cmd.Parameters.AddWithValue("@nome", campo.NomeCampo);
                cmd.Parameters.AddWithValue("@tipo", campo.TipoCampo);
                cmd.Parameters.AddWithValue("@opcoes", string.IsNullOrWhiteSpace(campo.OpcoesCombobox) ? null : campo.OpcoesCombobox);
                cmd.Parameters.AddWithValue("@obrigatorio", campo.Obrigatorio ? 1 : 0);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // =============================================
        // BUSCAR POR ID
        // =============================================
        public CampoDocumento BuscarPorId(int idCampo)
        {
            string sql = @"
                SELECT id_campo, id_disponibilidade, nome_campo, tipo_campo, opcoes_combobox, campo_obrigatorio
                FROM t_campos_documento
                WHERE id_campo = @id";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idCampo);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new CampoDocumento
                        {
                            IdCampo = reader.GetInt32("id_campo"),
                            IdDocumento = reader.GetInt32("id_disponibilidade"),
                            NomeCampo = reader.GetString("nome_campo"),
                            TipoCampo = reader.GetString("tipo_campo"),
                            OpcoesCombobox = reader.IsDBNull(reader.GetOrdinal("opcoes_combobox"))
                                ? null
                                : reader.GetString("opcoes_combobox"),
                            Obrigatorio = !reader.IsDBNull(reader.GetOrdinal("campo_obrigatorio")) &&
                                Convert.ToInt32(reader["campo_obrigatorio"]) == 1
                        };
                    }
                }
            }

            return null;
        }

        // =============================================
        // ATUALIZAR
        // =============================================
        public void Atualizar(CampoDocumento campo)
        {
            string sql = @"
                UPDATE t_campos_documento
                SET nome_campo = @nome,
                    tipo_campo = @tipo,
                    opcoes_combobox = @opcoes,
                    campo_obrigatorio = @obrigatorio
                WHERE id_campo = @idcampo";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@idcampo", campo.IdCampo);
                cmd.Parameters.AddWithValue("@nome", campo.NomeCampo);
                cmd.Parameters.AddWithValue("@tipo", campo.TipoCampo);
                cmd.Parameters.AddWithValue("@opcoes",
                    string.IsNullOrWhiteSpace(campo.OpcoesCombobox) ? null : campo.OpcoesCombobox);
                cmd.Parameters.AddWithValue("@obrigatorio", campo.Obrigatorio ? 1 : 0);

                cmd.ExecuteNonQuery();
            }
        }

        // =============================================
        // LISTAR CAMPOS POR DOCUMENTO
        // =============================================
        public List<CampoDocumento> ListarPorDocumento(int idDoc)
        {
            List<CampoDocumento> lista = new List<CampoDocumento>();

            string sql = @"
                SELECT id_campo, nome_campo, tipo_campo, opcoes_combobox, campo_obrigatorio
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
                            TipoCampo = reader.GetString("tipo_campo"),
                            OpcoesCombobox = reader.IsDBNull(reader.GetOrdinal("opcoes_combobox"))
                                ? null
                                : reader.GetString("opcoes_combobox"),
                            Obrigatorio = !reader.IsDBNull(reader.GetOrdinal("campo_obrigatorio")) &&
              Convert.ToInt32(reader["campo_obrigatorio"]) == 1
                        });
                    }
                }
            }

            return lista;
        }

        // =============================================
        // REMOVER CAMPO
        // =============================================
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

        // =============================================
        // LISTAR OPÇÕES (uma por linha)
        // =============================================
        public List<string> ListarOpcoes(int idCampo)
        {
            CampoDocumento campo = BuscarPorId(idCampo);

            if (campo?.OpcoesCombobox == null)
                return new List<string>();

            string[] linhas = campo.OpcoesCombobox
                .Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            return new List<string>(linhas);
        }

        // =============================================
        // REMOVER TODAS AS OPÇÕES
        // =============================================
        public void RemoverOpcoes(int idCampo)
        {
            string sql = @"UPDATE t_campos_documento 
                           SET opcoes_combobox = NULL 
                           WHERE id_campo = @id";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idCampo);
                cmd.ExecuteNonQuery();
            }
        }

        // =============================================
        // ADICIONAR UMA OPÇÃO (acrescenta na coluna)
        // =============================================
        public void AdicionarOpcao(int idCampo, string opcao)
        {
            CampoDocumento campo = BuscarPorId(idCampo);

            string novasOpcoes;

            if (campo.OpcoesCombobox == null)
                novasOpcoes = opcao;
            else
                novasOpcoes = campo.OpcoesCombobox + "\n" + opcao;

            string sql = @"UPDATE t_campos_documento 
                           SET opcoes_combobox = @opcoes 
                           WHERE id_campo = @id";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idCampo);
                cmd.Parameters.AddWithValue("@opcoes", novasOpcoes);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
