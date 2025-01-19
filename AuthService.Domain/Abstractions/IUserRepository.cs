using AuthService.Domain.Models;

namespace AuthService.Domain.Abstractions;

/// <summary>
/// Базовый репозиторий
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// Добавить объект User в бд
    /// </summary>
    /// <param name="model">Объект для добавления</param>
    Task<Guid> Create(User model);
}
