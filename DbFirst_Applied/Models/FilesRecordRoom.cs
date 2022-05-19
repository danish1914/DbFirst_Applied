using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class FilesRecordRoom
    {
        public int Id { get; set; }
        public int? PlotId { get; set; }
        public DateTime? Date { get; set; }
        public string? ShelfName { get; set; }
        public string? ShelfPosition { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual Plot? Plot { get; set; }
    }
}
