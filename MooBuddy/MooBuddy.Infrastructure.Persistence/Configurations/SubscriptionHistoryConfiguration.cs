using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class SubscriptionHistoryConfiguration : IEntityTypeConfiguration<SubscriptionHistory>
    {
        public void Configure(EntityTypeBuilder<SubscriptionHistory> builder)
        {
            builder.HasKey(sh => sh.Id);

            builder.Property(sh => sh.TransactionId)
                .HasMaxLength(256);

            builder.Property(sh => sh.PaymentMethod)
                .HasMaxLength(50);

            builder.Property(sh => sh.Amount)
                .HasPrecision(18, 2);

            builder.HasOne(sh => sh.Family)
                .WithMany()
                .HasForeignKey(sh => sh.FamilyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(sh => sh.FamilyId);

            builder.HasIndex(sh => sh.TransactionId)
                .IsUnique();
        }
    }
}
