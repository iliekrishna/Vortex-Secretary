using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secretary.Models;

namespace Secretary.Models
{
    public class Requerimento
    {
        public int Id { get; set; } // id_requerimento
        public int? IdUsuario { get; set; } // id_usuario (pode ser null)
        public string RA { get; set; }
        public string Telefone { get; set; }
        public string Curso { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string NomeDocumento { get; set; } // nome_doc
        public string TipoDocumento { get; set; } // tipo_doc
        public string StatusDocumento { get; set; } // status_doc
        public DateTime? DataPedido { get; set; } // data_pedido
        public DateTime? DataResposta { get; set; } // data_resposta
        public string Resposta { get; set; } // resposta
    }
}
