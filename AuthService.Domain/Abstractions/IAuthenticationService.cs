using AuthService.Domain.Models;

namespace AuthService.Domain.Abstractions;

/// <summary>
/// Сервис для аутентификации и регистрации пользователей
/// </summary>
public interface IAuthenticationService
{
    /// <summary>
    /// Возвращает ID пользователя
    /// </summary>
    /// <param name="user">Модель данных пользователя</param>
    /// <returns>ID</returns>
    Task<Guid> Login(User user);
}
