using AuthService.DataAccess.Models;
using AuthService.Domain.Abstractions;
using AuthService.Domain.Models;

namespace AuthService.DataAccess.Repository;

public class UserRepository(AuthServiceDbContext dbContext) : IUserRepository
{
    private readonly AuthServiceDbContext _dbContext = dbContext;

    public async Task<Guid> Create(User model)
    {
        ArgumentNullException.ThrowIfNull(model);

        var user = new UserEntitiy
        {
            Id = model.Id,
            Name = model.Name,
            Login = model.Login,
            Email = model.Email,
            PasswordHash = model.PasswordHash,
            CreatedAt = model.CreatedAt,
            IsActive = model.IsActive,
        };

        await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();

        return user.Id;
    }
}
