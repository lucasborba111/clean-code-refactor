using clean_code_refactor.Dal.Repositories.Base;
using clean_code_refactor.Domain.Models.Reservas;

namespace clean_code_refactor.Dal.Repositories.Reservas
{
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        public ReservaRepository(AppDbContext context) : base(context) {}
    }
}
