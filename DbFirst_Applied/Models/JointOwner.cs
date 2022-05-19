using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class JointOwner
    {
        public int Id { get; set; }
        public string? Remarks { get; set; }
        public int? PlotId { get; set; }
        public int? MemberId { get; set; }
        public string? LetterNo { get; set; }

        public virtual Member? Member { get; set; }
        public virtual Plot? Plot { get; set; }
    }
}
