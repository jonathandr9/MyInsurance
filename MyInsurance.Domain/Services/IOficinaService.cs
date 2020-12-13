using MyInsurance.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyInsurance.Domain.Services
{
    public interface IOficinaService
    {
        Task<IEnumerable<Oficina>> ConsultarOficinas(int codigoAssociacao, string cpfAssociado); 
    }
}
