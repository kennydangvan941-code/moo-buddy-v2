using System;
using MooBuddy.Domain.Common;

namespace MooBuddy.Domain.Entities
{
    public class CowQueue : BaseEntity
    {
        public Guid ProfileId { get; set; }
        public Guid CowId { get; set; }

        public int Priority { get; set; }
        public string? Note { get; set; }

        public virtual Profile? Profile { get; set; }
        public virtual Cow? Cow { get; set; }
    }
}
