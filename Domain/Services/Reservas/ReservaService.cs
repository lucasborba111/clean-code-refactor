using clean_code_refactor.Dal.Repositories.Reservas;
using clean_code_refactor.Domain.Models;
using clean_code_refactor.Domain.Services.Base;
using clean_code_refactor.Domain.Services.Clientes;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Services.Reservas
{
    public class ReservaService : BaseService<Reserva>, IReservaService
    {
        private readonly IClienteService _clienteServ;
        public ReservaService(IReservaRepository reservaRepository, IClienteService clienteService) 
            : base(reservaRepository)
        {
            _clienteServ = clienteService;
        }
        public async Task<Reserva> Inserir(CriarReservaViewModel dto)
        {
            _ = await _clienteServ.Recuperar(dto.ClienteId) 
                ?? throw new Exception($"Não foi possível inserir reserva, cliente de código {dto.ClienteId} não encontrado!");

            var reserva = new Reserva(dto.QuantidadePessoas, dto.TipoQuarto, dto.Diarias, dto.ClienteId);

            return await Rep.AdicionarAsync(reserva);
        }
    }
}
