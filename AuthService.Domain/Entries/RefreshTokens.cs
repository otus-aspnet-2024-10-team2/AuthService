namespace AuthService.Domain.Entries
{
    /// <summary>
    /// Токен обновления
    /// </summary>
    public class RefreshTokens: IEntity<string>
    {
        /// <summary>
        /// Уникальный идентификатор токена
        /// </summary>
        public required string Id { get; set; }
        /// <summary>
        /// Значение токена
        /// </summary>
        public string Token { get; set; } = string.Empty;
        /// <summary>
        /// Дата и время истечения срока действия токена
        /// </summary>
        public DateTimeOffset ExpiresAt { get; set; }
        /// <summary>
        /// Дата и время создания токена
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }
        /// <summary>
        /// Внешний ключ на User
        /// </summary>
        public string? UserId { get; set; }
        /// <summary>
        /// Навигационное свойство
        /// </summary>
        public virtual User? User { get; set; }
    }
}
