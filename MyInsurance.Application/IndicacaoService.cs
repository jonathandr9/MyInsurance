using MyInsurance.Domain.Adapters;
using MyInsurance.Domain.Models;
using MyInsurance.Domain.Services;
using System;
using System.Threading.Tasks;

namespace MyInsurance.Application
{
    public class IndicacaoService : IIndicacaoService
    {

        private readonly IHinovaAdapter _hinovaAdapter;
        public IndicacaoService(IHinovaAdapter hinovaAdapter)
        {
            _hinovaAdapter = hinovaAdapter;
        }
        public async Task<RetornoIndicacao> IncluirIndicacao(EntradaIndicacao entradaIndicacao)
        {
            var retorno = await _hinovaAdapter.IncluirIndicacao(entradaIndicacao);            

            return retorno;
        }
    }
}
