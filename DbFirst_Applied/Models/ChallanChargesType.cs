using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class ChallanChargesType
    {
        public ChallanChargesType()
        {
            ChallanChargesDetails = new HashSet<ChallanChargesDetail>();
        }

        public int Id { get; set; }
        public int? ChallanTypeId { get; set; }
        public string? AccountName { get; set; }
        public int? AccountCodeId { get; set; }
        public int? DepartmentId { get; set; }
        public string? ChallanDecp { get; set; }
        public string? ChallanCode { get; set; }
        public decimal? Amount { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual AccountList? AccountCode { get; set; }
        public virtual ChallanType? ChallanType { get; set; }
        public virtual Department? Department { get; set; }
        public virtual ICollection<ChallanChargesDetail> ChallanChargesDetails { get; set; }
    }
}
