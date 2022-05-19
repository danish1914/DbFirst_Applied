using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class NaTowner
    {
        public NaTowner()
        {
            Plots = new HashSet<Plot>();
        }

        public int Id { get; set; }
        public string? NowDisc { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Plot> Plots { get; set; }
    }
}
