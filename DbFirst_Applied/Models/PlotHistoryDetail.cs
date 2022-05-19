using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class PlotHistoryDetail
    {
        public int Id { get; set; }
        public int? PlotHistoryId { get; set; }
        public int AllotmentId { get; set; }
        public int? MembershipId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual Allotment Allotment { get; set; } = null!;
        public virtual Member? Membership { get; set; }
        public virtual PlotHistory? PlotHistory { get; set; }
    }
}
