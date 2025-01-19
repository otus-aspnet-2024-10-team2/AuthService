using AuthService.Domain.Abstractions;
using AuthService.Domain.Entries;
using Microsoft.EntityFrameworkCore;

namespace AuthService.DataAccess.Repository;

public class UserRepository(UserDbContext context) : Repository<User, string>(context), IUserRepository
{

    /// <summary>
    /// Асинхронное получение сущности по ID
    /// </summary>
    /// <param name="id"> Id сущности </param>
    /// <param name="cancellationToken"></param>
    /// <returns> Пользовтель </returns>
    public override async Task<User> GetAsync(string id, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(nameof(id));

        var query = context.Set<User>().AsQueryable();
        ArgumentNullException.ThrowIfNull(query);

        var result = await query.SingleOrDefaultAsync(c => c.Id == id, cancellationToken);
        ArgumentNullException.ThrowIfNull(result);

        return result;
    }

}
