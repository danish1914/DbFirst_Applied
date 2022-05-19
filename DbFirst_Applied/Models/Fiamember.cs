using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Fiamember
    {
        public int Id { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? OldNo { get; set; }
        public string? NewNo { get; set; }
        public string? Remarks { get; set; }
    }
}
