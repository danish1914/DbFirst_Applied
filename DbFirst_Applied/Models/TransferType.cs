using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class TransferType
    {
        public TransferType()
        {
            PlotHistories = new HashSet<PlotHistory>();
            TransferCancelHistories = new HashSet<TransferCancelHistory>();
        }

        public int Id { get; set; }
        public string? TransferDisc { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<PlotHistory> PlotHistories { get; set; }
        public virtual ICollection<TransferCancelHistory> TransferCancelHistories { get; set; }
    }
}
