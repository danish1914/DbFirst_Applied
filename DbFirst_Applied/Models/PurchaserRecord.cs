using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class PurchaserRecord
    {
        public int Id { get; set; }
        public int? IntimationRedcordId { get; set; }
        public string? Pname { get; set; }
        public string? Prelation { get; set; }
        public string? PfatherName { get; set; }
        public string? Pcnic { get; set; }
        public string? CellNo { get; set; }
        public string? Address { get; set; }
        public string? PicPath { get; set; }
        public bool? Frontman { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual IntimationRecord? IntimationRedcord { get; set; }
    }
}
