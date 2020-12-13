using MyInsurance.Domain.Models;
using System.Collections.Generic;

namespace MyInsurance.Domain.Adapters
{
    public interface IHinovaAdapter
    {
        IEnumerable<Oficina> ConsultarOficinas(int codigoAssociacao, string cpfAssociado);
    }
}
