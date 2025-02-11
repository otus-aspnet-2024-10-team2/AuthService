using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AuthService.DataAccess;

public class AuthDbContext : DbContext
{
    /// <summary>
    /// Конструктор <see cref="AuthDbContext"/>
    /// </summary>
    /// <param name="options">Настройки контекста</param>
    public AuthDbContext(DbContextOptions options) : base(options)
    {
    }

    /// <summary>
    /// Конфигурирует модель данных при создании контекста.
    /// </summary>
    /// <param name="modelBuilder">Объект для построения модели данных.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly(), t => t.GetInterfaces().Any(i =>
            i.IsGenericType &&
            i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>)));
    }
}
