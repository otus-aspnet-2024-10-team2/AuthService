using AuthService.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AuthService.DataAccess;

public class AuthServiceDbContext : DbContext
{
    public DbSet<UserEntitiy> Users {  get; set; }

    public AuthServiceDbContext(DbContextOptions<AuthServiceDbContext> options)
    : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = AuthServiceDB.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly(), t => t.GetInterfaces().Any(i =>
            i.IsGenericType &&
            i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>)));
    }
}
