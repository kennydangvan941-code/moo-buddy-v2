using UuidExtensions;

namespace MooBuddy.Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Uuid7.Guid();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
