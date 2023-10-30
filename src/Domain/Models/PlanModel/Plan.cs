using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models.PlanModel
{
    public class Plan
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string TypePlan { get; set; }
        public float ValuePlan { get; set; }
        public string TransactionWay { get; set; }
        public Guid UserID { get; set; }
        public bool IsActive { get; set; }
    }
}