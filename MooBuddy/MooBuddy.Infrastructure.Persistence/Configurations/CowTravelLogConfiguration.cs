using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class CowTravelLogConfiguration : IEntityTypeConfiguration<CowTravelLog>
    {
        public void Configure(EntityTypeBuilder<CowTravelLog> builder)
        {
            builder.HasKey(ctl => ctl.Id);

            builder.Property(ctl => ctl.Destination)
                .HasMaxLength(256);

            builder.Property(ctl => ctl.GiftReceived)
                .HasMaxLength(512);

            builder.HasOne(ctl => ctl.Cow)
                .WithMany()
                .HasForeignKey(ctl => ctl.CowId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(ctl => ctl.CowId);
        }
    }
}
