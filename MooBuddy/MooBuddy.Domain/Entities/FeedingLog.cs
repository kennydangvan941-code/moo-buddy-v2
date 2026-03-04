using System;
using MooBuddy.Domain.Common;

namespace MooBuddy.Domain.Entities
{
    public class FeedingLog : BaseEntity
    {
        public Guid ProfileId { get; set; }
        public Guid CowId { get; set; }

        public int Quantity { get; set; }
        public DateTime FedAt { get; set; }

        public virtual Profile? Profile { get; set; }
        public virtual Cow? Cow { get; set; }
    }
}
