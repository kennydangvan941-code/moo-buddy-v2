using MooBuddy.Domain.Common;
using MooBuddy.Domain.Enums;

namespace MooBuddy.Domain.Entities
{
    public class User : BaseEntity
    {
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
        
        public UserStatus Status { get; set; }

        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }

        public virtual ICollection<UserLogin>? Logins { get; set; }
        public virtual ICollection<Profile>? Profiles { get; set; }
        public virtual Family? Family { get; set; }
    }
}
