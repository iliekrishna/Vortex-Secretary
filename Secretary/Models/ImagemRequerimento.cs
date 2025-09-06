using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretary.Models
{
    public class ImagemRequerimento
    {
        public int IdImagem { get; set; }
        public string MotivoSegundaVia { get; set; }
        public string EnderecoBO { get; set; }
        public string EnderecoComprovante { get; set; }
        public string CaminhoArquivoResposta { get; set; }
    }
}
