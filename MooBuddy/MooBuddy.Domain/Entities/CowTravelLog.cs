using System;
using MooBuddy.Domain.Common;

namespace MooBuddy.Domain.Entities
{
    public class CowTravelLog : BaseEntity
    {
        public Guid CowId { get; set; }

        public string? Destination { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? GiftReceived { get; set; }
        public int ExpGained { get; set; }

        public virtual Cow? Cow { get; set; }
    }
}
