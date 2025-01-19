using AuthService.DataAccess.Models;
using AuthService.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AuthService.DataAccess.Configuration
{
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
}
