using AutoMapper;
using HinovaProvaAdapter.Clients;
using MyInsurance.Domain.Adapters;
using MyInsurance.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HinovaProvaAdapter
{
    public class HinovaAdapter : IHinovaAdapter
    {
        private readonly IHinovaWebApi _hinovaApi;
        private readonly IMapper _mapper;
        private readonly HinovaAdapterConfiguration _hinovaConfiguration;

        public HinovaAdapter(IHinovaWebApi hinovaApi,
            IMapper mapper,
            HinovaAdapterConfiguration hinovaConfiguration)
        {
            _hinovaApi = hinovaApi;
            _mapper = mapper;
            _hinovaConfiguration = hinovaConfiguration;
        }
        public async Task<IEnumerable<Oficina>> ConsultarOficinas(
            int codigoAssociacao,
            string cpfAssociado)
        {
            var resposta = await _hinovaApi
                .ConsultarOficinasAsync(codigoAssociacao, cpfAssociado);

            return _mapper.Map<IEnumerable<Oficina>>(resposta.ListaOficinas);
        }

        public Task<RetornoIndicacao> IncluirIndicacao(EntradaIndicacao entradaIndicacao)
        {
            throw new System.NotImplementedException();
        }
    }
}
