using MooBuddy.Domain.Entities;

namespace MooBuddy.Application.Common.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User?> FindByEmailAsync(string email);
        Task<bool> EmailExistsAsync(string email);
        Task<IEnumerable<User>> GetActiveUsersAsync();
        Task<IEnumerable<User>> GetByStatusAsync(MooBuddy.Domain.Enums.UserStatus status);
        Task<User?> FindByIdWithRelationsAsync(Guid id);
        Task<IEnumerable<User>> GetAllWithRelationsAsync();
    }
}