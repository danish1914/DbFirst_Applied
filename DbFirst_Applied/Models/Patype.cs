using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Patype
    {
        public Patype()
        {
            MemberPaTypes = new HashSet<Member>();
            MemberShaheedPaTypes = new HashSet<Member>();
        }

        public int Id { get; set; }
        public string? TypeName { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Member> MemberPaTypes { get; set; }
        public virtual ICollection<Member> MemberShaheedPaTypes { get; set; }
    }
}
