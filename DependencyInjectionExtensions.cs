using System.Reflection;

namespace clean_code_refactor
{
    public static class DependencyInjectionExtensions
    {
        public static void ScanDependencyInjection(this IServiceCollection services, Assembly assembly, string classEndsWith)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => x.GetInterfaces().Any(i => i.Name.EndsWith(classEndsWith)));

            foreach (var type in types)
            {
                var interfaces = type.GetInterfaces();
                foreach (var inter in interfaces)
                    services.AddScoped(inter, type);
            }
        }
    }
}
