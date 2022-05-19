using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class MnthOpBlnc
    {
        public int Id { get; set; }
        public decimal? AccountNo { get; set; }
        public int? MonthNo { get; set; }
        public int? YearId { get; set; }
        public decimal? Obalance { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }

        public virtual FinancialYear? Year { get; set; }
    }
}
