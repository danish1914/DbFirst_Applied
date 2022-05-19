using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Designation
    {
        public Designation()
        {
            MemberDesignationofShaheeds = new HashSet<Member>();
            MemberDesignations = new HashSet<Member>();
        }

        public int Id { get; set; }
        public string? RankDescp { get; set; }
        public int? RankTypeId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual Rank? RankType { get; set; }
        public virtual ICollection<Member> MemberDesignationofShaheeds { get; set; }
        public virtual ICollection<Member> MemberDesignations { get; set; }
    }
}
