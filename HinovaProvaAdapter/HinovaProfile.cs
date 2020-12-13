using AutoMapper;
using HinovaProvaAdapter.Clients;
using MyInsurance.Domain.Models;

namespace HinovaProvaAdapter
{
    public class HinovaProfile : Profile
    {
        public HinovaProfile()
        {
            CreateMap<ListaOficina, Oficina>();
        }
    }
}
