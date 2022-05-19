using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class AllotmentType
    {
        public AllotmentType()
        {
            Allotments = new HashSet<Allotment>();
        }

        public int AllotmentTypeId { get; set; }
        public string? AllotmentTypeDisc { get; set; }
        public string? Cat { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Allotment> Allotments { get; set; }
    }
}
