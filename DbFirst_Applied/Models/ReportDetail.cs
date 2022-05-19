﻿using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class ReportDetail
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool Active { get; set; }
    }
}
