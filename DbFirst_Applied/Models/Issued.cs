using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Issued
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        public int? PlotId { get; set; }
        public int? ReasonId { get; set; }
        public DateTime? IssuedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual IssuedPerson? Person { get; set; }
        public virtual Plot? Plot { get; set; }
        public virtual FileIssueingReason? Reason { get; set; }
    }
}
