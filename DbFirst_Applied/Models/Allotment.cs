using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Allotment
    {
        public Allotment()
        {
            AllotmentDetails = new HashSet<AllotmentDetail>();
            PlotHistories = new HashSet<PlotHistory>();
            PlotHistoryDetails = new HashSet<PlotHistoryDetail>();
            TransferAllocations = new HashSet<TransferAllocation>();
        }

        public int Id { get; set; }
        public int? AllotTypeId { get; set; }
        public DateTime? AllotDate { get; set; }
        public int PlotId { get; set; }
        public string PlotNo { get; set; } = null!;
        public int? ChallanId { get; set; }
        public string? ChallanNo { get; set; }
        public bool? JointOwner { get; set; }
        public string? FileRef { get; set; }
        public DateTime? Entdate { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual AllotmentType? AllotType { get; set; }
        public virtual Challan? Challan { get; set; }
        public virtual Plot Plot { get; set; } = null!;
        public virtual ICollection<AllotmentDetail> AllotmentDetails { get; set; }
        public virtual ICollection<PlotHistory> PlotHistories { get; set; }
        public virtual ICollection<PlotHistoryDetail> PlotHistoryDetails { get; set; }
        public virtual ICollection<TransferAllocation> TransferAllocations { get; set; }
    }
}
