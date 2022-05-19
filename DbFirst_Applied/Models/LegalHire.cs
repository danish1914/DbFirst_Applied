using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class LegalHire
    {
        public int Id { get; set; }
        public string LegalHireNo { get; set; } = null!;
        public string? LegalHireName { get; set; }
        public int? MemberId { get; set; }
        public int? RelationId { get; set; }
        public string? ContactNo { get; set; }
        public string? Address { get; set; }
        public DateTime? Entdate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual Member? Member { get; set; }
        public virtual Relation? Relation { get; set; }
    }
}
