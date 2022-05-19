﻿using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Signature
    {
        public int Id { get; set; }
        public string Signature1 { get; set; } = null!;
        public string? Design { get; set; }
        public string? Rank { get; set; }
        public bool DefaultSign { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }
    }
}
