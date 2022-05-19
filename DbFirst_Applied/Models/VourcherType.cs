using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class VourcherType
    {
        public VourcherType()
        {
            Journals = new HashSet<Journal>();
        }

        public int Id { get; set; }
        public string? Vdescription { get; set; }
        public string? Vtype { get; set; }
        public string? Vstatus { get; set; }
        public string? Vremarks { get; set; }
        public bool? Isbank { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Journal> Journals { get; set; }
    }
}
