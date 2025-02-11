namespace AuthService.Domain.Entries;
/// <summary>
/// Роль
/// </summary>
public class Role : IEntity<string>
{
    /// <summary>
    /// Id роли
    /// </summary>
    public required string Id {  get; set; }
    /// <summary>
    /// Имя роли
    /// </summary>
    public string? Name {  get; set; }
    /// <summary>
    /// Описание роли
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Навигационное свойство
    /// </summary>
    public virtual List<User> Users { get; set; } = [];
}
