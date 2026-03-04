using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class FamilyConfiguration : IEntityTypeConfiguration<Family>
    {
        public void Configure(EntityTypeBuilder<Family> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.FamilyName)
                .HasMaxLength(256);

            builder.Property(f => f.FamilyCode)
                .HasMaxLength(6);

            builder.Property(f => f.ParentPinHash)
                .HasMaxLength(256);

            builder.HasOne(f => f.Owner)
                .WithOne(u => u.Family)
                .HasForeignKey<Family>(f => f.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(f => f.Profiles)
                .WithOne(p => p.Family)
                .HasForeignKey(p => p.FamilyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(f => f.Devices)
                .WithOne(d => d.Family)
                .HasForeignKey(d => d.FamilyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(f => f.OwnerId);

            builder.HasIndex(f => f.Status);

            builder.HasIndex(f => f.FamilyCode)
                .IsUnique();
        }
    }
}
