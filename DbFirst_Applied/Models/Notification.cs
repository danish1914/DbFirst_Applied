using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? ChallanId { get; set; }
        public int? MembershipId { get; set; }
        public int? PlotId { get; set; }
        public bool? Ndc { get; set; }
        public bool? Intimation { get; set; }
        public bool? Allocation { get; set; }
        public bool? NewAllotment { get; set; }
        public bool? PlotTransfer { get; set; }
        public bool? TransferCancel { get; set; }
        public bool? Regularmember { get; set; }
        public bool? MemberConversion { get; set; }
        public bool? Seen { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual Challan? Challan { get; set; }
        public virtual Member? Membership { get; set; }
        public virtual Plot? Plot { get; set; }
    }
}
