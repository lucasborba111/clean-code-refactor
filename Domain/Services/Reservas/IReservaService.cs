using clean_code_refactor.Domain.Models;

namespace clean_code_refactor.Domain.Services.Reservas
{
    public interface IReservaService
    {
        Task<IList<Reserva>> Recuperar();
        Task<Reserva> Recuperar(int id);
    }
}
