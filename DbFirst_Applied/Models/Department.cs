using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Department
    {
        public Department()
        {
            ChallanChargesTypes = new HashSet<ChallanChargesType>();
            IssuedPeople = new HashSet<IssuedPerson>();
        }

        public int Id { get; set; }
        public string? BranchName { get; set; }
        public decimal BranchCode { get; set; }
        public string? BranchAddress { get; set; }
        public string? BranchPhone { get; set; }
        public string? BranchFax { get; set; }
        public string? BranchEmail { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<ChallanChargesType> ChallanChargesTypes { get; set; }
        public virtual ICollection<IssuedPerson> IssuedPeople { get; set; }
    }
}
