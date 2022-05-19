using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbFirst_Applied.Models
{
    public partial class MySMSContext : DbContext
    {
        public MySMSContext()
        {
        }

        public MySMSContext(DbContextOptions<MySMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountBalance> AccountBalances { get; set; } = null!;
        public virtual DbSet<AccountList> AccountLists { get; set; } = null!;
        public virtual DbSet<Allotment> Allotments { get; set; } = null!;
        public virtual DbSet<AllotmentDetail> AllotmentDetails { get; set; } = null!;
        public virtual DbSet<AllotmentType> AllotmentTypes { get; set; } = null!;
        public virtual DbSet<Asset> Assets { get; set; } = null!;
        public virtual DbSet<AssetBranch> AssetBranches { get; set; } = null!;
        public virtual DbSet<AssetCategory> AssetCategories { get; set; } = null!;
        public virtual DbSet<AssetLocation> AssetLocations { get; set; } = null!;
        public virtual DbSet<AssetLog> AssetLogs { get; set; } = null!;
        public virtual DbSet<AssetMaintenance> AssetMaintenances { get; set; } = null!;
        public virtual DbSet<AssetOwnershipType> AssetOwnershipTypes { get; set; } = null!;
        public virtual DbSet<AssetPlaced> AssetPlaceds { get; set; } = null!;
        public virtual DbSet<AssetSubCategory> AssetSubCategories { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<Challan> Challans { get; set; } = null!;
        public virtual DbSet<ChallanChargesDetail> ChallanChargesDetails { get; set; } = null!;
        public virtual DbSet<ChallanChargesType> ChallanChargesTypes { get; set; } = null!;
        public virtual DbSet<ChallanType> ChallanTypes { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Designation> Designations { get; set; } = null!;
        public virtual DbSet<Fiafile> Fiafiles { get; set; } = null!;
        public virtual DbSet<Fiamember> Fiamembers { get; set; } = null!;
        public virtual DbSet<FileIssueingReason> FileIssueingReasons { get; set; } = null!;
        public virtual DbSet<FilesRecordRoom> FilesRecordRooms { get; set; } = null!;
        public virtual DbSet<FinanceNotification> FinanceNotifications { get; set; } = null!;
        public virtual DbSet<FinanceUser> FinanceUsers { get; set; } = null!;
        public virtual DbSet<FinanceUserType> FinanceUserTypes { get; set; } = null!;
        public virtual DbSet<FinancialYear> FinancialYears { get; set; } = null!;
        public virtual DbSet<Force> Forces { get; set; } = null!;
        public virtual DbSet<InboxUser> InboxUsers { get; set; } = null!;
        public virtual DbSet<IntimationRecord> IntimationRecords { get; set; } = null!;
        public virtual DbSet<Issued> Issueds { get; set; } = null!;
        public virtual DbSet<IssuedPerson> IssuedPeople { get; set; } = null!;
        public virtual DbSet<JointOwner> JointOwners { get; set; } = null!;
        public virtual DbSet<Journal> Journals { get; set; } = null!;
        public virtual DbSet<JournalDetail> JournalDetails { get; set; } = null!;
        public virtual DbSet<LandAllotment> LandAllotments { get; set; } = null!;
        public virtual DbSet<LandMember> LandMembers { get; set; } = null!;
        public virtual DbSet<LegalHire> LegalHires { get; set; } = null!;
        public virtual DbSet<Mauza> Mauzas { get; set; } = null!;
        public virtual DbSet<Member> Members { get; set; } = null!;
        public virtual DbSet<MemberConversion> MemberConversions { get; set; } = null!;
        public virtual DbSet<MembershipStatus> MembershipStatuses { get; set; } = null!;
        public virtual DbSet<MembershipType> MembershipTypes { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<MnthOpBlnc> MnthOpBlncs { get; set; } = null!;
        public virtual DbSet<NaTowner> NaTowners { get; set; } = null!;
        public virtual DbSet<Ndc> Ndcs { get; set; } = null!;
        public virtual DbSet<Nok> Noks { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<OpeningBalance> OpeningBalances { get; set; } = null!;
        public virtual DbSet<Party> Parties { get; set; } = null!;
        public virtual DbSet<Patype> Patypes { get; set; } = null!;
        public virtual DbSet<Plot> Plots { get; set; } = null!;
        public virtual DbSet<PlotHistory> PlotHistories { get; set; } = null!;
        public virtual DbSet<PlotHistoryDetail> PlotHistoryDetails { get; set; } = null!;
        public virtual DbSet<PlotStatus> PlotStatuses { get; set; } = null!;
        public virtual DbSet<PlotType> PlotTypes { get; set; } = null!;
        public virtual DbSet<Profession> Professions { get; set; } = null!;
        public virtual DbSet<PropertyDealer> PropertyDealers { get; set; } = null!;
        public virtual DbSet<PurchaserRecord> PurchaserRecords { get; set; } = null!;
        public virtual DbSet<Qualification> Qualifications { get; set; } = null!;
        public virtual DbSet<Rank> Ranks { get; set; } = null!;
        public virtual DbSet<Received> Receiveds { get; set; } = null!;
        public virtual DbSet<Relation> Relations { get; set; } = null!;
        public virtual DbSet<ReportDetail> ReportDetails { get; set; } = null!;
        public virtual DbSet<Signature> Signatures { get; set; } = null!;
        public virtual DbSet<Speciality> Specialities { get; set; } = null!;
        public virtual DbSet<StampDuty> StampDuties { get; set; } = null!;
        public virtual DbSet<SupplierType> SupplierTypes { get; set; } = null!;
        public virtual DbSet<Surveyer> Surveyers { get; set; } = null!;
        public virtual DbSet<TransferAllocation> TransferAllocations { get; set; } = null!;
        public virtual DbSet<TransferCancelHistory> TransferCancelHistories { get; set; } = null!;
        public virtual DbSet<TransferType> TransferTypes { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserDetail> UserDetails { get; set; } = null!;
        public virtual DbSet<VourcherType> VourcherTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
              //  optionsBuilder.UseSqlServer("Server=DESKTOP-LLB501Q; Database=MySMS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountBalance>(entity =>
            {
                entity.ToTable("AccountBalance");

                entity.Property(e => e.AccountClass).HasMaxLength(50);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Diffrence).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.TotalCr).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalDr).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountBalances)
                    .HasForeignKey(d => d.AccountId);
            });

            modelBuilder.Entity<AccountList>(entity =>
            {
                entity.ToTable("AccountList");

                entity.Property(e => e.AccountBalance).HasColumnType("numeric(15, 0)");

                entity.Property(e => e.AccountClass)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountControlL1).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccountControlL2).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccountControlL3).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccountControlL4).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccountControlL5).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccountDays).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.AccountDeprate)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("AccountDEPRate");

                entity.Property(e => e.AccountDepstatus).HasColumnName("AccountDEPStatus");

                entity.Property(e => e.AccountEntryDate).HasColumnType("datetime");

                entity.Property(e => e.AccountHead)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountLlevel)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("AccountLLevel");

                entity.Property(e => e.AccountNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccountOpenBal).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.AccountOpenDate).HasColumnType("datetime");

                entity.Property(e => e.AccountParent).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccountRllimit)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("AccountRLlimit");

                entity.Property(e => e.AccountStatus).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.P1).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P2).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P3).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P4).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P5).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.TotalCr).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDr).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Allotment>(entity =>
            {
                entity.ToTable("Allotment");

                entity.Property(e => e.AllotDate).HasColumnType("datetime");

                entity.Property(e => e.ChallanNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Entdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENTDate");

                entity.Property(e => e.FileRef)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PlotNo)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.AllotType)
                    .WithMany(p => p.Allotments)
                    .HasForeignKey(d => d.AllotTypeId)
                    .HasConstraintName("FK_Allotment_Allotment_AllotmentTypeId");

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.Allotments)
                    .HasForeignKey(d => d.ChallanId);

                entity.HasOne(d => d.Plot)
                    .WithMany(p => p.Allotments)
                    .HasForeignKey(d => d.PlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AllotmentDetail>(entity =>
            {
                entity.ToTable("AllotmentDetail");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Allotment)
                    .WithMany(p => p.AllotmentDetails)
                    .HasForeignKey(d => d.AllotmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Membership)
                    .WithMany(p => p.AllotmentDetails)
                    .HasForeignKey(d => d.MembershipId);
            });

            modelBuilder.Entity<AllotmentType>(entity =>
            {
                entity.ToTable("AllotmentType");

                entity.Property(e => e.AllotmentTypeDisc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cat)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CAT");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.ToTable("Asset");

                entity.Property(e => e.AcuumlatedD).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssetCode).HasMaxLength(10);

                entity.Property(e => e.AssetName).HasMaxLength(50);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateDissP).HasColumnType("datetime");

                entity.Property(e => e.DatePlcS).HasColumnType("datetime");

                entity.Property(e => e.GainLoss).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Images).HasColumnType("image");

                entity.Property(e => e.ImgPath).HasMaxLength(250);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(20);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NetBookValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(20)
                    .HasColumnName("POnumber");

                entity.Property(e => e.Purchasedate).HasColumnType("datetime");

                entity.Property(e => e.SaleProceeds).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalesPayment).HasMaxLength(30);

                entity.Property(e => e.TagCode).HasMaxLength(50);

                entity.HasOne(d => d.Currentlocation)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.CurrentlocationId)
                    .HasConstraintName("FK_Asset_AssetLocation");

                entity.HasOne(d => d.OwnershipType)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.OwnershipTypeId)
                    .HasConstraintName("FK_Asset_AssetOwnershipType_OwnershipId");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.SubCategoryId)
                    .HasConstraintName("FK_Asset_AssetSubCategory_AssetSubCategoryId");
            });

            modelBuilder.Entity<AssetBranch>(entity =>
            {
                entity.ToTable("AssetBranch");

                entity.Property(e => e.BranchCode).HasMaxLength(10);

                entity.Property(e => e.BranchName).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AssetCategory>(entity =>
            {
                entity.ToTable("AssetCategory");

                entity.Property(e => e.CategoryCode).HasMaxLength(5);

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AssetLocation>(entity =>
            {
                entity.ToTable("AssetLocation");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LocationCode).HasMaxLength(10);

                entity.Property(e => e.LocationName).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.AssetLocations)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_AssetLocation_AssetBranch_AssetBranchId");
            });

            modelBuilder.Entity<AssetLog>(entity =>
            {
                entity.ToTable("AssetLog");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DepAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DisposalDate).HasColumnType("datetime");

                entity.Property(e => e.FinancialDate).HasColumnType("datetime");

                entity.Property(e => e.Nbv)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("NBV");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetLogs)
                    .HasForeignKey(d => d.AssetId);
            });

            modelBuilder.Entity<AssetMaintenance>(entity =>
            {
                entity.ToTable("AssetMaintenance");

                entity.Property(e => e.Charges).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MaintenanceDate).HasColumnType("datetime");

                entity.Property(e => e.MaintenanceType).HasMaxLength(150);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetMaintenances)
                    .HasForeignKey(d => d.AssetId);
            });

            modelBuilder.Entity<AssetOwnershipType>(entity =>
            {
                entity.ToTable("AssetOwnershipType");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<AssetPlaced>(entity =>
            {
                entity.ToTable("AssetPlaced");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.TransfarDate).HasColumnType("datetime");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetPlaceds)
                    .HasForeignKey(d => d.AssetId);

                entity.HasOne(d => d.NewLocation)
                    .WithMany(p => p.AssetPlacedNewLocations)
                    .HasForeignKey(d => d.NewLocationId)
                    .HasConstraintName("FK_AssetPlaced_AssetLocation_AssetNewLocation");

                entity.HasOne(d => d.OldLocation)
                    .WithMany(p => p.AssetPlacedOldLocations)
                    .HasForeignKey(d => d.OldLocationId)
                    .HasConstraintName("FK_AssetPlaced_AssetLocation_AssetOldLocationId");
            });

            modelBuilder.Entity<AssetSubCategory>(entity =>
            {
                entity.ToTable("AssetSubCategory");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.SubCategoryCode).HasMaxLength(5);

                entity.Property(e => e.SubCategoryName).HasMaxLength(100);

                entity.HasOne(d => d.MainCategory)
                    .WithMany(p => p.AssetSubCategories)
                    .HasForeignKey(d => d.MainCategoryId);
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("Bank");

                entity.Property(e => e.AccountNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BankName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Challan>(entity =>
            {
                entity.ToTable("Challan");

                entity.Property(e => e.ChallanMno)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ChallanMNo");

                entity.Property(e => e.ChallanNo).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ChallanTypeId).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ChallanYmvno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ChallanYMVNo");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Ctid).HasColumnName("CTID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DocBank).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.JrvId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.JrvNo).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MemberName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MembershipNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Paid)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PhistId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("phistId");

                entity.Property(e => e.RecitId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.TransType).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.VoType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("VO_Type");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Challans)
                    .HasForeignKey(d => d.BankId);

                entity.HasOne(d => d.Membership)
                    .WithMany(p => p.Challans)
                    .HasForeignKey(d => d.MembershipId);

                entity.HasOne(d => d.Plot)
                    .WithMany(p => p.Challans)
                    .HasForeignKey(d => d.PlotId);
            });

            modelBuilder.Entity<ChallanChargesDetail>(entity =>
            {
                entity.ToTable("ChallanChargesDetail");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ChallanCharges)
                    .WithMany(p => p.ChallanChargesDetails)
                    .HasForeignKey(d => d.ChallanChargesId);

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.ChallanChargesDetails)
                    .HasForeignKey(d => d.ChallanId);
            });

            modelBuilder.Entity<ChallanChargesType>(entity =>
            {
                entity.ToTable("ChallanChargesType");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ChallanCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanDecp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccountCode)
                    .WithMany(p => p.ChallanChargesTypes)
                    .HasForeignKey(d => d.AccountCodeId)
                    .HasConstraintName("FK_ChallanChargesType_AccountList_AccountId");

                entity.HasOne(d => d.ChallanType)
                    .WithMany(p => p.ChallanChargesTypes)
                    .HasForeignKey(d => d.ChallanTypeId)
                    .HasConstraintName("FK_ChallanChargesType_ChallanType");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.ChallanChargesTypes)
                    .HasForeignKey(d => d.DepartmentId);
            });

            modelBuilder.Entity<ChallanType>(entity =>
            {
                entity.ToTable("ChallanType");

                entity.Property(e => e.ChallanDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.BranchAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.BranchEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchFax)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BranchPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.ToTable("Designation");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RankDescp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.RankType)
                    .WithMany(p => p.Designations)
                    .HasForeignKey(d => d.RankTypeId)
                    .HasConstraintName("FK_Designation_Rank");
            });

            modelBuilder.Entity<Fiafile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FIAFile");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.IssueNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PlotNO");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fiamember>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FIAMember");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.NewNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FileIssueingReason>(entity =>
            {
                entity.ToTable("FileIssueingReason");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<FilesRecordRoom>(entity =>
            {
                entity.ToTable("FilesRecordRoom");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ShelfName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShelfPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Plot)
                    .WithMany(p => p.FilesRecordRooms)
                    .HasForeignKey(d => d.PlotId)
                    .HasConstraintName("FK_FilesRecordRoom_Plot");
            });

            modelBuilder.Entity<FinanceNotification>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Text).IsUnicode(false);
            });

            modelBuilder.Entity<FinanceUser>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserType).HasMaxLength(50);
            });

            modelBuilder.Entity<FinanceUserType>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<FinancialYear>(entity =>
            {
                entity.ToTable("FinancialYear");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Pl).HasColumnName("PL");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Tr).HasColumnName("TR");

                entity.Property(e => e.Wt).HasColumnName("WT");

                entity.Property(e => e.Year).HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<Force>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ForceName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<InboxUser>(entity =>
            {
                entity.ToTable("InboxUser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<IntimationRecord>(entity =>
            {
                entity.ToTable("IntimationRecord");

                entity.Property(e => e.AffidavitNo).HasMaxLength(20);

                entity.Property(e => e.AllocationDate).HasColumnType("datetime");

                entity.Property(e => e.ApplicationNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Chno)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CHNO");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DealNo).HasMaxLength(50);

                entity.Property(e => e.ImagePath).HasColumnType("image");

                entity.Property(e => e.IntimationCode).HasMaxLength(20);

                entity.Property(e => e.IntimationDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Phase)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PlotNo)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.SaleDeedNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sqft)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SQFT");
            });

            modelBuilder.Entity<Issued>(entity =>
            {
                entity.ToTable("Issued");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IssuedDate).HasColumnType("date");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Issueds)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.Plot)
                    .WithMany(p => p.Issueds)
                    .HasForeignKey(d => d.PlotId);

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.Issueds)
                    .HasForeignKey(d => d.ReasonId);
            });

            modelBuilder.Entity<IssuedPerson>(entity =>
            {
                entity.ToTable("IssuedPerson");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.IssuedPeople)
                    .HasForeignKey(d => d.DepartmentId);
            });

            modelBuilder.Entity<JointOwner>(entity =>
            {
                entity.ToTable("JointOwner");

                entity.Property(e => e.LetterNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.JointOwners)
                    .HasForeignKey(d => d.MemberId);

                entity.HasOne(d => d.Plot)
                    .WithMany(p => p.JointOwners)
                    .HasForeignKey(d => d.PlotId);
            });

            modelBuilder.Entity<Journal>(entity =>
            {
                entity.ToTable("Journal");

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CheckNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Fyear).HasColumnName("FYear");

                entity.Property(e => e.JrentryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JREntryDate");

                entity.Property(e => e.JrmonthVoucherNo).HasColumnName("JRMonthVoucherNo");

                entity.Property(e => e.JrtransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JRTransactionDate");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.MonthToCompare).HasMaxLength(50);

                entity.Property(e => e.PaidTo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Journals)
                    .HasForeignKey(d => d.BankId);

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.Journals)
                    .HasForeignKey(d => d.ChallanId);

                entity.HasOne(d => d.VoucherType)
                    .WithMany(p => p.Journals)
                    .HasForeignKey(d => d.VoucherTypeId);
            });

            modelBuilder.Entity<JournalDetail>(entity =>
            {
                entity.ToTable("JournalDetail");

                entity.Property(e => e.Brcode)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("BRcode");

                entity.Property(e => e.Jrcfno)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("JRCFNO");

                entity.Property(e => e.Jrcr).HasColumnName("JRCr");

                entity.Property(e => e.Jrdr).HasColumnName("JRDr");

                entity.Property(e => e.JrentryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JREntryDate");

                entity.Property(e => e.Jrparticular)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("JRParticular");

                entity.Property(e => e.SubHeadId).HasColumnType("numeric(5, 0)");

                entity.HasOne(d => d.AccountNo)
                    .WithMany(p => p.JournalDetails)
                    .HasForeignKey(d => d.AccountNoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JournalDetail_AccountList");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.JournalDetails)
                    .HasForeignKey(d => d.JournalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JournalDetail_JournalDetail_JournalId");
            });

            modelBuilder.Entity<LandAllotment>(entity =>
            {
                entity.ToTable("LandAllotment");

                entity.Property(e => e.AffidavitNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Chno)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CHNO");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IntimationCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LandOwner)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MauzaId)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("MauzaID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Phase)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PicPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlotNo)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaserAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaserFather)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.SaleDeedNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LandMember>(entity =>
            {
                entity.HasKey(e => e.LndMemId);

                entity.Property(e => e.LndMemId).HasColumnName("LndMemID");

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EntDate).HasColumnType("datetime");

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.Hname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HName");

                entity.Property(e => e.LndMemNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NicNew)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NicOld)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.PicPath)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<LegalHire>(entity =>
            {
                entity.ToTable("LegalHire");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Entdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENTDATE");

                entity.Property(e => e.LegalHireName)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.LegalHireNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.LegalHires)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_legalHire_Member_MemberId");

                entity.HasOne(d => d.Relation)
                    .WithMany(p => p.LegalHires)
                    .HasForeignKey(d => d.RelationId)
                    .HasConstraintName("FK_legalHire_Relation_RelationId");
            });

            modelBuilder.Entity<Mauza>(entity =>
            {
                entity.ToTable("Mauza");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasKey(e => e.MembershipId);

                entity.ToTable("Member");

                entity.Property(e => e.ApplDate).HasColumnType("datetime");

                entity.Property(e => e.Applicationno).HasMaxLength(20);

                entity.Property(e => e.Cnic)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("CNIC");

                entity.Property(e => e.CnicTest)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Commdate)
                    .HasColumnType("datetime")
                    .HasColumnName("COMMDate");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DefPerson)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Domicile)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DtofConf).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Entdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENTDATE");

                entity.Property(e => e.Fname)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.FprofessionId).HasColumnName("FProfessionId");

                entity.Property(e => e.FrmNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Hname)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("HName");

                entity.Property(e => e.HprofessionId).HasColumnName("HProfessionId");

                entity.Property(e => e.Income).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.JobStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.MemRemarks)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MemberFno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MemberFNO");

                entity.Property(e => e.MemberName)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.MembershipNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NameOfShaheed)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ntn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NTN");

                entity.Property(e => e.Pano)
                    .HasMaxLength(15)
                    .HasColumnName("PANo");

                entity.Property(e => e.PermAddress)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneOffice1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PhonePerm1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PhonePerm2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneRes1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PicName).IsUnicode(false);

                entity.Property(e => e.PresentAddress)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Proposer1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Proposer2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Relgion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Retdate)
                    .HasColumnType("datetime")
                    .HasColumnName("RETDate");

                entity.Property(e => e.ShaheedPano)
                    .HasMaxLength(15)
                    .HasColumnName("ShaheedPANo");

                entity.Property(e => e.ShareNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.MemberDesignations)
                    .HasForeignKey(d => d.DesignationId);

                entity.HasOne(d => d.DesignationofShaheed)
                    .WithMany(p => p.MemberDesignationofShaheeds)
                    .HasForeignKey(d => d.DesignationofShaheedId);

                entity.HasOne(d => d.Force)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.ForceId);

                entity.HasOne(d => d.Fprofession)
                    .WithMany(p => p.MemberFprofessions)
                    .HasForeignKey(d => d.FprofessionId);

                entity.HasOne(d => d.Hprofession)
                    .WithMany(p => p.MemberHprofessions)
                    .HasForeignKey(d => d.HprofessionId);

                entity.HasOne(d => d.MembershipStatus)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.MembershipStatusId);

                entity.HasOne(d => d.MembershipType)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.MembershipTypeId);

                entity.HasOne(d => d.PaType)
                    .WithMany(p => p.MemberPaTypes)
                    .HasForeignKey(d => d.PaTypeId)
                    .HasConstraintName("FK_Member_PAType_PANo");

                entity.HasOne(d => d.PlotStatus)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.PlotStatusId);

                entity.HasOne(d => d.Profession)
                    .WithMany(p => p.MemberProfessions)
                    .HasForeignKey(d => d.ProfessionId);

                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.QualificationId);

                entity.HasOne(d => d.ShaheedPaType)
                    .WithMany(p => p.MemberShaheedPaTypes)
                    .HasForeignKey(d => d.ShaheedPaTypeId)
                    .HasConstraintName("FK_Member_PAType_ShaheedPaType");

                entity.HasOne(d => d.ShaheedRelation)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.ShaheedRelationId);
            });

            modelBuilder.Entity<MemberConversion>(entity =>
            {
                entity.ToTable("MemberConversion");

                entity.Property(e => e.ConversionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NewMember)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OldMember)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.Membe)
                    .WithMany(p => p.MemberConversions)
                    .HasForeignKey(d => d.MembeId)
                    .HasConstraintName("FK_MemberConversion_Member_MemberId");
            });

            modelBuilder.Entity<MembershipStatus>(entity =>
            {
                entity.ToTable("MembershipStatus");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MemStatus)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<MembershipType>(entity =>
            {
                entity.ToTable("MembershipType");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MemType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Text).HasMaxLength(200);

                entity.HasOne(d => d.SentFromNavigation)
                    .WithMany(p => p.MessageSentFromNavigations)
                    .HasForeignKey(d => d.SentFrom)
                    .HasConstraintName("FK_Messages_InboxUser");

                entity.HasOne(d => d.SentToNavigation)
                    .WithMany(p => p.MessageSentToNavigations)
                    .HasForeignKey(d => d.SentTo)
                    .HasConstraintName("FK_Messages_InboxUser1");
            });

            modelBuilder.Entity<MnthOpBlnc>(entity =>
            {
                entity.ToTable("MnthOpBlnc");

                entity.Property(e => e.AccountNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Obalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OBalance");

                entity.HasOne(d => d.Year)
                    .WithMany(p => p.MnthOpBlncs)
                    .HasForeignKey(d => d.YearId)
                    .HasConstraintName("FK_MnthOpBlnc_FinancialYear");
            });

            modelBuilder.Entity<NaTowner>(entity =>
            {
                entity.ToTable("NaTowner");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NowDisc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ndc>(entity =>
            {
                entity.ToTable("NDC");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FeedBack)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForwardTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Ndcapplydate)
                    .HasColumnType("datetime")
                    .HasColumnName("NDCApplydate");

                entity.Property(e => e.Ndcduedate)
                    .HasColumnType("datetime")
                    .HasColumnName("NDCDuedate");

                entity.Property(e => e.Ndcissued).HasColumnName("NDCissued");

                entity.Property(e => e.Ndcissueddate)
                    .HasColumnType("datetime")
                    .HasColumnName("NDCIssueddate");

                entity.Property(e => e.Ndcno)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("NDCNo");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Membership)
                    .WithMany(p => p.Ndcs)
                    .HasForeignKey(d => d.Membershipid);

                entity.HasOne(d => d.Plot)
                    .WithMany(p => p.Ndcs)
                    .HasForeignKey(d => d.Plotid);
            });

            modelBuilder.Entity<Nok>(entity =>
            {
                entity.ToTable("NOK");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Entdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENTDATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NokName)
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("NOkName");

                entity.Property(e => e.NokNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("Notification");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Title).IsUnicode(false);

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.ChallanId);

                entity.HasOne(d => d.Membership)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.MembershipId);

                entity.HasOne(d => d.Plot)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.PlotId);
            });

            modelBuilder.Entity<OpeningBalance>(entity =>
            {
                entity.ToTable("OpeningBalance");

                entity.Property(e => e.AccountNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Party>(entity =>
            {
                entity.Property(e => e.AccountNo).HasMaxLength(15);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Cnic).HasMaxLength(15);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(15);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.HasOne(d => d.SupplierType)
                    .WithMany(p => p.Parties)
                    .HasForeignKey(d => d.SupplierTypeId)
                    .HasConstraintName("FK_Parties_SupplierTypes");
            });

            modelBuilder.Entity<Patype>(entity =>
            {
                entity.ToTable("PAType");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.TypeName).HasMaxLength(20);
            });

            modelBuilder.Entity<Plot>(entity =>
            {
                entity.ToTable("Plot");

                entity.Property(e => e.Caution)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ConstOfPenltyDt).HasColumnType("datetime");

                entity.Property(e => e.Cornor)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CoverArea)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfPoss).HasColumnType("datetime");

                entity.Property(e => e.DatePurchase).HasColumnType("datetime");

                entity.Property(e => e.Entdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENTDate");

                entity.Property(e => e.FileRef)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HouseComp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HouseCompDate).HasColumnType("datetime");

                entity.Property(e => e.IntimationCode).HasMaxLength(20);

                entity.Property(e => e.Kanal)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LandOwner)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Marla)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Mortgage)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PcanDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PCanDate");

                entity.Property(e => e.Phase)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlotNo)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.PossDate).HasColumnType("datetime");

                entity.Property(e => e.Possession)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Registred)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SaleDeedNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SecChrgDate).HasColumnType("datetime");

                entity.Property(e => e.Sector)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.Property(e => e.Sqft)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SwrgOpDate).HasColumnType("datetime");

                entity.Property(e => e.WtrOpDate).HasColumnType("datetime");

                entity.HasOne(d => d.IntimationCodeNavigation)
                    .WithMany(p => p.Plots)
                    .HasForeignKey(d => d.IntimationCodeId)
                    .HasConstraintName("FK_Plot_IntimationRecord_IntimationId");

                entity.HasOne(d => d.NaTowner)
                    .WithMany(p => p.Plots)
                    .HasForeignKey(d => d.NaTownerId);

                entity.HasOne(d => d.PlotStatus)
                    .WithMany(p => p.Plots)
                    .HasForeignKey(d => d.PlotStatusId);

                entity.HasOne(d => d.PlotType)
                    .WithMany(p => p.Plots)
                    .HasForeignKey(d => d.PlotTypeId);
            });

            modelBuilder.Entity<PlotHistory>(entity =>
            {
                entity.ToTable("PlotHistory");

                entity.Property(e => e.BuyDate).HasColumnType("datetime");

                entity.Property(e => e.Cbtax)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CBtax");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustId).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.DocRcvdDate).HasColumnType("datetime");

                entity.Property(e => e.Entdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENTDate");

                entity.Property(e => e.Kanal)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ltrdeliverdate).HasColumnType("datetime");

                entity.Property(e => e.Ltrno)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ltrreadydate).HasColumnType("datetime");

                entity.Property(e => e.Marla)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Ndcno)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("NDCno");

                entity.Property(e => e.PostUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Regno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SellingDate).HasColumnType("datetime");

                entity.Property(e => e.Siteplanno).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Spltamgl)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sqft)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SQFT");

                entity.Property(e => e.StampDuty).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Allotment)
                    .WithMany(p => p.PlotHistories)
                    .HasForeignKey(d => d.AllotmentId)
                    .HasConstraintName("FK_PlotHistory_Allotment");

                entity.HasOne(d => d.Plot)
                    .WithMany(p => p.PlotHistories)
                    .HasForeignKey(d => d.PlotId);

                entity.HasOne(d => d.TransType)
                    .WithMany(p => p.PlotHistories)
                    .HasForeignKey(d => d.TransTypeId);
            });

            modelBuilder.Entity<PlotHistoryDetail>(entity =>
            {
                entity.ToTable("PlotHistoryDetail");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Allotment)
                    .WithMany(p => p.PlotHistoryDetails)
                    .HasForeignKey(d => d.AllotmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlotHistoryDetail_Allotment");

                entity.HasOne(d => d.Membership)
                    .WithMany(p => p.PlotHistoryDetails)
                    .HasForeignKey(d => d.MembershipId)
                    .HasConstraintName("FK_PlotHistoryDetail_Member_MemberId");

                entity.HasOne(d => d.PlotHistory)
                    .WithMany(p => p.PlotHistoryDetails)
                    .HasForeignKey(d => d.PlotHistoryId);
            });

            modelBuilder.Entity<PlotStatus>(entity =>
            {
                entity.ToTable("PlotStatus");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PlotStatusName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlotType>(entity =>
            {
                entity.ToTable("PlotType");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PlotDisc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlotId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profession>(entity =>
            {
                entity.ToTable("Profession");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Profession1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Profession");
            });

            modelBuilder.Entity<PropertyDealer>(entity =>
            {
                entity.ToTable("PropertyDealer");

                entity.Property(e => e.AcNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IncTaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STaxNo");

                entity.Property(e => e.Zip)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaserRecord>(entity =>
            {
                entity.ToTable("PurchaserRecord");

                entity.Property(e => e.CellNo)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Pcnic)
                    .HasMaxLength(20)
                    .HasColumnName("PCnic");

                entity.Property(e => e.PfatherName)
                    .HasMaxLength(50)
                    .HasColumnName("PFatherName");

                entity.Property(e => e.PicPath).IsUnicode(false);

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .HasColumnName("PName");

                entity.Property(e => e.Prelation)
                    .HasMaxLength(10)
                    .HasColumnName("PRelation");

                entity.HasOne(d => d.IntimationRedcord)
                    .WithMany(p => p.PurchaserRecords)
                    .HasForeignKey(d => d.IntimationRedcordId)
                    .HasConstraintName("FK_PurcherRecord_intimationRecord");
            });

            modelBuilder.Entity<Qualification>(entity =>
            {
                entity.ToTable("Qualification");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Education)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Rank>(entity =>
            {
                entity.ToTable("Rank");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RankType).HasMaxLength(255);
            });

            modelBuilder.Entity<Received>(entity =>
            {
                entity.ToTable("Received");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Reamrks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Relation>(entity =>
            {
                entity.ToTable("Relation");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RelationName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportDetail>(entity =>
            {
                entity.ToTable("ReportDetail");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Signature>(entity =>
            {
                entity.ToTable("Signature");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Design)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Rank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Signature1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Signature");
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.ToTable("Speciality");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StampDuty>(entity =>
            {
                entity.ToTable("StampDuty");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CurrTransDate).HasColumnType("datetime");

                entity.Property(e => e.Cvt).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Phistid).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StampDuty1)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("StampDuty");

                entity.Property(e => e.TreasuryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Treasury_Date");

                entity.Property(e => e.TreasuryNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Treasury_No");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.StampDuties)
                    .HasForeignKey(d => d.MemberId);

                entity.HasOne(d => d.Plot)
                    .WithMany(p => p.StampDuties)
                    .HasForeignKey(d => d.Plotid)
                    .HasConstraintName("FK_StampDuty_Plot_PlotId");
            });

            modelBuilder.Entity<SupplierType>(entity =>
            {
                entity.Property(e => e.SupplierType1)
                    .HasMaxLength(50)
                    .HasColumnName("SupplierType");
            });

            modelBuilder.Entity<Surveyer>(entity =>
            {
                entity.ToTable("Surveyer");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.SurveyerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransferAllocation>(entity =>
            {
                entity.ToTable("TransferAllocation");

                entity.Property(e => e.AllocationDate).HasColumnType("datetime");

                entity.Property(e => e.Chno)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CHNO");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Allotment)
                    .WithMany(p => p.TransferAllocations)
                    .HasForeignKey(d => d.AllotmentId);
            });

            modelBuilder.Entity<TransferCancelHistory>(entity =>
            {
                entity.ToTable("TransferCancelHistory");

                entity.Property(e => e.CancelRemarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Transdate).HasColumnType("datetime");

                entity.HasOne(d => d.Plot)
                    .WithMany(p => p.TransferCancelHistories)
                    .HasForeignKey(d => d.PlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TransferType)
                    .WithMany(p => p.TransferCancelHistories)
                    .HasForeignKey(d => d.TransferTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TransferType>(entity =>
            {
                entity.ToTable("TransferType");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.TransferDisc)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empid).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ImagePath).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tout)
                    .HasColumnType("datetime")
                    .HasColumnName("TOut");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.ToTable("UserDetail");

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(4, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RtType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserRight)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VourcherType>(entity =>
            {
                entity.ToTable("VourcherType");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Vdescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Vremarks)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VRemarks");

                entity.Property(e => e.Vstatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VStatus");

                entity.Property(e => e.Vtype)
                    .HasMaxLength(50)
                    .HasColumnName("VType");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
