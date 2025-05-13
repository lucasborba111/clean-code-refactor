using clean_code_refactor.Models;

namespace clean_code_refactor.Repositories.Clientes
{
    public interface IClienteRepository
    {
        Task<Cliente> AdicionarAsync(Cliente cliente);
        Task AtualizarAsync(Cliente cliente);
        Task<bool> ExisteCpfAsync(string cpf);
        Task<Cliente> ObterPorCpfAsync(string cpf);
        Task<Cliente> ObterPorIdAsync(int id);
        Task<IList<Cliente>> ObterTodosAsync();
        Task RemoverAsync(Cliente cliente);
    }
}