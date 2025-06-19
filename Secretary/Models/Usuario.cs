using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secretary.Models;

namespace Secretary.Models
{
    public class Usuario
    {
        public int Id { get; set; }              // id_usuario
        public string Nome { get; set; }         // nome_usuario
        public string Email { get; set; }        // email_usuario
        public string SenhaHash { get; set; }    // senha (já vem criptografada)
        public string Tipo { get; set; }         // tipo_perfil (ex: ADM, USER)
        public DateTime CriadoEm { get; set; }   // criado_em (data de cadastro)
        public string Senha { get; set; }        // A senha bruta (usada apenas antes de salvar)
        public string TipoPerfil { get; set; }
    }
}
