using clean_code_refactor.Domain.Bases;
using clean_code_refactor.Domain.Models;

namespace clean_code_refactor.Dal.Repositories.Clientes
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        Task<bool> ExisteCpfAsync(string cpf);
    }
}