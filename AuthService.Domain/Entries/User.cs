namespace AuthService.Domain.Entries;

/// <summary>
/// Пользователь
/// </summary>
public class User : IEntity<string>
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
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Активен ли пользователь
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Навигационное свойство
    /// </summary>
    public virtual List<RefreshTokens> RefreshTokens { get; set; } = [];
    /// <summary>
    /// Внешний ключ на Role
    /// </summary>
    public string? RoleId { get; set; }
    /// <summary>
    /// Навигационное свойство
    /// </summary>
    public virtual Role? Role { get; set; }
}
