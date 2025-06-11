// Importa o pacote para conectar no MySQL
using MySql.Data.MySqlClient;

namespace Secretary
{
    // DAO = Data Access Object (Objeto de Acesso a Dados)
    // Essa classe é responsável por buscar os dados dos usuários no banco
    public class UsuarioDAO
    {
        // Conexão com o banco de dados (ajuste com seu usuário e senha se necessário)
        private string connStr = "server=localhost;user=root;database=secretary;password=;";

        // Método que busca um usuário no banco de dados, usando o e-mail como filtro
        public Usuario BuscarPorEmail(string email)
        {
            // Cria uma conexão com o banco de dados usando a string acima
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open(); // Abre a conexão com o banco

                // Prepara o comando SQL para buscar o usuário pelo e-mail
                string sql = "SELECT id, nome, email, senha, tipo, criado_em FROM usuarios WHERE email = @Email";

                MySqlCommand cmd = new MySqlCommand(sql, conn); // Cria o comando
                cmd.Parameters.AddWithValue("@Email", email);  // Substitui @Email pelo valor passado

                // Executa o comando e guarda o resultado
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // Se encontrou um usuário com esse e-mail
                    if (reader.Read())
                    {
                        // Cria e retorna um objeto Usuario preenchido com os dados do banco
                        return new Usuario
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Email = reader.GetString("email"),
                            SenhaHash = reader.GetString("senha"),
                            Tipo = reader.GetString("tipo"),
                            //CriadoEm = reader.GetDateTime("criado_em")
                        };
                    }
                }
            }

            // Se não encontrou nenhum usuário, retorna null
            return null;
        }
    }
}
