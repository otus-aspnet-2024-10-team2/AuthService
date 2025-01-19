using AuthService.DataAccess.Repository;
using AuthService.Domain.Models;

namespace AuthService.Application.Authentication.Services
{
    public  class AuthenticationService: IAuthenticationService
    {
        private readonly IUserRepository _repository;

        public AuthenticationService(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Login(User user)
        {
            await _repository.Create(user);
            return user.Id;
        }
    }
}
