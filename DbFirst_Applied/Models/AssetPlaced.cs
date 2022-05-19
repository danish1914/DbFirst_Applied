using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class AssetPlaced
    {
        public int Id { get; set; }
        public DateTime? TransfarDate { get; set; }
        public int? AssetId { get; set; }
        public int? OldLocationId { get; set; }
        public int? NewLocationId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual Asset? Asset { get; set; }
        public virtual AssetLocation? NewLocation { get; set; }
        public virtual AssetLocation? OldLocation { get; set; }
    }
}
