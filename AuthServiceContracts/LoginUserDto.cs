using System.ComponentModel.DataAnnotations;

namespace AuthService.Api.Contracts
{
    /// <summary>
    /// Информация о пользователе для аутентификации
    /// </summary>
    public class LoginUserDto
    {
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; } = string.Empty;

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; } = string.Empty;
    }
}
