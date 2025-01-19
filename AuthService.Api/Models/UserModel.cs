namespace AuthService.Api.Models;

/// <summary>
/// Модель пользователя
/// </summary>
public class UserModel
{
    /// <summary>
    /// ID пользователя
    /// </summary>
    public required string Id { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Логин
    /// </summary>
    public string? Login { get; set; }

    /// <summary>
    /// Электронная почта
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Пароль
    /// </summary>
    public string? PasswordHash { get; set; }

    /// <summary>
    /// Дата регистрации
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Активен ли пользователь
    /// </summary>
    public bool IsActive { get; set; }
}
