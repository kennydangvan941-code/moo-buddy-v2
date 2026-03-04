using System;
using MooBuddy.Domain.Common;
using MooBuddy.Domain.Enums;

namespace MooBuddy.Domain.Entities
{
    public class RewardSetting : SoftDeleteEntity
    {
        public Guid FamilyId { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public int GoldCost { get; set; }
        
        public string? ImageUrl { get; set; }
        public RewardStatus Status { get; set; }
        
        public int? LimitPerWeek { get; set; }

        public virtual Family? Family { get; set; }
    }
}
