using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class LandMember
    {
        public int LndMemId { get; set; }
        public string? LndMemNo { get; set; }
        public string? Name { get; set; }
        public string? Fname { get; set; }
        public string? Hname { get; set; }
        public bool? Gender { get; set; }
        public string? TelNo { get; set; }
        public string? Address { get; set; }
        public string? NicOld { get; set; }
        public string? NicNew { get; set; }
        public DateTime? EntDate { get; set; }
        public decimal? UserId { get; set; }
        public string? PicPath { get; set; }
        public bool? Active { get; set; }
    }
}
