using System;

namespace Secretary.Models
{
    public class Requerimento
    {
        public int Id { get; set; }
        public int? IdUsuario { get; set; }
        public string RA { get; set; }
        public string Telefone { get; set; }
        public string Curso { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string NomeDocumento { get; set; }
        public string StatusDocumento { get; set; }
        public DateTime? DataPedido { get; set; }
        public DateTime? DataResposta { get; set; }
        public string Resposta { get; set; }
        public int? IdImagem { get; set; }
        public string TipoDocumento { get; set; }
        // Propriedade adicionada para o nome do usuário que respondeu
        public string NomeUsuarioResposta { get; set; }
    }
}