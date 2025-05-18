using AutoMapper;
using clean_code_refactor.Dal.Repositories.Reservas;
using clean_code_refactor.Domain.Bases;
using clean_code_refactor.Domain.Models.Reservas;
using clean_code_refactor.Domain.Services.Base;
using clean_code_refactor.Domain.Services.Reservas.Validations;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Services.Reservas
{
    public class ReservaService : BaseService<Reserva, CriarReservaViewModel, ReservaValidation>, IReservaService
    {
        public ReservaService(
            IReservaRepository reservaRep, 
            IMapper mapper, 
            IValidation<CriarReservaViewModel> validation) : base(reservaRep, mapper, validation) {}
    }
}
