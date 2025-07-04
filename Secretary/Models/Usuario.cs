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
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public string TipoPerfil { get; set; }
        public DateTime CriadoEm { get; set; }
        public string Senha { get; set; }
    }
}
