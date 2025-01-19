using AuthService.Api.Models;
using AuthServiceContracts.User;
using AutoMapper;

namespace AuthService.Api.Mapping;

/// <summary>
/// Профиль автомаппера для дто пользователя
/// </summary>
public class UserModelMappingsProfile : Profile
{
    public UserModelMappingsProfile()
    {
        CreateMap<UserDto, UserModel>();
    }
}
