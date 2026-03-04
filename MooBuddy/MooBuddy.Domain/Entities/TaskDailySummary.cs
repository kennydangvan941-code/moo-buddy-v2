using System;
using MooBuddy.Domain.Common;

namespace MooBuddy.Domain.Entities
{
    public class TaskDailySummary : BaseEntity
    {
        public Guid ProfileId { get; set; }

        public DateTime Date { get; set; }

        public int TotalTasksAssigned { get; set; }
        public int TotalTasksCompleted { get; set; }
        public int TotalTasksApproved { get; set; }

        public int TotalGoldEarned { get; set; }
        public int TotalGrassEarned { get; set; }

        public int TotalGrassFed { get; set; }

        public virtual Profile? Profile { get; set; }
    }
}
