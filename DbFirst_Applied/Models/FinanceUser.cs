using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class FinanceUser
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? FullName { get; set; }
        public string? UserType { get; set; }
        public string? ImagePath { get; set; }
        public bool? Active { get; set; }
        public string? Status { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
