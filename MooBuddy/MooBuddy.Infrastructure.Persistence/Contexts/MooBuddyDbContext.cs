using Microsoft.EntityFrameworkCore;
using MooBuddy.Domain.Common;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Contexts
{
    public class MooBuddyDbContext : DbContext
    {
        public MooBuddyDbContext(DbContextOptions<MooBuddyDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<SubscriptionHistory> SubscriptionHistories { get; set; }
        public DbSet<Cow> Cows { get; set; }
        public DbSet<FarmSlot> FarmSlots { get; set; }
        public DbSet<CowQueue> CowQueues { get; set; }
        public DbSet<CowTravelLog> CowTravelLogs { get; set; }
        public DbSet<TaskDefinition> TaskDefinitions { get; set; }
        public DbSet<TaskLog> TaskLogs { get; set; }
        public DbSet<RewardSetting> RewardSettings { get; set; }
        public DbSet<RewardRedemption> RewardRedemptions { get; set; }
        public DbSet<FeedingLog> FeedingLogs { get; set; }
        public DbSet<TaskDailySummary> TaskDailySummaries { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<FamilySetting> FamilySettings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MooBuddyDbContext).Assembly);
        }

        public override int SaveChanges()
        {
            UpdateAuditFields();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateAuditFields();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void UpdateAuditFields()
        {
            var entries = ChangeTracker.Entries();

            foreach (var entry in entries)
            {
                if (entry.Entity is BaseEntity baseEntity)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            baseEntity.CreatedAt = DateTime.UtcNow;
                            baseEntity.UpdatedAt = null;
                            break;

                        case EntityState.Modified:
                            entry.Property(nameof(BaseEntity.CreatedAt)).IsModified = false;
                            baseEntity.UpdatedAt = DateTime.UtcNow;
                            break;
                    }
                }
            }
        }
    }
}
