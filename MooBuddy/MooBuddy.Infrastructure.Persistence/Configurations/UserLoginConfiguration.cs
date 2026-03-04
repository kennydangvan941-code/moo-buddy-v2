using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Infrastructure.Persistence.Configurations
{
    public class UserLoginConfiguration : IEntityTypeConfiguration<UserLogin>
    {
        public void Configure(EntityTypeBuilder<UserLogin> builder)
        {
            builder.HasKey(ul => ul.Id);

            builder.Property(ul => ul.Provider)
                .HasMaxLength(50);

            builder.Property(ul => ul.ProviderKey)
                .HasMaxLength(256);

            builder.Property(ul => ul.ProviderDisplayName)
                .HasMaxLength(256);

            builder.HasOne(ul => ul.User)
                .WithMany(u => u.Logins)
                .HasForeignKey(ul => ul.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(ul => ul.UserId);

            builder.HasIndex(ul => new { ul.Provider, ul.ProviderKey })
                .IsUnique();
        }
    }
}
