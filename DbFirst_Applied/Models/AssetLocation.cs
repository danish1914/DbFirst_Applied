using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class AssetLocation
    {
        public AssetLocation()
        {
            AssetPlacedNewLocations = new HashSet<AssetPlaced>();
            AssetPlacedOldLocations = new HashSet<AssetPlaced>();
            Assets = new HashSet<Asset>();
        }

        public int Id { get; set; }
        public int? BranchId { get; set; }
        public string? LocationName { get; set; }
        public string? LocationCode { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual AssetBranch? Branch { get; set; }
        public virtual ICollection<AssetPlaced> AssetPlacedNewLocations { get; set; }
        public virtual ICollection<AssetPlaced> AssetPlacedOldLocations { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
    }
}
