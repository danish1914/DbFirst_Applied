using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class OpeningBalance
    {
        public int Id { get; set; }
        public decimal AccountNo { get; set; }
        public int FinancialYearId { get; set; }
        public string Status { get; set; } = null!;
        public double? Openbalance { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }
    }
}
