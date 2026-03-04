using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class FarmSlotConfiguration : IEntityTypeConfiguration<FarmSlot>
    {
        public void Configure(EntityTypeBuilder<FarmSlot> builder)
        {
            builder.HasKey(fs => fs.Id);

            builder.HasOne(fs => fs.Profile)
                .WithMany()
                .HasForeignKey(fs => fs.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(fs => fs.Cow)
                .WithOne(c => c.CurrentSlot)
                .HasForeignKey<FarmSlot>(fs => fs.CowId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasIndex(fs => fs.ProfileId);

            builder.HasIndex(fs => new { fs.ProfileId, fs.SlotNumber })
                .IsUnique();
        }
    }
}
