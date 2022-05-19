using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Profession
    {
        public Profession()
        {
            MemberFprofessions = new HashSet<Member>();
            MemberHprofessions = new HashSet<Member>();
            MemberProfessions = new HashSet<Member>();
        }

        public int Id { get; set; }
        public string? Profession1 { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Member> MemberFprofessions { get; set; }
        public virtual ICollection<Member> MemberHprofessions { get; set; }
        public virtual ICollection<Member> MemberProfessions { get; set; }
    }
}
