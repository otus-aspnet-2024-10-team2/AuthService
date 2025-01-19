using AuthService.DataAccess.Models;
using AuthService.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthService.DataAccess.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly AuthServiceDbContext _dbContext;

        public UserRepository(AuthServiceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Create(User model)
        {
            if (model is null) throw new ArgumentNullException(nameof(model));

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
}
