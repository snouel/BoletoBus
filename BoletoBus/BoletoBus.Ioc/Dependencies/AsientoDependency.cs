using BoletoBus.Domain.Interfaces;
using BoletoBus.Infraestructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BoletoBus.Ioc.Dependencies
{
    public static class AsientoDependency {
        public static void AddAsientoDependency(this IServiceCollection services)
        {
            services.AddScoped<IAsientoRepository, AsientoRepository>();

            }
    }
}
