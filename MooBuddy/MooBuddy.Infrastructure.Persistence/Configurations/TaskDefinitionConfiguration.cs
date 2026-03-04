using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class TaskDefinitionConfiguration : IEntityTypeConfiguration<TaskDefinition>
    {
        public void Configure(EntityTypeBuilder<TaskDefinition> builder)
        {
            builder.HasKey(td => td.Id);

            builder.Property(td => td.Title)
                .HasMaxLength(256);

            builder.Property(td => td.Description)
                .HasMaxLength(1024);

            builder.Property(td => td.ExpReward)
                .HasPrecision(18, 2);

            builder.Property(td => td.CustomDays)
                .HasMaxLength(50);

            builder.HasOne(td => td.Family)
                .WithMany()
                .HasForeignKey(td => td.FamilyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(td => td.FamilyId);

            builder.HasIndex(td => td.IsDeleted);

            builder.HasIndex(td => td.Type);
        }
    }
}
