using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class FamilySettingConfiguration : IEntityTypeConfiguration<FamilySetting>
    {
        public void Configure(EntityTypeBuilder<FamilySetting> builder)
        {
            builder.HasKey(fs => fs.Id);

            builder.Property(fs => fs.DefaultCurrencyName)
                .HasMaxLength(50);

            builder.HasOne(fs => fs.Family)
                .WithMany()
                .HasForeignKey(fs => fs.FamilyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(fs => fs.FamilyId)
                .IsUnique();
        }
    }
}
