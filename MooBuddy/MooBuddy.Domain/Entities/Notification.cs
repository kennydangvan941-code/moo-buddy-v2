using System;
using MooBuddy.Domain.Common;
using MooBuddy.Domain.Enums;

namespace MooBuddy.Domain.Entities
{
    public class Notification : BaseEntity
    {
        public Guid ReceiverProfileId { get; set; }

        public string? Title { get; set; }
        public string? Content { get; set; }
        public bool IsRead { get; set; }
        public string? DeepLink { get; set; }
        public NotificationType Type { get; set; }

        public virtual Profile? ReceiverProfile { get; set; }
    }
}
