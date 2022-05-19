using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Received
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        public int? PlotId { get; set; }
        public int? ReasonId { get; set; }
        public string? Reamrks { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }
    }
}
