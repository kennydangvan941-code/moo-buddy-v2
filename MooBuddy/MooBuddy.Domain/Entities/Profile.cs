using System;
using System.Collections.Generic;
using MooBuddy.Domain.Common;
using MooBuddy.Domain.Enums;

namespace MooBuddy.Domain.Entities
{
    public class Profile : BaseEntity
    {
        public Guid FamilyId { get; set; }
        public Guid UserId { get; set; }

        public string? DisplayName { get; set; }
        public string? AvatarUrl { get; set; }
        
        public ProfileRole Role { get; set; }
        public ProfileStatus Status { get; set; }

        public int TotalGold { get; set; }
        public string? ChildPasscode { get; set; }

        public virtual Family? Family { get; set; }
        public virtual User? User { get; set; }
    }
}
