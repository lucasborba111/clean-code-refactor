using clean_code_refactor.Domain.Bases;
using clean_code_refactor.Domain.Models;
using clean_code_refactor.Domain.Services.Base;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Services.Clientes
{
    public interface IClienteService : IBaseService<Cliente>
    {
        Task<Cliente> Inserir(CriarClienteViewModel cliente);
    }
}
