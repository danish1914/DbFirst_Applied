using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class JournalDetail
    {
        public int Id { get; set; }
        public int AccountNoId { get; set; }
        public int JournalId { get; set; }
        public DateTime? JrentryDate { get; set; }
        public string? Jrparticular { get; set; }
        public double? Jrdr { get; set; }
        public double? Jrcr { get; set; }
        public decimal? Jrcfno { get; set; }
        public decimal? Brcode { get; set; }
        public decimal? SubHeadId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual AccountList AccountNo { get; set; } = null!;
        public virtual Journal Journal { get; set; } = null!;
    }
}
