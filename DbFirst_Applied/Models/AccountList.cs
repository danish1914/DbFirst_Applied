using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class AccountList
    {
        public AccountList()
        {
            AccountBalances = new HashSet<AccountBalance>();
            ChallanChargesTypes = new HashSet<ChallanChargesType>();
            JournalDetails = new HashSet<JournalDetail>();
        }

        public int Id { get; set; }
        public decimal AccountNo { get; set; }
        public decimal? AccountControlL1 { get; set; }
        public decimal? AccountControlL2 { get; set; }
        public decimal? AccountControlL3 { get; set; }
        public decimal? AccountControlL4 { get; set; }
        public decimal? AccountControlL5 { get; set; }
        public decimal? P1 { get; set; }
        public decimal? P2 { get; set; }
        public decimal? P3 { get; set; }
        public decimal? P4 { get; set; }
        public decimal? P5 { get; set; }
        public string? AccountHead { get; set; }
        public decimal AccountParent { get; set; }
        public decimal AccountLlevel { get; set; }
        public string? AccountStatus { get; set; }
        public string AccountClass { get; set; } = null!;
        public decimal? AccountDeprate { get; set; }
        public DateTime? AccountOpenDate { get; set; }
        public decimal? AccountOpenBal { get; set; }
        public bool AccountDepstatus { get; set; }
        public bool Sundary { get; set; }
        public bool AccountTakeOver { get; set; }
        public bool AccountAgeing { get; set; }
        public decimal? AccountRllimit { get; set; }
        public decimal? AccountDays { get; set; }
        public DateTime? AccountEntryDate { get; set; }
        public decimal? AccountBalance { get; set; }
        public bool? Disable { get; set; }
        public decimal? TotalDr { get; set; }
        public decimal? TotalCr { get; set; }
        public int? OrderNo { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<AccountBalance> AccountBalances { get; set; }
        public virtual ICollection<ChallanChargesType> ChallanChargesTypes { get; set; }
        public virtual ICollection<JournalDetail> JournalDetails { get; set; }
    }
}
