using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class RewardRedemptionConfiguration : IEntityTypeConfiguration<RewardRedemption>
    {
        public void Configure(EntityTypeBuilder<RewardRedemption> builder)
        {
            builder.HasKey(rr => rr.Id);

            builder.HasOne(rr => rr.Profile)
                .WithMany()
                .HasForeignKey(rr => rr.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(rr => rr.RewardSetting)
                .WithMany()
                .HasForeignKey(rr => rr.RewardSettingId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(rr => rr.ProfileId);

            builder.HasIndex(rr => rr.RewardSettingId);

            builder.HasIndex(rr => rr.IsClaimed);
        }
    }
}
