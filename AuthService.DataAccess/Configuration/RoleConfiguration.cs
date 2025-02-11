using AuthService.Domain.Entries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthService.DataAccess.Configuration;

/// <summary>
/// Конфигурация EF Core для сущности <see cref="AuthService.Domain.Entries.Role"/>.
/// Определяет настройки для таблицы RefreshTokens в базе данных.
/// </summary>
public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    /// <summary>
    /// Конфигурирует сущность <see cref="Role"/> с использованием указанного строителя.
    /// </summary>
    /// <param name="builder">Строитель для конфигурации сущности.</param>
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasKey(r => r.Id);

        builder.Property(r => r.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(r => r.Description)
            .HasMaxLength(500)
            .IsRequired();

        builder.HasMany(u => u.Users)
            .WithOne(r => r.Role)
            .HasForeignKey(r => r.RoleId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();

        builder.HasData(
            new Role
            {
                Id = "9f932d69 - b410 - 49c8 - b685 - 62727a5494ac",
                Name = "Admin",
                Description = "Администратор системы"
            }
            );
    }
}
