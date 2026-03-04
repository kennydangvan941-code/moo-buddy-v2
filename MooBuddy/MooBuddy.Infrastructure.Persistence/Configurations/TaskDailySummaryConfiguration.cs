using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class TaskDailySummaryConfiguration : IEntityTypeConfiguration<TaskDailySummary>
    {
        public void Configure(EntityTypeBuilder<TaskDailySummary> builder)
        {
            builder.HasKey(tds => tds.Id);

            builder.HasOne(tds => tds.Profile)
                .WithMany()
                .HasForeignKey(tds => tds.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(tds => tds.ProfileId);

            builder.HasIndex(tds => new { tds.ProfileId, tds.Date })
                .IsUnique();
        }
    }
}
