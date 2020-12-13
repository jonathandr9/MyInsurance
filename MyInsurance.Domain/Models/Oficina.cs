namespace MyInsurance.Domain.Models
{
    public class Oficina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DescricaoCurta { get; set; }
        public string Endereco { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Foto { get; set; }
        public int AvaliacaoUsuario { get; set; }
        public int CodigoAssociacao { get; set; }
        public string Email { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public bool Ativo { get; set; }
    }
}
