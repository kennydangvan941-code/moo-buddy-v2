using System;
using MooBuddy.Domain.Common;

namespace MooBuddy.Domain.Entities
{
    public class RewardRedemption : BaseEntity
    {
        public Guid ProfileId { get; set; }
        public Guid RewardSettingId { get; set; }

        public bool IsClaimed { get; set; }
        public DateTime? ClaimedAt { get; set; }
        
        public int RedeemedGold { get; set; }

        public virtual Profile? Profile { get; set; }
        public virtual RewardSetting? RewardSetting { get; set; }
    }
}
