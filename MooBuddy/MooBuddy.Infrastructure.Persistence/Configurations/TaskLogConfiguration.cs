using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class TaskLogConfiguration : IEntityTypeConfiguration<TaskLog>
    {
        public void Configure(EntityTypeBuilder<TaskLog> builder)
        {
            builder.HasKey(tl => tl.Id);

            builder.Property(tl => tl.ProofImageUrl)
                .HasMaxLength(512);

            builder.Property(tl => tl.ParentNote)
                .HasMaxLength(512);

            builder.Property(tl => tl.EarnedExp)
                .HasPrecision(18, 2);

            builder.HasOne(tl => tl.Profile)
                .WithMany()
                .HasForeignKey(tl => tl.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(tl => tl.TaskDefinition)
                .WithMany()
                .HasForeignKey(tl => tl.TaskDefinitionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(tl => tl.ProfileId);

            builder.HasIndex(tl => tl.TaskDefinitionId);

            builder.HasIndex(tl => tl.Status);
        }
    }
}
