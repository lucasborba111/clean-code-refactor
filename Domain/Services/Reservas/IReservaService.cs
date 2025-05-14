using clean_code_refactor.Domain.Models;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Services.Reservas
{
    public interface IReservaService
    {
        Task<Reserva> Inserir(CriarReservaViewModel dto);
        Task<IList<Reserva>> Recuperar();
        Task<Reserva> Recuperar(int id);
    }
}
