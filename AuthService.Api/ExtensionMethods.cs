using AuthService.Application.Services;
using AuthService.DataAccess;
using AuthService.DataAccess.Configuration;
using AuthService.DataAccess.Interfaces;
using AuthService.DataAccess.Repository;
using AuthService.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Api;

/// <summary>
/// Методы расширения класса Program
/// </summary>
public static class ExtensionMethods
{
    /// <summary>
    /// Добавить сервисы в DI
    /// </summary>
    /// <param name="serviceCollection">Сервисы программы</param>
    public static void AddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IAuthenticationService, AuthenticationService>();
        serviceCollection.AddScoped<IUserRepository, UserRepository>();

    }

    /// <summary>
    /// Добавить DbContext с конфигурациями в DI
    /// </summary>
    /// <param name="serviceCollection">Сервисы программы</param>
    public static void AddDbContextWithConfigurations(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IDbContextOptionsConfigurator<AuthDbContext>, AuthDbContextConfiguration>();
        serviceCollection.AddDbContext<AuthDbContext>((Action<IServiceProvider, DbContextOptionsBuilder>)
            ((sp, dbOptions) => sp.GetRequiredService<IDbContextOptionsConfigurator<AuthDbContext>>()
                .Configure((DbContextOptionsBuilder<AuthDbContext>)dbOptions)));
        serviceCollection.AddScoped((Func<IServiceProvider, DbContext>)(sp => sp.GetRequiredService<AuthDbContext>()));
    }
}
