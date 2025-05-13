using clean_code_refactor.Models;
using clean_code_refactor.ViewModels;

namespace clean_code_refactor.Services.Clientes
{
    public interface IClienteService
    {
        Task<Cliente> Inserir(CriarClienteViewModel cliente);
        Task<Cliente> Recuperar(int id);
        Task<IList<Cliente>> Recuperar();
    }
}
