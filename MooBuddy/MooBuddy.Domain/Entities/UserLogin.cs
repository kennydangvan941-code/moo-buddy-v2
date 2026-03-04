using MooBuddy.Domain.Common;

namespace MooBuddy.Domain.Entities
{
    public class UserLogin : BaseEntity
    {
        public Guid UserId { get; set; }

        public string? Provider { get; set; }
        public string? ProviderKey { get; set; }
        public string? ProviderDisplayName { get; set; }

        public virtual User? User { get; set; }
    }
}
