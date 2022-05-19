using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class UserDetail
    {
        public decimal Id { get; set; }
        public string? UserRight { get; set; }
        public string? RtType { get; set; }
        public int? UserId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }
    }
}
