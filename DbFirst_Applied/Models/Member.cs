using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Member
    {
        public Member()
        {
            AllotmentDetails = new HashSet<AllotmentDetail>();
            Challans = new HashSet<Challan>();
            JointOwners = new HashSet<JointOwner>();
            LegalHires = new HashSet<LegalHire>();
            MemberConversions = new HashSet<MemberConversion>();
            Ndcs = new HashSet<Ndc>();
            Notifications = new HashSet<Notification>();
            PlotHistoryDetails = new HashSet<PlotHistoryDetail>();
            StampDuties = new HashSet<StampDuty>();
        }

        public int MembershipId { get; set; }
        public int? MembershipStatusId { get; set; }
        public string? MembershipNo { get; set; }
        public string? MemberName { get; set; }
        public int? DesignationId { get; set; }
        public int? ForceId { get; set; }
        public int? MembershipTypeId { get; set; }
        public int? ProfessionId { get; set; }
        public string? Gender { get; set; }
        public string? Fname { get; set; }
        public string? Hname { get; set; }
        public DateTime? Dob { get; set; }
        public int? QualificationId { get; set; }
        public string? Cnic { get; set; }
        public int? FprofessionId { get; set; }
        public int? HprofessionId { get; set; }
        public string? DefPerson { get; set; }
        public int? PlotStatusId { get; set; }
        public DateTime? Commdate { get; set; }
        public DateTime? Retdate { get; set; }
        public string? Mobile1 { get; set; }
        public string? PhoneRes1 { get; set; }
        public string? PhoneOffice1 { get; set; }
        public string? PhonePerm1 { get; set; }
        public string? PhonePerm2 { get; set; }
        public decimal? Income { get; set; }
        public string? Nationality { get; set; }
        public string? Relgion { get; set; }
        public string? MailingAddress { get; set; }
        public string? PresentAddress { get; set; }
        public string? PermAddress { get; set; }
        public string? Ntn { get; set; }
        public string? Domicile { get; set; }
        public string? Proposer1 { get; set; }
        public string? Proposer2 { get; set; }
        public string? Email { get; set; }
        public string? MemberFno { get; set; }
        public string? Applicationno { get; set; }
        public DateTime? ApplDate { get; set; }
        public DateTime? Entdate { get; set; }
        public string? MemRemarks { get; set; }
        public string? JobStatus { get; set; }
        public string? ShareNo { get; set; }
        public int? PaTypeId { get; set; }
        public string? FrmNo { get; set; }
        public int? ShaheedRelationId { get; set; }
        public int? DesignationofShaheedId { get; set; }
        public int? ShaheedPaTypeId { get; set; }
        public string? NameOfShaheed { get; set; }
        public DateTime? DtofConf { get; set; }
        public string? CnicTest { get; set; }
        public string? Pano { get; set; }
        public string? ShaheedPano { get; set; }
        public string? PicName { get; set; }
        public bool? Invester { get; set; }
        public bool? LandOwner { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? Active { get; set; }

        public virtual Designation? Designation { get; set; }
        public virtual Designation? DesignationofShaheed { get; set; }
        public virtual Force? Force { get; set; }
        public virtual Profession? Fprofession { get; set; }
        public virtual Profession? Hprofession { get; set; }
        public virtual MembershipStatus? MembershipStatus { get; set; }
        public virtual MembershipType? MembershipType { get; set; }
        public virtual Patype? PaType { get; set; }
        public virtual PlotStatus? PlotStatus { get; set; }
        public virtual Profession? Profession { get; set; }
        public virtual Qualification? Qualification { get; set; }
        public virtual Patype? ShaheedPaType { get; set; }
        public virtual Relation? ShaheedRelation { get; set; }
        public virtual ICollection<AllotmentDetail> AllotmentDetails { get; set; }
        public virtual ICollection<Challan> Challans { get; set; }
        public virtual ICollection<JointOwner> JointOwners { get; set; }
        public virtual ICollection<LegalHire> LegalHires { get; set; }
        public virtual ICollection<MemberConversion> MemberConversions { get; set; }
        public virtual ICollection<Ndc> Ndcs { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<PlotHistoryDetail> PlotHistoryDetails { get; set; }
        public virtual ICollection<StampDuty> StampDuties { get; set; }
    }
}
