using AuthService.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AuthService.DataAccess.Configuration;

/// <summary>
/// Конфигурация <see cref="AuthDbContext"/> контекста 
/// </summary>
public class AuthDbContextConfiguration : IDbContextOptionsConfigurator<AuthDbContext>
{
    private const string PostgresConnectionStringName = "PostgresAuthServiceDb";

    private readonly IConfiguration _configuration;
    private readonly ILoggerFactory _loggerFactory;

    /// <summary>
    /// Конструктор <see cref="AuthServiceDbContextConfiguration">
    /// </summary>
    /// <param name="configuration">Конфигурации</param>
    /// <param name="loggerFactory">Фабрика логгеров</param>
    public AuthDbContextConfiguration(IConfiguration configuration, ILoggerFactory loggerFactory)
    {
        _configuration = configuration;
        _loggerFactory = loggerFactory;
    }

    /// <inheritdoc />
    /// <exception cref="InvalidOperationException">Строка подключения не найдена в конфигурациях</exception>
    public void Configure(DbContextOptionsBuilder<AuthDbContext> optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString(PostgresConnectionStringName);
        if (string.IsNullOrWhiteSpace(connectionString))
            throw new InvalidOperationException(
                $"Не найдена строка подключения с именем {PostgresConnectionStringName}");
        optionsBuilder.UseNpgsql(connectionString);
        optionsBuilder.UseLoggerFactory(_loggerFactory);
        optionsBuilder.UseLazyLoadingProxies();
    }
}

