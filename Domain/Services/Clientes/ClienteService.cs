using clean_code_refactor.Dal.Repositories.Clientes;
using clean_code_refactor.Domain.Models;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Services.Clientes
{
    public class ClienteService(IClienteRepository clienteRep) : IClienteService
    {
        private readonly IClienteRepository _clienteRep = clienteRep;

        public async Task<IList<Cliente>> Recuperar() => await _clienteRep.ObterTodosAsync();

        public async Task<Cliente> Recuperar(int id) => await _clienteRep.ObterPorIdAsync(id);

        public async Task<Cliente> Inserir(CriarClienteViewModel clienteViewModel)
        {
            Cliente cliente = new()
            {
                Cpf = clienteViewModel.Cpf,
                Nome = clienteViewModel.Nome
            };
            //validação ->
            return await _clienteRep.AdicionarAsync(cliente);
        }
    }
}
