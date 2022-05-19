using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class AssetMaintenance
    {
        public int Id { get; set; }
        public int? AssetId { get; set; }
        public string? MaintenanceType { get; set; }
        public decimal? Charges { get; set; }
        public DateTime? MaintenanceDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual Asset? Asset { get; set; }
    }
}
