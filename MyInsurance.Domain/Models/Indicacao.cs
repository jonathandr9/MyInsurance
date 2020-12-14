using System;

namespace MyInsurance.Domain.Models
{
    public class Indicacao
    {
        public int CodigoAssociacao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public string CpfAssociado { get; set; }
        public string EmailAssociado { get; set; }
        public string NomeAssociado { get; set; }
        public string TelefoneAssociado { get; set; }
        public string PlacaVeiculoAssociado { get; set; }
        public string NomeAmigo { get; set; }
        public string TelefoneAmigo { get; set; }
        public string EmailAmigo { get; set; }
        public string Observacao { get; set; }
    }
}
