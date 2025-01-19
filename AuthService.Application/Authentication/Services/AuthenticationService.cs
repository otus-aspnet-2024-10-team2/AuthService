using AuthService.Domain.Abstractions;
using AuthService.Domain.Models;

namespace AuthService.Application.Authentication.Services;

public  class AuthenticationService(IUserRepository repository) : IAuthenticationService
{
    private readonly IUserRepository _repository = repository;

    public async Task<Guid> Login(User user)
    {
        await _repository.Create(user);
        return user.Id;
    }
}
