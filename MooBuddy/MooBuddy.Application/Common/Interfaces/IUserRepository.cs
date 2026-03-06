using MooBuddy.Domain.Entities;
using System.Linq.Expressions;

namespace MooBuddy.Application.Common.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> AnyAsync(Expression<Func<User, bool>> predicate);
        void Add(User user);
    }
}
