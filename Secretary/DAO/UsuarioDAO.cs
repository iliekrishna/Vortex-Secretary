using System;
using MySql.Data.MySqlClient;
using Secretary.Models;

namespace Secretary.DAO
{
    public class UsuarioDAO
    {
        public Usuario BuscarPorEmail(string email, MySqlConnection conn)
        {
            string sql = "SELECT id_usuario, nome_usuario, email_usuario, senha, tipo_perfil FROM t_usuarios WHERE email_usuario = @Email LIMIT 1;";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            Id = reader.GetInt32("id_usuario"),
                            Nome = reader.GetString("nome_usuario"),
                            Email = reader.GetString("email_usuario"),
                            SenhaHash = reader.GetString("senha"),
                            TipoPerfil = reader.GetString("tipo_perfil")
                        };
                    }
                }
            }

            return null;
        }

        public bool EmailExiste(string email)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
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
                string sql = @"INSERT INTO t_usuarios 
                    (nome_usuario, email_usuario, senha, tipo_perfil, criado_em) 
                    VALUES (@Nome, @Email, @Senha, @TipoPerfil, NOW());";

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
    }
}
