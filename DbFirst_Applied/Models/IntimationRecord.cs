using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class IntimationRecord
    {
        public IntimationRecord()
        {
            Plots = new HashSet<Plot>();
            PurchaserRecords = new HashSet<PurchaserRecord>();
        }

        public int Id { get; set; }
        public string? AffidavitNo { get; set; }
        public bool? Intimation { get; set; }
        public string? IntimationCode { get; set; }
        public DateTime? IntimationDate { get; set; }
        public bool? Allocation { get; set; }
        public DateTime? AllocationDate { get; set; }
        public string? ApplicationNo { get; set; }
        public int Dealid { get; set; }
        public string? DealNo { get; set; }
        public int? LandOwnerId { get; set; }
        public int? InvesterId { get; set; }
        public string? SaleDeedNo { get; set; }
        public DateTime? SaleDate { get; set; }
        public int? MauzaId { get; set; }
        public string? Phase { get; set; }
        public string? Sector { get; set; }
        public bool? Kanal { get; set; }
        public bool? Marla { get; set; }
        public string? Remarks { get; set; }
        public string? Sqft { get; set; }
        public int? AssociateFee { get; set; }
        public int? MiscChrg { get; set; }
        public string? PlotNo { get; set; }
        public decimal? Chno { get; set; }
        public byte[]? ImagePath { get; set; }
        public bool? JointOwner { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Plot> Plots { get; set; }
        public virtual ICollection<PurchaserRecord> PurchaserRecords { get; set; }
    }
}
