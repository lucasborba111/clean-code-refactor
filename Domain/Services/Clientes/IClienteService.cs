using clean_code_refactor.Domain.Models;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Services.Clientes
{
    public interface IClienteService
    {
        Task<Cliente> Inserir(CriarClienteViewModel cliente);
        Task<Cliente> Recuperar(int id);
        Task<IList<Cliente>> Recuperar();
    }
}
