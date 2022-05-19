using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class PropertyDealer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? StaxNo { get; set; }
        public string? IncTaxNo { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }
        public string? Fax { get; set; }
        public string? Zip { get; set; }
        public decimal? AcNo { get; set; }
        public string? Status { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }
    }
}
