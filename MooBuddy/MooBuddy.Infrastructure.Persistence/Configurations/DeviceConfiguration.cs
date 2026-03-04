using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.DeviceName)
                .HasMaxLength(256);

            builder.Property(d => d.DeviceId)
                .HasMaxLength(256);

            builder.Property(d => d.OS)
                .HasMaxLength(50);

            builder.Property(d => d.OSVersion)
                .HasMaxLength(50);

            builder.HasOne(d => d.Family)
                .WithMany(f => f.Devices)
                .HasForeignKey(d => d.FamilyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(d => d.FamilyId);

            builder.HasIndex(d => d.DeviceId)
                .IsUnique();
        }
    }
}
