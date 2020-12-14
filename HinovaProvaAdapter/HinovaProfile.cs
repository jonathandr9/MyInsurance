using AutoMapper;
using HinovaProvaAdapter.Clients;
using MyInsurance.Domain.Models;

namespace HinovaProvaAdapter
{
    public class HinovaProfile : Profile
    {
        public HinovaProfile()
        {
            CreateMap<ListaOficinaDto, Oficina>();
            CreateMap<IncluirIndicacaoPostResult, RetornoIndicacao>();
            CreateMap<RetornoErroIndicacaoDto, RetornoErro>();
            CreateMap<RetornoErroOficinaDto, RetornoErro>();
        }
    }
}
