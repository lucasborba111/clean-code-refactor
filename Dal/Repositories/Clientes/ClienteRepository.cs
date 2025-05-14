using clean_code_refactor.Dal.Repositories.Base;
using clean_code_refactor.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace clean_code_refactor.Dal.Repositories.Clientes
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(AppDbContext context) : base(context) {}

        public async Task<bool> ExisteCpfAsync(string cpf) => await DbSet.AnyAsync(c => c.Cpf == cpf);
    }
}
