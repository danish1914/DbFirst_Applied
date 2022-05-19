using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Asset
    {
        public Asset()
        {
            AssetLogs = new HashSet<AssetLog>();
            AssetMaintenances = new HashSet<AssetMaintenance>();
            AssetPlaceds = new HashSet<AssetPlaced>();
        }

        public int Id { get; set; }
        public string? AssetName { get; set; }
        public string? AssetCode { get; set; }
        public string? TagCode { get; set; }
        public int? OwnershipTypeId { get; set; }
        public int? SubCategoryId { get; set; }
        public decimal? Cost { get; set; }
        public int? Depreciationrate { get; set; }
        public decimal? AcuumlatedD { get; set; }
        public decimal? NetBookValue { get; set; }
        public string? Ponumber { get; set; }
        public string? InvoiceNumber { get; set; }
        public decimal? SaleProceeds { get; set; }
        public string? SalesPayment { get; set; }
        public decimal? GainLoss { get; set; }
        public DateTime? Purchasedate { get; set; }
        public int? UsefulYear { get; set; }
        public DateTime? DatePlcS { get; set; }
        public DateTime? DateDissP { get; set; }
        public int? CurrentlocationId { get; set; }
        public byte[]? Images { get; set; }
        public string? ImgPath { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual AssetLocation? Currentlocation { get; set; }
        public virtual AssetOwnershipType? OwnershipType { get; set; }
        public virtual AssetSubCategory? SubCategory { get; set; }
        public virtual ICollection<AssetLog> AssetLogs { get; set; }
        public virtual ICollection<AssetMaintenance> AssetMaintenances { get; set; }
        public virtual ICollection<AssetPlaced> AssetPlaceds { get; set; }
    }
}
