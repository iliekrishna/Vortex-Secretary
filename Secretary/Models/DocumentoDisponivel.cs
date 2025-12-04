using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Resources.ResXFileRef;

namespace Secretary.Models
{
    public class DocumentoDisponivel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string StatusAtual { get; set; }
        public bool NecessitaImagem { get; set; }
        public string NomeCampoImagem { get; set; }
        public bool ObrigatorioSegVia { get; set; }
    }

}
