using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.DisplayName)
                .HasMaxLength(256);

            builder.Property(p => p.AvatarUrl)
                .HasMaxLength(512);

            builder.Property(p => p.ChildPasscode)
                .HasMaxLength(10);

            builder.HasOne(p => p.Family)
                .WithMany(f => f.Profiles)
                .HasForeignKey(p => p.FamilyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.User)
                .WithMany(u => u.Profiles)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(p => p.FamilyId);

            builder.HasIndex(p => p.UserId);

            builder.HasIndex(p => p.Role);

            builder.HasIndex(p => p.Status);
        }
    }
}
