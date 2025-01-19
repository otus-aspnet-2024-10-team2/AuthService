using AuthService.Domain.Models;

namespace AuthService.Application.Authentication.Services
{
    /// <summary>
    /// Сервис для аутентификации и регистрации пользователей
    /// </summary>
    public interface IAuthenticationService
    {
        /// <summary>
        /// Возвращает ID пользователя
        /// </summary>
        /// <param user >Модель данных авторизации</param>
        /// <returns>ID</returns>
        Task<Guid> Login(User user);
    }
}
