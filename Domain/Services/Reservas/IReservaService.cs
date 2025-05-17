using clean_code_refactor.Domain.Models;
using clean_code_refactor.Domain.Services.Base;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Services.Reservas
{
    public interface IReservaService : IBaseService<Reserva, CriarReservaViewModel>
    {
    }
}
