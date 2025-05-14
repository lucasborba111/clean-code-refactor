using clean_code_refactor.Dal.Repositories.Reservas;
using clean_code_refactor.Domain.Models;

namespace clean_code_refactor.Domain.Services.Reservas
{
    public class ReservaService(IReservaRepository reservaRepository) : IReservaService
    {
        private readonly IReservaRepository _reservaRepository = reservaRepository;

        public async Task<IList<Reserva>> Recuperar() => await _reservaRepository.ObterTodosAsync();
        public async Task<Reserva> Recuperar(int id) => await _reservaRepository.ObterPorIdAsync(id);
    }
}
