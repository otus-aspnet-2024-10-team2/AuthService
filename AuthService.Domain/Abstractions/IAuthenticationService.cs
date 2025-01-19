using AuthServiceContracts.User;

namespace AuthService.Domain.Abstractions;

/// <summary>
/// Интерфейс сервиса работы с пользователями
/// </summary>
public interface IAuthenticationService
{
    /// <summary>
    /// Получить пользователя 
    /// </summary>
    /// <param name="id"> ID пользователя </param>
    /// <param name="cancellationToken"> Токен отмены </param>
    /// <returns> ДТО логина юзера </returns>
    Task<UserDto> Login(string id, CancellationToken cancellationToken);
}
