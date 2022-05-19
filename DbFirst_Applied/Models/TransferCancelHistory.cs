using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class TransferCancelHistory
    {
        public int Id { get; set; }
        public int TransferTypeId { get; set; }
        public int PlotId { get; set; }
        public string MemberNo { get; set; } = null!;
        public string OwnerName { get; set; } = null!;
        public DateTime Transdate { get; set; }
        public string? CancelRemarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual Plot Plot { get; set; } = null!;
        public virtual TransferType TransferType { get; set; } = null!;
    }
}
