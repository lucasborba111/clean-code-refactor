using AutoMapper;
using clean_code_refactor.Dal.Repositories.Clientes;
using clean_code_refactor.Domain.Models;
using clean_code_refactor.Domain.Services.Base;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Services.Clientes
{
    public class ClienteService : BaseService<Cliente, CriarClienteViewModel>, IClienteService
    {
        public ClienteService(IClienteRepository clienteRep, IMapper mapper) : base(clienteRep, mapper) {}
    }
}
