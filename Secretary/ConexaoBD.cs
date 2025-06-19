using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Secretary
{
    public class ConexaoBD
    {
        private static string servidor = "162.241.40.214";
        private static string porta = "3306";
        private static string usuario = "miltonb_userVortex";
        private static string senha = "gWLQqb~dRO0M";
        private static string bancoDados = "miltonb_fatec_solicitacoes";

        private static string connectionString = $"server={servidor};port={porta};user={usuario};password={senha};database={bancoDados};";

        public static MySqlConnection ObterConexao()
        {
            var conexao = new MySqlConnection(connectionString);
            conexao.Open(); // Abre a conexão aqui
            return conexao;
        }

        public static DataTable ExecutarConsulta(string query)
        {
            using (MySqlConnection conexao = ObterConexao()) // já está aberta
            {
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
        }
    }
}
