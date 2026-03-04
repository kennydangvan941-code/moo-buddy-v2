using System;
using MooBuddy.Domain.Common;

namespace MooBuddy.Domain.Entities
{
    public class FarmSlot : BaseEntity
    {
        public Guid ProfileId { get; set; }
        public Guid? CowId { get; set; }

        public int SlotNumber { get; set; }
        public bool IsOccupied { get; set; }

        public virtual Profile? Profile { get; set; }
        public virtual Cow? Cow { get; set; }
    }
}
