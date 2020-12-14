using MyInsurance.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyInsurance.Domain.Adapters
{
    public interface IHinovaAdapter
    {
        Task<IEnumerable<Oficina>> ConsultarOficinas(int codigoAssociacao, string cpfAssociado);

        Task<RetornoIndicacao> IncluirIndicacao(EntradaIndicacao entradaIndicacao);
    }
}
