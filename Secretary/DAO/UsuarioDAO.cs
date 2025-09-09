using System;
using MySql.Data.MySqlClient;
using Secretary.Models;

namespace Secretary.DAO
{
    public class UsuarioDAO
    {
        public Usuario BuscarPorEmail(string email, MySqlConnection conn)
        {
            string sql = @"SELECT id_usuario, nome_usuario, email_usuario, senha, tipo_perfil, criado_em
                   FROM t_usuarios 
                   WHERE email_usuario = @Email 
                   LIMIT 1;";

            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var usuario = new Usuario
                        {
                            Id = reader.GetInt32("id_usuario"),
                            Nome = reader.GetString("nome_usuario"),
                            Email = reader.GetString("email_usuario"),
                            SenhaHash = reader.GetString("senha"),
                            TipoPerfil = reader.GetString("tipo_perfil")
                        };

                        int ordCriado = reader.GetOrdinal("criado_em");
                        if (!reader.IsDBNull(ordCriado))
                            usuario.CriadoEm = reader.GetDateTime(ordCriado);

                        return usuario;
                    }
                }
            }
            return null;
        }

        public bool EmailExiste(string email)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                // Verifica se existe usuário com o e-mail, ativo ou desativado
                string sql = "SELECT COUNT(*) FROM t_usuarios WHERE email_usuario = @Email;";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool CadastrarUsuario(Usuario usuario)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                // Verifica se o e-mail já existe (ativo ou desativado)
                string sqlVerifica = "SELECT COUNT(*) FROM t_usuarios WHERE email_usuario = @Email;";
                using (var cmdVerifica = new MySqlCommand(sqlVerifica, conn))
                {
                    cmdVerifica.Parameters.AddWithValue("@Email", usuario.Email);
                    int count = Convert.ToInt32(cmdVerifica.ExecuteScalar());
                    if (count > 0)
                    {
                        // E-mail já existe, não cadastra
                        return false;
                    }
                }

                // Se não existe, cadastra normalmente
                string sql = @"INSERT INTO t_usuarios 
            (nome_usuario, email_usuario, senha, tipo_perfil, criado_em, ativo) 
            VALUES (@Nome, @Email, @Senha, @TipoPerfil, NOW(), 1);";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@Senha", BCrypt.Net.BCrypt.HashPassword(usuario.Senha));
                    cmd.Parameters.AddWithValue("@TipoPerfil", usuario.TipoPerfil);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        public Usuario Autenticar(string email, string senha)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string sql = "SELECT id_usuario, nome_usuario, email_usuario, senha, tipo_perfil FROM t_usuarios WHERE email_usuario = @Email LIMIT 1;";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hash = reader.GetString("senha");
                            if (BCrypt.Net.BCrypt.Verify(senha, hash))
                            {
                                return new Usuario
                                {
                                    Id = reader.GetInt32("id_usuario"),
                                    Nome = reader.GetString("nome_usuario"),
                                    Email = reader.GetString("email_usuario"),
                                    SenhaHash = hash,
                                    TipoPerfil = reader.GetString("tipo_perfil")
                                };
                            }
                        }
                    }
                }
            }
            return null;
        }

        public int BuscarIdPorEmail(string email)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string sql = "SELECT id_usuario FROM t_usuarios WHERE email_usuario = @Email LIMIT 1;";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        return Convert.ToInt32(result);
                    else
                        throw new Exception("Usuário não encontrado.");
                }
            }
        }
        public void SalvarCodigoRedefinicao(string email, string codigo)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                // Busca ID do usuário
                int idUsuario = -1;
                string buscarIdSql = "SELECT id_usuario FROM t_usuarios WHERE email_usuario = @Email LIMIT 1";

                using (MySqlCommand buscarCmd = new MySqlCommand(buscarIdSql, conn))
                {
                    buscarCmd.Parameters.AddWithValue("@Email", email);
                    var result = buscarCmd.ExecuteScalar();

                    if (result != null)
                    {
                        idUsuario = Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Usuário não encontrado.");
                    }
                }

                // Insere código com expiração
                string inserirSql = @"INSERT INTO t_recuperacao_senha (id_usuario, codigo, expira_em, usado, criado_em) 
                                      VALUES (@IdUsuario, @Codigo, @ExpiraEm, 0, NOW());";

                using (MySqlCommand cmd = new MySqlCommand(inserirSql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@ExpiraEm", DateTime.Now.AddMinutes(10));
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool DesativarUsuario(int idUsuario)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string sql = "UPDATE t_usuarios SET ativo = 0 WHERE id_usuario = @IdUsuario;";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        // Verifica se o e-mail existe e está desativado
        public bool EmailExisteDesativado(string email)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string sql = "SELECT COUNT(*) FROM t_usuarios WHERE email_usuario = @Email AND ativo = 0;";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // Método para reativar usuário pelo e-mail
        public bool ReativarUsuarioPorEmail(string email)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string sql = "UPDATE t_usuarios SET ativo = 1 WHERE email_usuario = @Email;";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool ReativarUsuarioPorId(int idUsuario)
        {
            using (var conexao = ConexaoBD.ObterConexao())
            {
                if (conexao.State != System.Data.ConnectionState.Open)
                    conexao.Open();

                string sql = "UPDATE t_usuarios SET ativo = 1 WHERE id_usuario = @id";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}