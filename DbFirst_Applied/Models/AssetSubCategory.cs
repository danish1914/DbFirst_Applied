using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class AssetSubCategory
    {
        public AssetSubCategory()
        {
            Assets = new HashSet<Asset>();
        }

        public int Id { get; set; }
        public string? SubCategoryName { get; set; }
        public string? SubCategoryCode { get; set; }
        public int? MainCategoryId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual AssetCategory? MainCategory { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
    }
}
