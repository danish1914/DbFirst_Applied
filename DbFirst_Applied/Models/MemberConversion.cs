using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class MemberConversion
    {
        public int Id { get; set; }
        public int? MembeId { get; set; }
        public string? OldMember { get; set; }
        public string? NewMember { get; set; }
        public DateTime? ConversionDate { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual Member? Membe { get; set; }
    }
}
