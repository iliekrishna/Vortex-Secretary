using System;

namespace Secretary.Models
{
    /// <summary>
    /// Representa um resultado de busca global no sistema
    /// </summary>
    public class ResultadoBusca
    {
        /// <summary>
        /// ID do registro encontrado
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tipo do resultado: "Requerimento", "Ticket" ou "Usuário"
        /// </summary>
        public string Tipo { get; set; }

        /// <summary>
        /// Título ou nome principal do resultado
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Descrição ou detalhes adicionais
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Status do item (se aplicável)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Data relacionada ao item
        /// </summary>
        public DateTime? Data { get; set; }

        /// <summary>
        /// Campo adicional para informações extras (ex: RA, CPF, Curso)
        /// </summary>
        public string InfoAdicional { get; set; }
    }
}
