using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class SupplierType
    {
        public SupplierType()
        {
            Parties = new HashSet<Party>();
        }

        public int Id { get; set; }
        public string? SupplierType1 { get; set; }

        public virtual ICollection<Party> Parties { get; set; }
    }
}
