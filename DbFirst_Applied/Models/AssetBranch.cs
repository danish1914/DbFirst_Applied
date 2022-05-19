﻿using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class AssetBranch
    {
        public AssetBranch()
        {
            AssetLocations = new HashSet<AssetLocation>();
        }

        public int Id { get; set; }
        public string? BranchName { get; set; }
        public string? BranchCode { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<AssetLocation> AssetLocations { get; set; }
    }
}
