using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Bank
    {
        public Bank()
        {
            Challans = new HashSet<Challan>();
            Journals = new HashSet<Journal>();
        }

        public int Id { get; set; }
        public string? BankName { get; set; }
        public decimal? AccountNo { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Challan> Challans { get; set; }
        public virtual ICollection<Journal> Journals { get; set; }
    }
}
