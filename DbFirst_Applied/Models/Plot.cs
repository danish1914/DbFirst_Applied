using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Plot
    {
        public Plot()
        {
            Allotments = new HashSet<Allotment>();
            Challans = new HashSet<Challan>();
            FilesRecordRooms = new HashSet<FilesRecordRoom>();
            Issueds = new HashSet<Issued>();
            JointOwners = new HashSet<JointOwner>();
            Ndcs = new HashSet<Ndc>();
            Notifications = new HashSet<Notification>();
            PlotHistories = new HashSet<PlotHistory>();
            StampDuties = new HashSet<StampDuty>();
            TransferCancelHistories = new HashSet<TransferCancelHistory>();
        }

        public int PlotId { get; set; }
        public string PlotNo { get; set; } = null!;
        public int? PlotStatusId { get; set; }
        public int? NaTownerId { get; set; }
        public int? PlotTypeId { get; set; }
        public string? Kanal { get; set; }
        public string? Marla { get; set; }
        public string? Sqft { get; set; }
        public string? FileRef { get; set; }
        public string? Cornor { get; set; }
        public string? LandOwner { get; set; }
        public string? HouseComp { get; set; }
        public DateTime? HouseCompDate { get; set; }
        public string? CoverArea { get; set; }
        public string? Registred { get; set; }
        public DateTime? SwrgOpDate { get; set; }
        public DateTime? WtrOpDate { get; set; }
        public string? Possession { get; set; }
        public string? Mortgage { get; set; }
        public DateTime? SecChrgDate { get; set; }
        public DateTime? DatePurchase { get; set; }
        public string? Size { get; set; }
        public int? IntimationCodeId { get; set; }
        public DateTime? Entdate { get; set; }
        public string? Caution { get; set; }
        public DateTime? PossDate { get; set; }
        public DateTime? DateOfPoss { get; set; }
        public DateTime? ConstOfPenltyDt { get; set; }
        public string? SaleDeedNo { get; set; }
        public string? IntimationCode { get; set; }
        public int? MouzaId { get; set; }
        public string? Phase { get; set; }
        public string? Sector { get; set; }
        public string? Remarks { get; set; }
        public DateTime? PcanDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual IntimationRecord? IntimationCodeNavigation { get; set; }
        public virtual NaTowner? NaTowner { get; set; }
        public virtual PlotStatus? PlotStatus { get; set; }
        public virtual PlotType? PlotType { get; set; }
        public virtual ICollection<Allotment> Allotments { get; set; }
        public virtual ICollection<Challan> Challans { get; set; }
        public virtual ICollection<FilesRecordRoom> FilesRecordRooms { get; set; }
        public virtual ICollection<Issued> Issueds { get; set; }
        public virtual ICollection<JointOwner> JointOwners { get; set; }
        public virtual ICollection<Ndc> Ndcs { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<PlotHistory> PlotHistories { get; set; }
        public virtual ICollection<StampDuty> StampDuties { get; set; }
        public virtual ICollection<TransferCancelHistory> TransferCancelHistories { get; set; }
    }
}
