using AuthService.Domain.Entries;

namespace AuthService.Domain.Abstractions;

/// <summary>
/// Репозиторий работы с пользователями
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// Полчение пользователя
    /// </summary>
    /// <param name="id"> ID пользователя. </param>
    /// <param name="cancellationToken"> Токен отмены </param>
    /// <returns> Пользователь </returns>
    Task<User> GetAsync(string id, CancellationToken cancellationToken);
}
