using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Challan
    {
        public Challan()
        {
            Allotments = new HashSet<Allotment>();
            ChallanChargesDetails = new HashSet<ChallanChargesDetail>();
            Journals = new HashSet<Journal>();
            Notifications = new HashSet<Notification>();
        }

        public int Id { get; set; }
        public string? ChallanYmvno { get; set; }
        public decimal ChallanNo { get; set; }
        public decimal? ChallanMno { get; set; }
        public int? Day { get; set; }
        public DateTime? Date { get; set; }
        public int? MembershipId { get; set; }
        public string? MembershipNo { get; set; }
        public string? MemberName { get; set; }
        public int? PlotId { get; set; }
        public DateTime? DueDate { get; set; }
        public double? Amount { get; set; }
        public string? Paid { get; set; }
        public DateTime? PayDate { get; set; }
        public double? AmountPaid { get; set; }
        public decimal? JrvId { get; set; }
        public decimal? JrvNo { get; set; }
        public string? VoType { get; set; }
        public int? BankId { get; set; }
        public decimal? ChallanTypeId { get; set; }
        public string? Remarks { get; set; }
        public string? RecitId { get; set; }
        public string? DocumentNo { get; set; }
        public DateTime? DocDate { get; set; }
        public decimal? DocBank { get; set; }
        public decimal? TransType { get; set; }
        public decimal? PhistId { get; set; }
        public int? Sid { get; set; }
        public int? Ctid { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual Bank? Bank { get; set; }
        public virtual Member? Membership { get; set; }
        public virtual Plot? Plot { get; set; }
        public virtual ICollection<Allotment> Allotments { get; set; }
        public virtual ICollection<ChallanChargesDetail> ChallanChargesDetails { get; set; }
        public virtual ICollection<Journal> Journals { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
