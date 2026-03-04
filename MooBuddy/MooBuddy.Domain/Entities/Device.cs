using System;
using MooBuddy.Domain.Common;

namespace MooBuddy.Domain.Entities
{
    public class Device : BaseEntity
    {
        public Guid FamilyId { get; set; }

        public string? DeviceName { get; set; }
        public string? DeviceId { get; set; }
        public string? OS { get; set; }
        public string? OSVersion { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastConnectedAt { get; set; }

        public virtual Family? Family { get; set; }
    }
}
