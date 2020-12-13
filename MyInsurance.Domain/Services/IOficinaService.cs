using MyInsurance.Domain.Models;
using System.Collections.Generic;

namespace MyInsurance.Domain.Services
{
    public interface IOficinaService
    {
        IEnumerable<Oficina> ConsultarOficinas(int codigoAssociacao, string cpfAssociado); 
    }
}
