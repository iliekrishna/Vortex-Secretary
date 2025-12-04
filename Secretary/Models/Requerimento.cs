using System;

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
    public string TipoVia { get; set; }
    public int? IdDisponibilidade { get; set; }
    public string NomeUsuarioResposta { get; set; }
    public string TipoVinculo { get; set; }
}