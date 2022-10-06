using Microsoft.EntityFrameworkCore;
using SuperHerois.Models;
using SuperHerois.Models.Repository;

namespace SuperHerois.Configurations;

public static class ServiceConfiguration
{
    public static IServiceCollection ConfigurarBancoDeDados(this IServiceCollection service, IConfiguration config)
    {
        service.AddDbContext<MariaDbContext>(options =>
            options.UseMySQL(config.GetConnectionString("DefaultConnection")));

        return service;
    }

    public static IServiceCollection ConfigurarRepositorios(this IServiceCollection service)
    {
        service.AddSingleton<IHeroiRepository, HeroiRepository>();
        return service;
    }
}