using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AuthService.Domain.Models
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// ID пользователя
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; } = string.Empty;

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; } = string.Empty;

        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email { get; } = string.Empty;

        /// <summary>
        /// Пароль
        /// </summary>
        public string PasswordHash { get; } = string.Empty;

        /// <summary>
        /// Дата регистрации
        /// </summary>
        public DateTime CreatedAt { get; }

        /// <summary>
        /// Активен ли пользователь
        /// </summary>
        public bool IsActive { get; }

        public User(Guid id, string name, string login, string email, string passwordHash, DateTime createdAt, bool isActive)
        {
            Id = id; 
            Name = name; 
            Login = login; 
            Email = email; 
            PasswordHash = passwordHash;
            CreatedAt = createdAt;
            IsActive = IsActive;
        }
    }
}
