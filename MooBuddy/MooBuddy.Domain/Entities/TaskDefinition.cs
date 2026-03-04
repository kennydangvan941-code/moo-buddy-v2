using System;
using MooBuddy.Domain.Common;
using MooBuddy.Domain.Enums;

namespace MooBuddy.Domain.Entities
{
    public class TaskDefinition : SoftDeleteEntity
    {
        public Guid FamilyId { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        
        public int GoldReward { get; set; }
        public decimal ExpReward { get; set; }

        public TaskType Type { get; set; }
        public string? CustomDays { get; set; }

        public bool RequiresImageProof { get; set; }
        public bool IsActive { get; set; }

        public virtual Family? Family { get; set; }
    }
}
