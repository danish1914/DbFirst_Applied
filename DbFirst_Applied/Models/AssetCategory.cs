using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class AssetCategory
    {
        public AssetCategory()
        {
            AssetSubCategories = new HashSet<AssetSubCategory>();
        }

        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryCode { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<AssetSubCategory> AssetSubCategories { get; set; }
    }
}
