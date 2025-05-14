using clean_code_refactor.Dal.Repositories.Reservas;
using clean_code_refactor.Domain.Models;
using clean_code_refactor.Domain.Services.Clientes;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Services.Reservas
{
    public class ReservaService(IReservaRepository reservaRepository, IClienteService clienteServ) : IReservaService
    {
        private readonly IReservaRepository _reservaRepository = reservaRepository;
        private readonly IClienteService _clienteServ = clienteServ;
        public async Task<IList<Reserva>> Recuperar() => await _reservaRepository.ObterTodosAsync();
        public async Task<Reserva> Recuperar(int id) => await _reservaRepository.ObterPorIdAsync(id);

        public async Task<Reserva> Inserir(CriarReservaViewModel dto)
        {
            _ = await _clienteServ.Recuperar(dto.ClienteId) 
                ?? throw new Exception($"Não foi possível inserir reserva, cliente de código {dto.ClienteId} não encontrado!");

            var reserva = new Reserva(dto.QuantidadePessoas, dto.TipoQuarto, dto.Diarias, dto.ClienteId);

            return await _reservaRepository.AdicionarAsync(reserva);
        }
    }
}
