using System;
using MooBuddy.Domain.Common;

namespace MooBuddy.Domain.Entities
{
    public class FamilySetting : BaseEntity
    {
        public Guid FamilyId { get; set; }

        public bool EnableHungerPenalty { get; set; }
        public int DailyTaskLimit { get; set; }
        public string? DefaultCurrencyName { get; set; }

        public virtual Family? Family { get; set; }
    }
}
