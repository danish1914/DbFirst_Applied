using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Ndc
    {
        public int Id { get; set; }
        public decimal? Ndcno { get; set; }
        public int? Plotid { get; set; }
        public int? Membershipid { get; set; }
        public int? PropDealer { get; set; }
        public DateTime? Ndcapplydate { get; set; }
        public bool? Ndcissued { get; set; }
        public DateTime? Ndcissueddate { get; set; }
        public DateTime? Ndcduedate { get; set; }
        public bool? Finance { get; set; }
        public bool? LandOffice { get; set; }
        public bool? LegalOffice { get; set; }
        public bool? RecordOffice { get; set; }
        public bool? TransferAndRecordBranch { get; set; }
        public string? Remarks { get; set; }
        public string? FeedBack { get; set; }
        public string? ForwardTo { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual Member? Membership { get; set; }
        public virtual Plot? Plot { get; set; }
    }
}
