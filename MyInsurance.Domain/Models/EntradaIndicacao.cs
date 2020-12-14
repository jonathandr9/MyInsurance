namespace MyInsurance.Domain.Models
{
    public class EntradaIndicacao
    {
        public Indicacao Indicacao { get; set; }
        public string Remetente { get; set; }
        public string[] Copias { get; set; }
    }
}
