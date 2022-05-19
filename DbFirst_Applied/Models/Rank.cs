using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Rank
    {
        public Rank()
        {
            Designations = new HashSet<Designation>();
        }

        public int Id { get; set; }
        public string? RankType { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Designation> Designations { get; set; }
    }
}
