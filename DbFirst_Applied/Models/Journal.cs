using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Journal
    {
        public Journal()
        {
            JournalDetails = new HashSet<JournalDetail>();
        }

        public int Id { get; set; }
        public int? ChallanId { get; set; }
        public int JrmonthVoucherNo { get; set; }
        public int? VoucherTypeId { get; set; }
        public DateTime JrtransactionDate { get; set; }
        public DateTime? JrentryDate { get; set; }
        public int? ConnUser { get; set; }
        public int? PostedUser { get; set; }
        public bool? Status { get; set; }
        public int? BankId { get; set; }
        public string? CheckNo { get; set; }
        public DateTime? CheckDate { get; set; }
        public string? PaidTo { get; set; }
        public string? MonthToCompare { get; set; }
        public int? Fyear { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual Bank? Bank { get; set; }
        public virtual Challan? Challan { get; set; }
        public virtual VourcherType? VoucherType { get; set; }
        public virtual ICollection<JournalDetail> JournalDetails { get; set; }
    }
}
