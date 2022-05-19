using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class StampDuty
    {
        public int Id { get; set; }
        public int? Plotid { get; set; }
        public int? MemberId { get; set; }
        public DateTime? CurrTransDate { get; set; }
        public decimal? StampDuty1 { get; set; }
        public decimal? Cvt { get; set; }
        public string? TreasuryNo { get; set; }
        public DateTime? TreasuryDate { get; set; }
        public string? Remarks { get; set; }
        public decimal Phistid { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual Member? Member { get; set; }
        public virtual Plot? Plot { get; set; }
    }
}
