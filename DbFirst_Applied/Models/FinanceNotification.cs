using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class FinanceNotification
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public bool? Seen { get; set; }
    }
}
