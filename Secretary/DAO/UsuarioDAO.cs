using System;
using Secretary.Models;
using MySql.Data.MySqlClient;

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
                            Tipo = reader.GetString("tipo_perfil")
                        };
                    }
                }
            }

            return null;
        }
    }
}
