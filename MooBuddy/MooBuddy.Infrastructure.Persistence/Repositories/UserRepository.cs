using Microsoft.EntityFrameworkCore;
using MooBuddy.Domain.Entities;
using MooBuddy.Infrastructure.Persistence.Contexts;

namespace MooBuddy.Infrastructure.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(MooBuddyDbContext context) : base(context)
        {
        }

        public async Task<User?> FindByEmailAsync(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _dbSet.AnyAsync(u => u.Email == email);
        }

        public async Task<IEnumerable<User>> GetActiveUsersAsync()
        {
            return await _dbSet.Where(u => u.Status == MooBuddy.Domain.Enums.UserStatus.Active)
                .ToListAsync();
        }

        public async Task<IEnumerable<User>> GetByStatusAsync(MooBuddy.Domain.Enums.UserStatus status)
        {
            return await _dbSet.Where(u => u.Status == status).ToListAsync();
        }

        public async Task<User?> FindByIdWithRelationsAsync(Guid id)
        {
            return await _dbSet
                .Include(u => u.Logins)
                .Include(u => u.Profiles)
                .Include(u => u.Family)
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<IEnumerable<User>> GetAllWithRelationsAsync()
        {
            return await _dbSet
                .Include(u => u.Logins)
                .Include(u => u.Profiles)
                .Include(u => u.Family)
                .ToListAsync();
        }
    }
}
