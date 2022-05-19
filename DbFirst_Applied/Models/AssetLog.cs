using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class AssetLog
    {
        public int Id { get; set; }
        public int? AssetId { get; set; }
        public decimal Cost { get; set; }
        public DateTime? FinancialDate { get; set; }
        public DateTime? DisposalDate { get; set; }
        public int? DepreciationRate { get; set; }
        public decimal? DepAmount { get; set; }
        public decimal? Nbv { get; set; }

        public virtual Asset? Asset { get; set; }
    }
}
