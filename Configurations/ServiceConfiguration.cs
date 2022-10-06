using Microsoft.EntityFrameworkCore;
using SuperHerois.Models;
using SuperHerois.Models.Repository;

namespace SuperHerois.Configurations;

public static class ServiceConfiguration
{
    public static IServiceCollection ConfigurarBancoDeDados(this IServiceCollection service)
    {
        service.AddSingleton<IMariaDbContext, MariaDbContext>();
        return service;
    }

    public static IServiceCollection ConfigurarRepositorios(this IServiceCollection service)
    {
        service.AddSingleton<IHeroiRepository, HeroiRepository>();
        return service;
    }
}