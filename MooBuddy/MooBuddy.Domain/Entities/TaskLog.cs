using System;
using MooBuddy.Domain.Common;
using MooBuddy.Domain.Enums;

namespace MooBuddy.Domain.Entities
{
    public class TaskLog : BaseEntity
    {
        public Guid ProfileId { get; set; }
        public Guid TaskDefinitionId { get; set; }

        public Enums.TaskStatus Status { get; set; }
        public string? ProofImageUrl { get; set; }
        public string? ParentNote { get; set; }
        public DateTime? ApprovedAt { get; set; }
        
        public int EarnedGold { get; set; }
        public decimal EarnedExp { get; set; }

        public virtual Profile? Profile { get; set; }
        public virtual TaskDefinition? TaskDefinition { get; set; }
    }
}
