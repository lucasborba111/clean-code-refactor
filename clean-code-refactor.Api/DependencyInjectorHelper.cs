using clean_code_refactor.Controllers;
using clean_code_refactor.Dal;
using clean_code_refactor.Dal.Repositories.Base;
using clean_code_refactor.Domain.Services.Clientes;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace clean_code_refactor
{
    public static class DependencyInjectorHelper
    {
        public static void AddInfraSql(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>
                (options => options.UseSqlite(configuration.GetConnectionString("SqliteConnectionString")));

            services.ScanDependencyInjection(
                typeof(ClienteService).Assembly,
                typeof(BaseRepository<>).Assembly,
                typeof(ClienteController).Assembly
            );
        }
    }
}
