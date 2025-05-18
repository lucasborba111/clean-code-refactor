using clean_code_refactor.Domain.Models.Reservas;
using clean_code_refactor.Domain.Services.Base;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Services.Reservas
{
    public interface IReservaService : IBaseService<Reserva, ReservaViewModel>
    {
        void Cancelar(int id);
        void RealizarCheckIn(int id);
        void RealizarCheckOut(int id);
    }
}
