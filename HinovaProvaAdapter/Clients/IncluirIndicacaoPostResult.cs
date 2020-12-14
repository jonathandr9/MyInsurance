namespace HinovaProvaAdapter.Clients
{
    public class IncluirIndicacaoPostResult
    {
        public RetornoErroIndicacaoDto RetornoErro { get; set; }
        public string Sucesso { get; set; }
    } 
    public class RetornoErroIndicacaoDto
    {
        public object retornoErro { get; set; }
    }


}
