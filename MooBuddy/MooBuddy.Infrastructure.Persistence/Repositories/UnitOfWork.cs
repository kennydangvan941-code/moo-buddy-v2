using MooBuddy.Application.Common.Interfaces;
using MooBuddy.Infrastructure.Persistence.Contexts;

namespace MooBuddy.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MooBuddyDbContext _context;

        public IUserRepository Users { get; }
        public IFamilyRepository Families { get; }

        public UnitOfWork(MooBuddyDbContext context, IUserRepository users, IFamilyRepository families)
        {
            _context = context;
            Users = users;
            Families = families;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
