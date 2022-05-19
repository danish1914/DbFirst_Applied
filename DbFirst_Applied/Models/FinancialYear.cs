using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class FinancialYear
    {
        public FinancialYear()
        {
            MnthOpBlncs = new HashSet<MnthOpBlnc>();
        }

        public int Id { get; set; }
        public decimal Year { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool YearClose { get; set; }
        public bool? Wt { get; set; }
        public bool? Tr { get; set; }
        public bool? Pl { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<MnthOpBlnc> MnthOpBlncs { get; set; }
    }
}
