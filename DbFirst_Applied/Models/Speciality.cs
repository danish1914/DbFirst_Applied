﻿using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Speciality
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }
    }
}
