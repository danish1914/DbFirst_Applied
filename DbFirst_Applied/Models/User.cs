using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public decimal? Empid { get; set; }
        public DateTime? Tout { get; set; }
        public bool? Active { get; set; }
        public bool? Manager { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? Role { get; set; }
    }
}
