using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class PlotHistory
    {
        public PlotHistory()
        {
            PlotHistoryDetails = new HashSet<PlotHistoryDetail>();
        }

        public int Id { get; set; }
        public int? PlotId { get; set; }
        public int? TransTypeId { get; set; }
        public DateTime? BuyDate { get; set; }
        public int? AllotmentId { get; set; }
        public DateTime? SellingDate { get; set; }
        public bool? JointOwner { get; set; }
        public string? Kanal { get; set; }
        public string? Marla { get; set; }
        public string? Remarks { get; set; }
        public DateTime? Entdate { get; set; }
        public string? Sqft { get; set; }
        public string? Spltamgl { get; set; }
        public string? Ltrno { get; set; }
        public bool? Provtran { get; set; }
        public string? Regno { get; set; }
        public bool? Post { get; set; }
        public decimal? PostUser { get; set; }
        public decimal? StampDuty { get; set; }
        public decimal? Cbtax { get; set; }
        public bool DocRcvd { get; set; }
        public DateTime? DocRcvdDate { get; set; }
        public decimal? Ndcno { get; set; }
        public decimal? Siteplanno { get; set; }
        public bool? Ltrready { get; set; }
        public DateTime? Ltrreadydate { get; set; }
        public bool? Ltrdeliver { get; set; }
        public DateTime? Ltrdeliverdate { get; set; }
        public decimal? CustId { get; set; }
        public byte? DocUserid { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual Allotment? Allotment { get; set; }
        public virtual Plot? Plot { get; set; }
        public virtual TransferType? TransType { get; set; }
        public virtual ICollection<PlotHistoryDetail> PlotHistoryDetails { get; set; }
    }
}
