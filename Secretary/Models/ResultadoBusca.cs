using System;

namespace Secretary.Models
{
    public class ResultadoBusca
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public DateTime? Data { get; set; }
        public string Detalhes { get; set; }
    }
}
