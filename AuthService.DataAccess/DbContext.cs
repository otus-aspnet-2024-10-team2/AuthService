using AuthService.Domain.Entries;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AuthService.DataAccess;

public class UserDbContext : DbContext
{
    public DbSet<User> Users {  get; set; }

    public UserDbContext(DbContextOptions<UserDbContext> options)
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
