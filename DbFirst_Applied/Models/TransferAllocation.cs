using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class TransferAllocation
    {
        public int Id { get; set; }
        public int? AllotmentId { get; set; }
        public bool? LetterIssued { get; set; }
        public DateTime? AllocationDate { get; set; }
        public int? AssociateFee { get; set; }
        public int? MiscChrg { get; set; }
        public decimal? Chno { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual Allotment? Allotment { get; set; }
    }
}
