using AuthService.Domain.Entries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AuthService.DataAccess.Configuration;
/// <summary>
/// Конфигурация EF Core для сущности <see cref="AuthService.Domain.Entries.User"/>.
/// Определяет настройки для таблицы RefreshTokens в базе данных.
/// </summary>
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    /// <summary>
    /// Конфигурирует сущность <see cref="User"/> с использованием указанного строителя.
    /// </summary>
    /// <param name="builder">Строитель для конфигурации сущности.</param>
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(id => id.Id);

        builder.Property(p => p.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.Login)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.PasswordHash)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(p => p.Email)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.CreatedAt)
            .HasColumnType("timestamptz")
            .IsRequired();

        builder.Property(p => p.IsActive)
            .IsRequired();

        builder.HasMany(u => u.RefreshTokens)
            .WithOne(t => t.User)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();

        builder.HasOne(t => t.Role)
            .WithMany(u => u.Users)
            .HasForeignKey(t => t.RoleId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();

        builder.HasData(
            new User
            {
                Id = "58b80365-4118-40cf-ad9a-56bf4a507ea9",
                Name = "admin",
                Login = "admin",
                Email = "admin@gmail.com",
                PasswordHash = "123456",
                CreatedAt = new DateTimeOffset(new DateTime(2025, 1, 1, 8, 34, 17, DateTimeKind.Utc), TimeSpan.Zero),
                IsActive = true,
                RoleId = "9f932d69 - b410 - 49c8 - b685 - 62727a5494ac"
            }
        );
    }
}
