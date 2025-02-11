using AuthService.Domain.Entries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AuthService.DataAccess.Configuration;

/// <summary>
/// Конфигурация EF Core для сущности <see cref="AuthService.Domain.Entries.RefreshTokens"/>.
/// Определяет настройки для таблицы RefreshTokens в базе данных.
/// </summary>
public class RefreshTokensConfiguration : IEntityTypeConfiguration<RefreshTokens>
{
    /// <summary>
    /// Конфигурирует сущность <see cref="RefreshTokens"/> с использованием указанного строителя.
    /// </summary>
    /// <param name="builder">Строитель для конфигурации сущности.</param>
    public void Configure(EntityTypeBuilder<RefreshTokens> builder)
    {
        builder.HasKey(r => r.Id);

        builder.Property(r => r.Token)
            .HasMaxLength(255)
            .IsRequired();
     
        builder.Property(r => r.CreatedAt)
            .HasColumnType("timestamptz")
            .IsRequired();

        builder.Property(r => r.ExpiresAt)
            .HasColumnType("timestamptz")
            .IsRequired();

        builder.HasOne(r => r.User)
            .WithMany(u => u.RefreshTokens)
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();
    }
}

