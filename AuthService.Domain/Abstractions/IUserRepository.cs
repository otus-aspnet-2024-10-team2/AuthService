using AuthService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.DataAccess.Repository
{
    /// <summary>
    /// Базовый репозиторий
    /// </summary>
    /// <typeparam name="TEntity">Сущность</typeparam>
    public interface IUserRepository
    { 
        /// <summary>
        /// Добавить объект User в бд
        /// </summary>
        /// <param name="model">Объект для добавления</param>
        Task<Guid> Create(User model);
    }
}
