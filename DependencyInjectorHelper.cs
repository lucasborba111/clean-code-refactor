using clean_code_refactor.Data;
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

            services.ScanDependencyInjection(Assembly.GetExecutingAssembly(), "Repository");
        }
    }
}
