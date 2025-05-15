using clean_code_refactor.Dal.Repositories.Clientes;
using clean_code_refactor.Domain.Models;
using clean_code_refactor.Domain.Services.Base;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Services.Clientes
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        public ClienteService(IClienteRepository clienteRep) : base(clienteRep) {}

        public async Task<Cliente> Inserir(CriarClienteViewModel clienteViewModel)
        {
            Cliente cliente = new()
            {
                Cpf = clienteViewModel.Cpf,
                Nome = clienteViewModel.Nome
            };
            //validação ->
            return await Rep.AdicionarAsync(cliente);
        }
    }
}
