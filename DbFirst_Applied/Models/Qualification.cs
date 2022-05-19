using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Qualification
    {
        public Qualification()
        {
            Members = new HashSet<Member>();
        }

        public int Id { get; set; }
        public string? Education { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
