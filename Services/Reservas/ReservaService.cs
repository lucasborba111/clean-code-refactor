using clean_code_refactor.Repositories.Reservas;

namespace clean_code_refactor.Services.Reservas
{
    public class ReservaService(IReservaRepository reservaRepository) : IReservaService
    {
        private readonly IReservaRepository _reservaRepository = reservaRepository;
    }
}
