using AuthService.Domain.Entries;
using AuthServiceContracts.User;
using AutoMapper;

namespace AuthService.Application.Mapping;

/// <summary>
/// Профиль автомаппера для сущности пользователя
/// </summary>
public class UserMappingsProfile : Profile
{
    public UserMappingsProfile()
    {
        CreateMap<User, UserDto>();
    }
}
