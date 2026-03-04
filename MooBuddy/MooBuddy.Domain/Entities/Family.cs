using System;
using System.Collections.Generic;
using MooBuddy.Domain.Common;
using MooBuddy.Domain.Enums;

namespace MooBuddy.Domain.Entities
{
    public class Family : BaseEntity
    {
        public Guid OwnerId { get; set; }

        public string? FamilyName { get; set; }
        public string? FamilyCode { get; set; }
        public string? ParentPinHash { get; set; }
        
        public DateTime SubscriptionExpiryDate { get; set; }
        public bool IsTrialUsed { get; set; }
        public FamilyStatus Status { get; set; }

        public virtual User? Owner { get; set; }
        public virtual ICollection<Profile>? Profiles { get; set; }
        public virtual ICollection<Device>? Devices { get; set; }
    }
}
