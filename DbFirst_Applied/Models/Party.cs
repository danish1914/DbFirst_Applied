using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Party
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? AccountNo { get; set; }
        public string? Address { get; set; }
        public int? SupplierTypeId { get; set; }
        public string? City { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Cnic { get; set; }
        public bool? Active { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual SupplierType? SupplierType { get; set; }
    }
}
