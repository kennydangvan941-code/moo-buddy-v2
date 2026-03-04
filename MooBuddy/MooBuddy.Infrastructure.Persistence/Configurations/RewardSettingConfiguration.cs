using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class RewardSettingConfiguration : IEntityTypeConfiguration<RewardSetting>
    {
        public void Configure(EntityTypeBuilder<RewardSetting> builder)
        {
            builder.HasKey(rs => rs.Id);

            builder.Property(rs => rs.Title)
                .HasMaxLength(256);

            builder.Property(rs => rs.Description)
                .HasMaxLength(1024);

            builder.Property(rs => rs.ImageUrl)
                .HasMaxLength(512);

            builder.HasOne(rs => rs.Family)
                .WithMany()
                .HasForeignKey(rs => rs.FamilyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(rs => rs.FamilyId);

            builder.HasIndex(rs => rs.IsDeleted);

            builder.HasIndex(rs => rs.Status);
        }
    }
}
