using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Fiafile
    {
        public int Id { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? PlotNo { get; set; }
        public string? IssueNo { get; set; }
        public string? MemberNo { get; set; }
        public string? Remarks { get; set; }
    }
}
