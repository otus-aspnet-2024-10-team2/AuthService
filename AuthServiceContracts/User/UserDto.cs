namespace AuthServiceContracts.User;

/// <summary>
/// DTO пользователя
/// </summary>
public class UserDto
{
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
    /// Дата регистрации
    /// </summary>
    public DateTime CreatedAt { get; set; }

}
