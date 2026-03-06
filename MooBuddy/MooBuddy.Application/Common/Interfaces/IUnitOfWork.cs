namespace MooBuddy.Application.Common.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IFamilyRepository Families { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
