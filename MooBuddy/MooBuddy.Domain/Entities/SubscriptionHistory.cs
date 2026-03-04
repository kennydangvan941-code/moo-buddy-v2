using System;
using MooBuddy.Domain.Common;

namespace MooBuddy.Domain.Entities
{
    public class SubscriptionHistory : BaseEntity
    {
        public Guid FamilyId { get; set; }

        public DateTime PurchaseDate { get; set; }
        public DateTime OldExpiryDate { get; set; }
        public DateTime NewExpiryDate { get; set; }
        
        public decimal Amount { get; set; }
        public string? TransactionId { get; set; }
        public string? PaymentMethod { get; set; }

        public virtual Family? Family { get; set; }
    }
}
