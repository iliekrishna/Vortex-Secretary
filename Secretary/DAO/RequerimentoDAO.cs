using MySql.Data.MySqlClient;
using Secretary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretary.DAO
{
    public class RequerimentoDAO
    {
        // Método privado que monta a query base e parâmetros comuns
        private static (string sqlBase, List<MySqlParameter> parametros) MontarQueryBase(string status, string curso, string documento)
        {
            string sqlBase;
            List<MySqlParameter> parametros = new List<MySqlParameter>();

            if (status.ToLower() == "aberto")
            {
                sqlBase = @"
                FROM t_requerimentos
                WHERE (status_doc = 'Pendente' OR status_doc = 'Aberto' OR status_doc = 'Em Aberto')";
            }
            else if (status.ToLower() == "respondido")
            {
                sqlBase = @"
                FROM t_requerimentos r
                LEFT JOIN t_usuarios u ON r.id_usuario = u.id_usuario
                WHERE (r.status_doc = 'Respondido' OR r.status_doc = 'Cancelado' OR r.status_doc = 'Atendido')";
            }
            else
            {
                throw new ArgumentException("Status inválido. Use 'aberto' ou 'respondido'.");
            }

            if (!string.IsNullOrEmpty(curso) && curso != "Todos")
            {
                sqlBase += " AND curso = @curso";
                parametros.Add(new MySqlParameter("@curso", curso));
            }

            if (!string.IsNullOrEmpty(documento) && documento != "Todos")
            {
                sqlBase += " AND nome_doc = @documento";
                parametros.Add(new MySqlParameter("@documento", documento));
            }

            return (sqlBase, parametros);
        }

        // Método privado para executar a consulta e retornar DataTable
        private static DataTable ExecutarConsulta(string sql, List<MySqlParameter> parametros)
        {
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (parametros != null && parametros.Count > 0)
                    cmd.Parameters.AddRange(parametros.ToArray());

                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        // Listar requerimentos sem filtro de termo
        public static DataTable ListarRequerimentos(string status, string curso, string documento)
        {
            try
            {
                var (sqlBase, parametros) = MontarQueryBase(status, curso, documento);

                string selectClause = status.ToLower() == "aberto"
                ? @"SELECT 
                    id_requerimento AS 'ID',
                    data_pedido AS 'Data',
                    nome AS 'Nome',
                    ra AS 'RA',
                    curso AS 'Curso',
                    tipo_vinculo AS 'Tipo de Vínculo',
                    nome_doc AS 'Documento Solicitado' "
                : @"SELECT 
                    r.id_requerimento AS 'ID',
                    r.data_resposta AS 'Data de Resposta',
                    r.nome AS 'Nome',
                    r.ra AS 'RA',
                    r.curso AS 'Curso',
                    r.tipo_vinculo AS 'Tipo de Vínculo',
                    r.nome_doc AS 'Documento Solicitado',
                    u.nome_usuario AS 'Respondido Por' ";

                string orderBy = status.ToLower() == "aberto"
                    ? " ORDER BY data_pedido DESC"
                    : " ORDER BY data_resposta DESC, r.id_requerimento DESC";

                string sql = selectClause + sqlBase + orderBy;

                return ExecutarConsulta(sql, parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar requerimentos: " + ex.Message, ex);
            }
        }

        // Buscar requerimentos com filtro de termo (nome, CPF ou RA)
        public static DataTable BuscarRequerimentos(string status, string curso, string documento, string termo)
        {
            try
            {
                var (sqlBase, parametros) = MontarQueryBase(status, curso, documento);

                if (!string.IsNullOrEmpty(termo))
                {
                    sqlBase += " AND (nome LIKE @termo OR ra LIKE @termo OR cpf LIKE @termo)";
                    parametros.Add(new MySqlParameter("@termo", "%" + termo + "%"));
                }

                string selectClause = status.ToLower() == "aberto"
                ? @"SELECT 
            id_requerimento AS 'ID',
            data_pedido AS 'Data',
            nome AS 'Nome',
            ra AS 'RA',
            cpf AS 'CPF',
            curso AS 'Curso',
            tipo_vinculo AS 'Tipo de Vínculo',
            nome_doc AS 'Documento Solicitado' "
                : @"SELECT 
            r.id_requerimento AS 'ID',
            r.data_resposta AS 'Data de Resposta',
            r.nome AS 'Nome',
            r.ra AS 'RA',
            r.cpf AS 'CPF',
            r.curso AS 'Curso',
            r.tipo_vinculo AS 'Tipo de Vínculo',
            r.nome_doc AS 'Documento Solicitado',
            u.nome_usuario AS 'Respondido Por' ";

                string orderBy = status.ToLower() == "aberto"
                    ? " ORDER BY data_pedido DESC"
                    : " ORDER BY data_resposta DESC, r.id_requerimento DESC";

                string sql = selectClause + sqlBase + orderBy;

                return ExecutarConsulta(sql, parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar requerimentos: " + ex.Message, ex);
            }
        }

        // Buscar requerimento por ID, incluindo nome do usuário que respondeu
        public static Requerimento BuscarPorId(int id)
        {
            string sql = @"
        SELECT r.*, u.nome_usuario AS nome_usuario_resposta, d.id_disponibilidade
        FROM t_requerimentos r
        LEFT JOIN t_usuarios u ON r.id_usuario = u.id_usuario
        LEFT JOIN t_disponibilidade_doc d ON r.nome_doc = d.nome_doc
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
                            StatusDocumento = reader["status_doc"]?.ToString(),
                            DataPedido = reader.IsDBNull(reader.GetOrdinal("data_pedido")) ? (DateTime?)null : reader.GetDateTime("data_pedido"),
                            DataResposta = reader.IsDBNull(reader.GetOrdinal("data_resposta")) ? (DateTime?)null : reader.GetDateTime("data_resposta"),
                            Resposta = reader["resposta"]?.ToString(),
                            IdImagem = reader.IsDBNull(reader.GetOrdinal("id_imagem")) ? (int?)null : reader.GetInt32("id_imagem"),
                            NomeUsuarioResposta = reader["nome_usuario_resposta"]?.ToString(),
                            IdDisponibilidade = reader.IsDBNull(reader.GetOrdinal("id_disponibilidade")) ? (int?)null : reader.GetInt32("id_disponibilidade"),
                            TipoVinculo = reader["tipo_vinculo"]?.ToString()  // <-- novo campo
                        };
                    }
                }
            }

            return null;
        }

        public static int? ObterIdDisponibilidadePorNomeDoc(string nomeDoc)
        {
            string sql = "SELECT id_disponibilidade FROM t_disponibilidade_doc WHERE nome_doc = @nomeDoc LIMIT 1";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@nomeDoc", nomeDoc);

                var result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    return id;
                }
            }
            return null;
        }

        // Inserir novo requerimento
        public static void Inserir(Requerimento r)
        {
            string sql = @"
            INSERT INTO t_requerimentos 
            (ra, telefone, curso, nome, cpf, rg, email, nome_doc, tipo_doc, status_doc, data_pedido, tipo_vinculo)
            VALUES (@ra, @telefone, @curso, @nome, @cpf, @rg, @email, @nome_doc, @tipo_doc, @status_doc, NOW(), @tipo_vinculo)";

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
                cmd.Parameters.AddWithValue("@tipo_vinculo", r.TipoVinculo ?? (object)DBNull.Value);

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

        // Lista os documentos para o filtro de documentos
        public static List<string> ListarDocumentosDisponiveis()
        {
            List<string> documentos = new List<string>();

            string sql = @"
        SELECT nome_doc 
        FROM t_disponibilidade_doc 
        WHERE status_atual = 'Disponível'";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    documentos.Add(reader.GetString("nome_doc"));
                }
            }

            return documentos;
        }

        // Buscar uma imagem pelo id_imagem
        public static ImagemRequerimento BuscarImagemPorId(int idImagem)
        {
            string sql = @"
        SELECT motivo_segunda_via, endereco_bo, endereco_comprovante
        FROM t_img_requerimento
        WHERE id_imagem = @id";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idImagem);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ImagemRequerimento
                        {
                            MotivoSegundaVia = reader["motivo_segunda_via"]?.ToString(),
                            EnderecoBO = reader["endereco_bo"]?.ToString(),
                            EnderecoComprovante = reader["endereco_comprovante"]?.ToString()
                        };
                    }
                }
            }

            return null;
        }

        // Buscar todas as imagens/documentos relacionados a um requerimento
        public static List<ImagemRequerimento> BuscarImagensPorRequerimento(int idRequerimento)
        {
            List<ImagemRequerimento> imagens = new List<ImagemRequerimento>();

            string sql = @"
                SELECT id_imagem, motivo_segunda_via, endereco_bo, endereco_comprovante
                FROM t_img_requerimento
                WHERE id_requerimento = @idRequerimento";

            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@idRequerimento", idRequerimento);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        imagens.Add(new ImagemRequerimento
                        {
                            IdImagem = reader.GetInt32("id_imagem"),
                            MotivoSegundaVia = reader["motivo_segunda_via"]?.ToString(),
                            EnderecoBO = reader["endereco_bo"]?.ToString(),
                            EnderecoComprovante = reader["endereco_comprovante"]?.ToString()
                        });
                    }
                }
            }

            return imagens;
        }

        // Verifica se o documento está disponível (exemplo para id_disponibilidade)
        public static bool DocumentoDisponivel(int idDisponibilidade)
        {
            string sql = "SELECT COUNT(*) FROM t_disponibilidade_doc WHERE id_disponibilidade = @id AND status_atual = 'Disponível'";
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idDisponibilidade);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        // Insere imagens enviadas pelo aluno e retorna o id_imagem gerado
        public static int InserirImagensAluno(string motivo, string enderecoBo, string enderecoComprovante)
        {
            string sqlInsert = @"
            INSERT INTO t_img_requerimento (motivo_segunda_via, endereco_bo, endereco_comprovante)
            VALUES (@motivo, @bo, @comprovante);
            SELECT LAST_INSERT_ID();";
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sqlInsert, conn))
            {
                cmd.Parameters.AddWithValue("@motivo", motivo);
                cmd.Parameters.AddWithValue("@bo", (object)enderecoBo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@comprovante", (object)enderecoComprovante ?? DBNull.Value);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Atualiza o campo id_imagem na tabela t_requerimentos
        public static void AtualizarIdImagemRequerimento(int idRequerimento, int idImagem)
        {
            string sql = "UPDATE t_requerimentos SET id_imagem = @idImagem WHERE id_requerimento = @idRequerimento";
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@idImagem", idImagem);
                cmd.Parameters.AddWithValue("@idRequerimento", idRequerimento);
                cmd.ExecuteNonQuery();
            }
        }

        // Atualiza o arquivo enviado pela secretaria (campo blob arquivo_resposta)
        public static void AtualizarArquivoRespostaSecretaria(int idImagem, byte[] arquivoBlob, string nomeArquivo)
        {
            string sql = "UPDATE t_img_requerimento SET arquivo_resposta = @arquivoResposta, nome_arquivo_resposta = @nomeArquivo WHERE id_imagem = @idImagem";
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@arquivoResposta", arquivoBlob);
                cmd.Parameters.AddWithValue("@nomeArquivo", nomeArquivo);
                cmd.Parameters.AddWithValue("@idImagem", idImagem);
                cmd.ExecuteNonQuery();
            }
        }

        // Insere um novo registro na tabela t_img_requerimento com arquivo_resposta (para documentos que não são carteira de identidade)
        public static int InserirImagemRespostaSecretaria(byte[] arquivoBlob, string nomeArquivo)
        {
            string sqlInsert = @"
        INSERT INTO t_img_requerimento (arquivo_resposta, nome_arquivo_resposta)
        VALUES (@arquivoResposta, @nomeArquivo);
        SELECT LAST_INSERT_ID();";
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sqlInsert, conn))
            {
                cmd.Parameters.AddWithValue("@arquivoResposta", arquivoBlob);
                cmd.Parameters.AddWithValue("@nomeArquivo", nomeArquivo);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Busca os arquivos relacionados a um requerimento (via id_imagem), incluindo arquivo_resposta
        public static (string motivo, string enderecoBo, string enderecoComprovante, byte[] arquivoResposta, string nomeArquivoResposta) BuscarArquivosPorRequerimento(int idRequerimento)
        {
            string sql = @"
        SELECT i.motivo_segunda_via, i.endereco_bo, i.endereco_comprovante, i.arquivo_resposta, i.nome_arquivo_resposta
        FROM t_img_requerimento i
        INNER JOIN t_requerimentos r ON r.id_imagem = i.id_imagem
        WHERE r.id_requerimento = @idRequerimento";
            using (var conn = ConexaoBD.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@idRequerimento", idRequerimento);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string motivo = reader["motivo_segunda_via"] as string;
                        string enderecoBo = reader["endereco_bo"] as string;
                        string enderecoComprovante = reader["endereco_comprovante"] as string;
                        byte[] arquivoResposta = reader["arquivo_resposta"] as byte[];
                        string nomeArquivoResposta = reader["nome_arquivo_resposta"] as string;
                        return (motivo, enderecoBo, enderecoComprovante, arquivoResposta, nomeArquivoResposta);
                    }
                    else
                    {
                        return (null, null, null, null, null);
                    }
                }
            }
        }

        // Salva dados atualizados no bd
        public static void AtualizarDadosSolicitante(Requerimento requerimento)
        {
            string query = @"
            UPDATE t_requerimentos SET
                nome = @Nome,
                ra = @RA,
                curso = @Curso,
                cpf = @CPF,
                rg = @RG,
                email = @Email
            WHERE id_requerimento = @Id";

            var parametros = new List<MySqlParameter>
        {
            new MySqlParameter("@Nome", requerimento.Nome),
            new MySqlParameter("@RA", requerimento.RA),
            new MySqlParameter("@Curso", requerimento.Curso),
            new MySqlParameter("@CPF", requerimento.CPF),
            new MySqlParameter("@RG", requerimento.RG),
            new MySqlParameter("@Email", requerimento.Email),
            new MySqlParameter("@Id", requerimento.Id)
        };

            using (var conexao = ConexaoBD.ObterConexao())
            {
                using (var cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddRange(parametros.ToArray());
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}
