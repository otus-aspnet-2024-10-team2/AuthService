using AuthService.Domain.Abstractions;
using AuthService.Domain.Entries;
using AuthServiceContracts.User;
using AutoMapper;

namespace AuthService.Application.Services;

public class AuthenticationService(IUserRepository repository, IMapper mapper) : IAuthenticationService
{
    private readonly IUserRepository _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    private readonly IMapper _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

    public async Task<UserDto> Login(string id, CancellationToken cancellationToken)
    {
        var lesson = await _repository.GetAsync(id, cancellationToken);
        return _mapper.Map<User, UserDto>(lesson);        
    }
}
