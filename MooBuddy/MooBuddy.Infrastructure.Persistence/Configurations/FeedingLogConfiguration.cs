using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class FeedingLogConfiguration : IEntityTypeConfiguration<FeedingLog>
    {
        public void Configure(EntityTypeBuilder<FeedingLog> builder)
        {
            builder.HasKey(fl => fl.Id);

            builder.HasOne(fl => fl.Profile)
                .WithMany()
                .HasForeignKey(fl => fl.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(fl => fl.Cow)
                .WithMany()
                .HasForeignKey(fl => fl.CowId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(fl => fl.ProfileId);

            builder.HasIndex(fl => fl.CowId);
        }
    }
}
