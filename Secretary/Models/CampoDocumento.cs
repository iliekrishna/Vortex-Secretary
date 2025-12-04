using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretary.Models
{
    public class CampoDocumento
    {
        public int IdCampo { get; set; }
        public int IdDocumento { get; set; }
        public string NomeCampo { get; set; }
        public string TipoCampo { get; set; }  // exemplo: 'img'
        public bool Obrigatorio { get; set; }
    }
}
