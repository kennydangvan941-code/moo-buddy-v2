using MooBuddy.Application.Common.Interfaces;
using MooBuddy.Domain.Entities;
using MooBuddy.Infrastructure.Persistence.Contexts;

namespace MooBuddy.Infrastructure.Persistence.Repositories
{
    public class FamilyRepository : BaseRepository<Family>, IFamilyRepository
    {
        public FamilyRepository(MooBuddyDbContext context) : base(context)
        {
        }

        public void Add(Family family)
        {
            _dbSet.Add(family);
        }
    }
}
