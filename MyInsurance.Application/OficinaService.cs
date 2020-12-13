using MyInsurance.Domain.Adapters;
using MyInsurance.Domain.Models;
using MyInsurance.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyInsurance.Application
{
    public class OficinaService : IOficinaService
    {
        private readonly IHinovaAdapter _hinovaAdapter;
        public OficinaService(IHinovaAdapter hinovaAdapter)
        {
            _hinovaAdapter = hinovaAdapter;
        }


        public async Task<IEnumerable<Oficina>> ConsultarOficinas(int codigoAssociacao, string cpfAssociado)
        {
            return await _hinovaAdapter.ConsultarOficinas(codigoAssociacao, cpfAssociado);
        }
    }
}
