using AutoMapper;
using clean_code_refactor.Dal.Repositories.Reservas;
using clean_code_refactor.Domain.Bases;
using clean_code_refactor.Domain.Models.Reservas;
using clean_code_refactor.Domain.Services.Base;
using clean_code_refactor.Domain.Services.Reservas.Validations;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Services.Reservas
{
    public class ReservaService : BaseService<Reserva, ReservaViewModel, ReservaValidation>, IReservaService
    {
        public ReservaService(IReservaRepository reservaRep, IMapper mapper, IValidation<ReservaViewModel> validation) 
            : base(reservaRep, mapper, validation) {}

        public async void RealizarCheckIn(int id)
        {
            var result = await Recuperar(id);

            result.Value.RealizarCheckIn();

            await Rep.AtualizarAsync(result.Value);
        }

        public async void RealizarCheckOut(int id)
        {
            var result = await Recuperar(id);

            result.Value.RealizarCheckOut();

            await Rep.AtualizarAsync(result.Value);
        }

        public async void Cancelar(int id)
        {
            var result = await Recuperar(id);

            result.Value.RealizarCheckOut();

            await Rep.AtualizarAsync(result.Value);
        }
    }
}
