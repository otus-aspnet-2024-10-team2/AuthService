namespace AuthService.Domain.Entries;

/// <summary>
/// Интерфейс сущности с идентификатором
/// </summary>
/// <typeparam name="TId"> Тип идентификатора </typeparam>
public interface IEntity<TId>
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    TId Id { get; set; }
}