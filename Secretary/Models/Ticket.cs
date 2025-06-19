using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretary.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string NomeAluno { get; set; }
        public string CPF { get; set; }
        public string TipoVinculo { get; set; }
        public string RA { get; set; }
        public string Email { get; set; }
        public string Curso { get; set; }
        public string Categoria { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataPedido { get; set; }
        public string Resposta { get; set; }
        public string Status { get; set; }
        public DateTime? DataResposta { get; set; }
        public int? IdUsuario { get; set; }
    }
}
