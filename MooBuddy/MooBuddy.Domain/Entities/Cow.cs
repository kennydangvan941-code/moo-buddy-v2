using System;
using MooBuddy.Domain.Common;
using MooBuddy.Domain.Enums;

namespace MooBuddy.Domain.Entities
{
    public class Cow : BaseEntity
    {
        public Guid ProfileId { get; set; }

        public string? Name { get; set; }
        public int Level { get; set; }
        public decimal CurrentExp { get; set; }
        public CowStatus Status { get; set; }

        public DateTime? LastFedDate { get; set; }
        public DateTime? LastCheckedDate { get; set; }

        public int TotalMilkProduced { get; set; }

        public virtual Profile? Profile { get; set; }
        public virtual FarmSlot? CurrentSlot { get; set; }
    }
}
