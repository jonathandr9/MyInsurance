using MyInsurance.Domain.Models;
using System.Threading.Tasks;

namespace MyInsurance.Domain.Services
{
    public interface IIndicacaoService
    {
        Task<RetornoIndicacao> IncluirIndicacao(EntradaIndicacao entradaIndicacao);
    }
}
