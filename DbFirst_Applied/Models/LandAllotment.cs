using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class LandAllotment
    {
        public int Id { get; set; }
        public string? IntimationCode { get; set; }
        public string? PurchaserName { get; set; }
        public string? PurchaserFather { get; set; }
        public string? PurchaserAddress { get; set; }
        public string? Phase { get; set; }
        public string? LandOwner { get; set; }
        public string? SaleDeedNo { get; set; }
        public DateTime? SaleDate { get; set; }
        public decimal? MauzaId { get; set; }
        public string? AffidavitNo { get; set; }
        public int? AssociateFee { get; set; }
        public int? MiscChrg { get; set; }
        public string? PicPath { get; set; }
        public int? AppNo { get; set; }
        public string? PlotNo { get; set; }
        public decimal? Chno { get; set; }
        public string? ApplicationNo { get; set; }
        public string? Size { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }
    }
}
