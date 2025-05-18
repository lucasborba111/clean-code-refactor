

namespace clean_code_refactor.Domain.Bases
{
    public interface IBaseRepository<T> where T : Identificador
    {
        Task<T> AdicionarAsync(T Reserva);
        Task AtualizarAsync(T Reserva);
        T? ObterPorId(int id);
        Task<T?> ObterPorIdAsync(int id);
        Task<IList<T>> ObterTodosAsync();
        Task RemoverAsync(T Reserva);
    }
}
