using AutoMapper;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Models.Reservas
{
    public class ReservaProfile : Profile
    {
        public ReservaProfile()
        {
            CreateMap<CriarReservaViewModel, Reserva>();
            CreateMap<Reserva, CriarReservaViewModel>();
        }
    }
}
