using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasKey(n => n.Id);

            builder.Property(n => n.Title)
                .HasMaxLength(256);

            builder.Property(n => n.Content)
                .HasMaxLength(1024);

            builder.Property(n => n.DeepLink)
                .HasMaxLength(512);

            builder.HasOne(n => n.ReceiverProfile)
                .WithMany()
                .HasForeignKey(n => n.ReceiverProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(n => n.ReceiverProfileId);

            builder.HasIndex(n => n.IsRead);

            builder.HasIndex(n => n.Type);
        }
    }
}
