using AuthService.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthService.DataAccess.Configuration;

internal class UserConfiguration : IEntityTypeConfiguration<UserEntitiy>
{
    public void Configure(EntityTypeBuilder<UserEntitiy> builder)
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
           .IsRequired();

        builder.Property(p => p.IsActive) 
            .IsRequired();

        builder.HasData(
            new UserEntitiy
            {
                Id = Guid.NewGuid(),
                Name = "Иван",
                Login = "Ivan",
                Email = "ivan@gmail.com",
                PasswordHash = "123456",
                CreatedAt = DateTime.Now,
                IsActive = true
            },
            new UserEntitiy
            {
                Id = Guid.NewGuid(),
                Name = "Маша",
                Login = "Masha",
                Email = "masha@gmail.com",
                PasswordHash = "12222333",
                CreatedAt = DateTime.Now,
                IsActive = true
            }
            );

    }
}
