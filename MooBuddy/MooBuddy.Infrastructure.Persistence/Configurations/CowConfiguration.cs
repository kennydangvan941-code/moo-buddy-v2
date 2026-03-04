using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class CowConfiguration : IEntityTypeConfiguration<Cow>
    {
        public void Configure(EntityTypeBuilder<Cow> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .HasMaxLength(256);

            builder.Property(c => c.CurrentExp)
                .HasPrecision(18, 2);

            builder.HasOne(c => c.Profile)
                .WithMany()
                .HasForeignKey(c => c.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.CurrentSlot)
                .WithOne(fs => fs.Cow)
                .HasForeignKey<FarmSlot>(fs => fs.CowId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasIndex(c => c.ProfileId);

            builder.HasIndex(c => c.Status);
        }
    }
}
