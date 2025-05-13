using clean_code_refactor.Data;
using clean_code_refactor.Models;
using Microsoft.EntityFrameworkCore;

namespace clean_code_refactor.Repositories.Clientes
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Cliente>> ObterTodosAsync()
        {
            return await _context.Clientes
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Cliente> ObterPorIdAsync(int id)
        {
            return await _context.Clientes
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Cliente> ObterPorCpfAsync(string cpf)
        {
            return await _context.Clientes
                .FirstOrDefaultAsync(c => c.Cpf == cpf);
        }

        public async Task<Cliente> AdicionarAsync(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();

            return cliente;
        }

        public async Task AtualizarAsync(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task RemoverAsync(Cliente cliente)
        {
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExisteCpfAsync(string cpf)
        {
            return await _context.Clientes.AnyAsync(c => c.Cpf == cpf);
        }
    }

}
