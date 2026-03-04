using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Email)
                .HasMaxLength(256);

            builder.Property(u => u.PasswordHash)
                .HasMaxLength(256);

            builder.Property(u => u.FullName)
                .HasMaxLength(256);

            builder.Property(u => u.PhoneNumber)
                .HasMaxLength(20);

            builder.Property(u => u.RefreshToken)
                .HasMaxLength(256);

            builder.HasMany(u => u.Logins)
                .WithOne(ul => ul.User)
                .HasForeignKey(ul => ul.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Profiles)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.Family)
                .WithOne(f => f.Owner)
                .HasForeignKey<Family>(f => f.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.HasIndex(u => u.Status);
        }
    }
}
