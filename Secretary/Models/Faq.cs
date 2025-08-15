using System;

namespace Secretary.Models
{
    public class Faq
    {
        public int Id { get; set; }
        public string Pergunta { get; set; }
        public string Resposta { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int CriadoPor { get; set; }
        public int? AtualizadoPor { get; set; }
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
    }
}