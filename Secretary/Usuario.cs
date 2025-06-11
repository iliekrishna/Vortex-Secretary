//// Essa classe representa um usuário do sistema (pode ser admin ou usuário comum) 
//Para organizar os dados de um usuário em um único lugar.

//Facilita quando queremos guardar, ler ou transferir informações sobre usuários entre as telas do sistema e o banco de dados.
//using System;

namespace Secretary
{
    public class Usuario
    {
        // ID único do usuário no banco de dados
        public int Id { get; set; }

        // Nome completo do usuário
        public string Nome { get; set; }

        // E-mail usado para login
        public string Email { get; set; }

        // Senha do usuário (armazenada em forma de "hash" por segurança)
        public string SenhaHash { get; set; }

        // Tipo do usuário: pode ser "admin" (administrador) ou "user" (usuário comum)
        public string Tipo { get; set; }

        // Data e hora em que a conta foi criada
        //public DateTime CriadoEm { get; set; }
    }
}
