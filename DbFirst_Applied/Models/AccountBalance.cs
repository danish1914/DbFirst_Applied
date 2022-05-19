using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class AccountBalance
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public string? AccountNo { get; set; }
        public string? AccountName { get; set; }
        public string? AccountClass { get; set; }
        public decimal? Balance { get; set; }
        public decimal? TotalDr { get; set; }
        public decimal? TotalCr { get; set; }
        public decimal? Diffrence { get; set; }
        public int? Year { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual AccountList? Account { get; set; }
    }
}
