using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class CowQueueConfiguration : IEntityTypeConfiguration<CowQueue>
    {
        public void Configure(EntityTypeBuilder<CowQueue> builder)
        {
            builder.HasKey(cq => cq.Id);

            builder.Property(cq => cq.Note)
                .HasMaxLength(512);

            builder.HasOne(cq => cq.Profile)
                .WithMany()
                .HasForeignKey(cq => cq.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(cq => cq.Cow)
                .WithMany()
                .HasForeignKey(cq => cq.CowId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(cq => cq.ProfileId);

            builder.HasIndex(cq => cq.Priority);
        }
    }
}
