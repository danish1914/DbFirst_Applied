using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Nok
    {
        public int Id { get; set; }
        public string NokNo { get; set; } = null!;
        public string? NokName { get; set; }
        public int? MemberId { get; set; }
        public DateTime? Dob { get; set; }
        public int? Age { get; set; }
        public int? RelationId { get; set; }
        public DateTime? Entdate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }
    }
}
