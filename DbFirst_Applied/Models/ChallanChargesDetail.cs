using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class ChallanChargesDetail
    {
        public int Id { get; set; }
        public int? ChallanId { get; set; }
        public int? ChallanChargesId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual Challan? Challan { get; set; }
        public virtual ChallanChargesType? ChallanCharges { get; set; }
    }
}
