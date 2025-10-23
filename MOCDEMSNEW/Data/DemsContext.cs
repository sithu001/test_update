using System;
using System.Collections.Generic;
using MOCDEMSNEW.Models;
using Microsoft.EntityFrameworkCore;

namespace MOCDEMSNEW.Data;

public partial class DemsContext : DbContext
{
    public DemsContext()
    {
    }

    public DemsContext(DbContextOptions<DemsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alert> Alerts { get; set; }

    public virtual DbSet<ArcRepCat> ArcRepCats { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeTwoFactor> EmployeeTwoFactors { get; set; }

    public virtual DbSet<EmployeesQry> EmployeesQries { get; set; }

    public virtual DbSet<FavFolder> FavFolders { get; set; }

    public virtual DbSet<Favorite> Favorites { get; set; }

    public virtual DbSet<FileManager> FileManagers { get; set; }

    public virtual DbSet<FileManagerMain> FileManagerMains { get; set; }

    public virtual DbSet<FileManagerQry> FileManagerQries { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Mail> Mails { get; set; }

    public virtual DbSet<MeetingAnnouncer> MeetingAnnouncers { get; set; }

    public virtual DbSet<MeetingGuest> MeetingGuests { get; set; }

    public virtual DbSet<MeetingRegister> MeetingRegisters { get; set; }

    public virtual DbSet<MeetingType> MeetingTypes { get; set; }

    public virtual DbSet<MinuteSheet> MinuteSheets { get; set; }

    public virtual DbSet<Month> Months { get; set; }

    public virtual DbSet<MsheetRmk> MsheetRmks { get; set; }

    public virtual DbSet<NoteSheet> NoteSheets { get; set; }

    public virtual DbSet<Nsfolder> Nsfolders { get; set; }

    public virtual DbSet<NsremarkType> NsremarkTypes { get; set; }

    public virtual DbSet<NsshareUser> NsshareUsers { get; set; }

    public virtual DbSet<Nstransaction> Nstransactions { get; set; }

    public virtual DbSet<Nsuser> Nsusers { get; set; }

    public virtual DbSet<OfficeLRemark> OfficeLRemarks { get; set; }

    public virtual DbSet<OfficeLetter> OfficeLetters { get; set; }

    public virtual DbSet<OfficeLetterRemark> OfficeLetterRemarks { get; set; }

    public virtual DbSet<OfficeLetterV2> OfficeLetterV2s { get; set; }

    public virtual DbSet<OlRegQry> OlRegQries { get; set; }

    public virtual DbSet<Olcat> Olcats { get; set; }

    public virtual DbSet<Olfolder> Olfolders { get; set; }

    public virtual DbSet<Olforward> Olforwards { get; set; }

    public virtual DbSet<Olinboxoutbox> Olinboxoutboxes { get; set; }

    public virtual DbSet<Oliofolder> Oliofolders { get; set; }

    public virtual DbSet<Olno> Olnos { get; set; }

    public virtual DbSet<Olread> Olreads { get; set; }

    public virtual DbSet<Olreg> Olregs { get; set; }

    public virtual DbSet<Olshare> Olshares { get; set; }

    public virtual DbSet<Olstep> Olsteps { get; set; }

    public virtual DbSet<Oltype> Oltypes { get; set; }

    public virtual DbSet<Oluser> Olusers { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Rep> Reps { get; set; }

    public virtual DbSet<RepCat> RepCats { get; set; }

    public virtual DbSet<RepCatOldVersion16Feb13> RepCatOldVersion16Feb13s { get; set; }

    public virtual DbSet<RepOldVersion16Feb13> RepOldVersion16Feb13s { get; set; }

    public virtual DbSet<RepQry> RepQries { get; set; }

    public virtual DbSet<RepRemark> RepRemarks { get; set; }

    public virtual DbSet<RepRemarkCategory> RepRemarkCategories { get; set; }

    public virtual DbSet<RepRemarkCategoryOldVersion16Feb13> RepRemarkCategoryOldVersion16Feb13s { get; set; }

    public virtual DbSet<RepRemarkOldVersion16Feb13> RepRemarkOldVersion16Feb13s { get; set; }

    public virtual DbSet<RepRemarkQry> RepRemarkQries { get; set; }

    public virtual DbSet<RepRemarkType> RepRemarkTypes { get; set; }

    public virtual DbSet<RepRemarkTypeOldVersion16Feb13> RepRemarkTypeOldVersion16Feb13s { get; set; }

    public virtual DbSet<RepRemarkTypebk> RepRemarkTypebks { get; set; }

    public virtual DbSet<RepShare> RepShares { get; set; }

    public virtual DbSet<RepShareOldVersion16Feb13> RepShareOldVersion16Feb13s { get; set; }

    public virtual DbSet<RepTran> RepTrans { get; set; }

    public virtual DbSet<RepTranOldVersion16Feb13> RepTranOldVersion16Feb13s { get; set; }

    public virtual DbSet<RepUser> RepUsers { get; set; }

    public virtual DbSet<RepUsersOldVersion16Feb13> RepUsersOldVersion16Feb13s { get; set; }

    public virtual DbSet<ReportHead> ReportHeads { get; set; }

    public virtual DbSet<ReportHeadOldVersion16Feb13> ReportHeadOldVersion16Feb13s { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    public virtual DbSet<SubSection> SubSections { get; set; }

    public virtual DbSet<SysLink> SysLinks { get; set; }

    public virtual DbSet<Tduser> Tdusers { get; set; }

    public virtual DbSet<Text> Texts { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    public virtual DbSet<UserLevel> UserLevels { get; set; }

    public virtual DbSet<Venue> Venues { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=IM;Database=DEMS;Integrated Security=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alert>(entity =>
        {
            entity.HasKey(e => e.AId).HasName("PK__Alerts__46E78A0C");

            entity.Property(e => e.AId).HasColumnName("A_ID");
            entity.Property(e => e.AAlerted).HasColumnName("A_Alerted");
            entity.Property(e => e.ADateTime)
                .HasColumnType("datetime")
                .HasColumnName("A_DateTime");
            entity.Property(e => e.AItem).HasColumnName("A_Item");
            entity.Property(e => e.AItemId).HasColumnName("A_ItemID");
            entity.Property(e => e.ANote)
                .HasColumnType("ntext")
                .HasColumnName("A_Note");
            entity.Property(e => e.AOwner).HasColumnName("A_Owner");
            entity.Property(e => e.ASender).HasColumnName("A_Sender");
        });

        modelBuilder.Entity<ArcRepCat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Arc_RepCat");

            entity.Property(e => e.RcDepartment).HasColumnName("RC_Department");
            entity.Property(e => e.RcId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RC_ID");
            entity.Property(e => e.RcIsArchive).HasColumnName("RC_IsArchive");
            entity.Property(e => e.RcName)
                .HasColumnType("ntext")
                .HasColumnName("RC_Name");
            entity.Property(e => e.RcSection).HasColumnName("RC_Section");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DId).HasName("PK__Departments__1920BF5C");

            entity.Property(e => e.DId).HasColumnName("D_ID");
            entity.Property(e => e.DMname)
                .HasMaxLength(500)
                .HasColumnName("D_MName");
            entity.Property(e => e.DName)
                .HasMaxLength(125)
                .HasColumnName("D_Name");
            entity.Property(e => e.DPhoneExt)
                .HasMaxLength(125)
                .HasColumnName("D_PhoneExt");
            entity.Property(e => e.DSname)
                .HasMaxLength(125)
                .HasColumnName("D_SName");
            entity.Property(e => e.DSname2)
                .HasMaxLength(500)
                .HasColumnName("D_SName2");
            entity.Property(e => e.DSortOrder).HasColumnName("D_SortOrder");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("emp");

            entity.Property(e => e.EActive).HasColumnName("E_Active");
            entity.Property(e => e.EAddr1)
                .HasMaxLength(125)
                .HasColumnName("E_Addr1");
            entity.Property(e => e.EAddr2)
                .HasMaxLength(125)
                .HasColumnName("E_Addr2");
            entity.Property(e => e.EAddr3)
                .HasMaxLength(125)
                .HasColumnName("E_Addr3");
            entity.Property(e => e.EAddr4)
                .HasMaxLength(125)
                .HasColumnName("E_Addr4");
            entity.Property(e => e.ECategories).HasColumnName("E_Categories");
            entity.Property(e => e.ECreateDate)
                .HasColumnType("datetime")
                .HasColumnName("E_CreateDate");
            entity.Property(e => e.EDepartment).HasColumnName("E_Department");
            entity.Property(e => e.EDutyCategory).HasColumnName("E_DutyCategory");
            entity.Property(e => e.EEditDate)
                .HasColumnType("datetime")
                .HasColumnName("E_EditDate");
            entity.Property(e => e.EEmail)
                .HasMaxLength(125)
                .HasColumnName("E_Email");
            entity.Property(e => e.EFullname)
                .HasMaxLength(125)
                .HasColumnName("E_Fullname");
            entity.Property(e => e.EGender).HasColumnName("E_Gender");
            entity.Property(e => e.EHeadRank).HasColumnName("E_HeadRank");
            entity.Property(e => e.EId)
                .ValueGeneratedOnAdd()
                .HasColumnName("E_ID");
            entity.Property(e => e.EIsAdmin).HasColumnName("E_IsAdmin");
            entity.Property(e => e.EIsHead).HasColumnName("E_IsHead");
            entity.Property(e => e.ELevel).HasColumnName("E_Level");
            entity.Property(e => e.EMobile)
                .HasMaxLength(125)
                .HasColumnName("E_Mobile");
            entity.Property(e => e.EName)
                .HasMaxLength(125)
                .HasColumnName("E_Name");
            entity.Property(e => e.ENo).HasColumnName("E_No");
            entity.Property(e => e.ENotes)
                .HasColumnType("ntext")
                .HasColumnName("E_Notes");
            entity.Property(e => e.EPassword)
                .HasMaxLength(125)
                .HasColumnName("E_Password");
            entity.Property(e => e.EPhone)
                .HasMaxLength(125)
                .HasColumnName("E_Phone");
            entity.Property(e => e.EPhoneExt)
                .HasMaxLength(125)
                .HasColumnName("E_PhoneExt");
            entity.Property(e => e.EPosition).HasColumnName("E_Position");
            entity.Property(e => e.EProfession).HasColumnName("E_Profession");
            entity.Property(e => e.ERank).HasColumnName("E_Rank");
            entity.Property(e => e.ERepType).HasColumnName("E_RepType");
            entity.Property(e => e.ESection).HasColumnName("E_Section");
            entity.Property(e => e.ESignature)
                .HasMaxLength(50)
                .HasColumnName("E_Signature");
            entity.Property(e => e.EStartDate)
                .HasColumnType("datetime")
                .HasColumnName("E_StartDate");
            entity.Property(e => e.ESubSection).HasColumnName("E_SubSection");
            entity.Property(e => e.ETitle)
                .HasMaxLength(125)
                .HasColumnName("E_Title");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EId);

            entity.Property(e => e.EId).HasColumnName("E_ID");
            entity.Property(e => e.EActive).HasColumnName("E_Active");
            entity.Property(e => e.EAddr1)
                .HasMaxLength(125)
                .HasColumnName("E_Addr1");
            entity.Property(e => e.EAddr2)
                .HasMaxLength(125)
                .HasColumnName("E_Addr2");
            entity.Property(e => e.EAddr3)
                .HasMaxLength(125)
                .HasColumnName("E_Addr3");
            entity.Property(e => e.EAddr4)
                .HasMaxLength(125)
                .HasColumnName("E_Addr4");
            entity.Property(e => e.ECategories).HasColumnName("E_Categories");
            entity.Property(e => e.ECreateDate)
                .HasColumnType("datetime")
                .HasColumnName("E_CreateDate");
            entity.Property(e => e.EDepartment).HasColumnName("E_Department");
            entity.Property(e => e.EDutyCategory).HasColumnName("E_DutyCategory");
            entity.Property(e => e.EEditDate)
                .HasColumnType("datetime")
                .HasColumnName("E_EditDate");
            entity.Property(e => e.EEmail)
                .HasMaxLength(125)
                .HasColumnName("E_Email");
            entity.Property(e => e.EFullname)
                .HasMaxLength(125)
                .HasColumnName("E_Fullname");
            entity.Property(e => e.EGender).HasColumnName("E_Gender");
            entity.Property(e => e.EHeadRank).HasColumnName("E_HeadRank");
            entity.Property(e => e.EIsAdmin).HasColumnName("E_IsAdmin");
            entity.Property(e => e.EIsHead).HasColumnName("E_IsHead");
            entity.Property(e => e.EIsSecret).HasColumnName("E_IsSecret");
            entity.Property(e => e.EIsSign).HasColumnName("E_IsSign");
            entity.Property(e => e.ELevel).HasColumnName("E_Level");
            entity.Property(e => e.EMobile)
                .HasMaxLength(125)
                .HasColumnName("E_Mobile");
            entity.Property(e => e.EName)
                .HasMaxLength(125)
                .HasColumnName("E_Name");
            entity.Property(e => e.ENo).HasColumnName("E_No");
            entity.Property(e => e.ENotes)
                .HasColumnType("ntext")
                .HasColumnName("E_Notes");
            entity.Property(e => e.EPassword)
                .HasMaxLength(125)
                .HasColumnName("E_Password");
            entity.Property(e => e.EPasswordToSign)
                .HasMaxLength(125)
                .HasColumnName("E_PasswordToSign");
            entity.Property(e => e.EPhone)
                .HasMaxLength(125)
                .HasColumnName("E_Phone");
            entity.Property(e => e.EPhoneExt)
                .HasMaxLength(125)
                .HasColumnName("E_PhoneExt");
            entity.Property(e => e.EPosition).HasColumnName("E_Position");
            entity.Property(e => e.EProfession).HasColumnName("E_Profession");
            entity.Property(e => e.ERank).HasColumnName("E_Rank");
            entity.Property(e => e.ERepType).HasColumnName("E_RepType");
            entity.Property(e => e.ESection).HasColumnName("E_Section");
            entity.Property(e => e.ESignature)
                .HasMaxLength(50)
                .HasColumnName("E_Signature");
            entity.Property(e => e.EStartDate)
                .HasColumnType("datetime")
                .HasColumnName("E_StartDate");
            entity.Property(e => e.ESubSection).HasColumnName("E_SubSection");
            entity.Property(e => e.ETitle)
                .HasMaxLength(125)
                .HasColumnName("E_Title");
        });

        modelBuilder.Entity<EmployeeTwoFactor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC07A8B97674");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.SecretKey).HasMaxLength(200);

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeTwoFactors)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTwoFactors_Employees");
        });

        modelBuilder.Entity<EmployeesQry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Employees Qry");

            entity.Property(e => e.DId).HasColumnName("D_ID");
            entity.Property(e => e.DMname)
                .HasMaxLength(500)
                .HasColumnName("D_MName");
            entity.Property(e => e.DName)
                .HasMaxLength(125)
                .HasColumnName("D_Name");
            entity.Property(e => e.DPhoneExt)
                .HasMaxLength(125)
                .HasColumnName("D_PhoneExt");
            entity.Property(e => e.DSname)
                .HasMaxLength(125)
                .HasColumnName("D_SName");
            entity.Property(e => e.DSname2)
                .HasMaxLength(500)
                .HasColumnName("D_SName2");
            entity.Property(e => e.DSortOrder).HasColumnName("D_SortOrder");
            entity.Property(e => e.EActive).HasColumnName("E_Active");
            entity.Property(e => e.EAddr1)
                .HasMaxLength(125)
                .HasColumnName("E_Addr1");
            entity.Property(e => e.EAddr2)
                .HasMaxLength(125)
                .HasColumnName("E_Addr2");
            entity.Property(e => e.EAddr3)
                .HasMaxLength(125)
                .HasColumnName("E_Addr3");
            entity.Property(e => e.EAddr4)
                .HasMaxLength(125)
                .HasColumnName("E_Addr4");
            entity.Property(e => e.ECategories).HasColumnName("E_Categories");
            entity.Property(e => e.ECreateDate)
                .HasColumnType("datetime")
                .HasColumnName("E_CreateDate");
            entity.Property(e => e.EDepartment).HasColumnName("E_Department");
            entity.Property(e => e.EDutyCategory).HasColumnName("E_DutyCategory");
            entity.Property(e => e.EEditDate)
                .HasColumnType("datetime")
                .HasColumnName("E_EditDate");
            entity.Property(e => e.EEmail)
                .HasMaxLength(125)
                .HasColumnName("E_Email");
            entity.Property(e => e.EFullname)
                .HasMaxLength(125)
                .HasColumnName("E_Fullname");
            entity.Property(e => e.EGender).HasColumnName("E_Gender");
            entity.Property(e => e.EHeadRank).HasColumnName("E_HeadRank");
            entity.Property(e => e.EId).HasColumnName("E_ID");
            entity.Property(e => e.EIsHead).HasColumnName("E_IsHead");
            entity.Property(e => e.ELevel).HasColumnName("E_Level");
            entity.Property(e => e.EMobile)
                .HasMaxLength(125)
                .HasColumnName("E_Mobile");
            entity.Property(e => e.EName)
                .HasMaxLength(125)
                .HasColumnName("E_Name");
            entity.Property(e => e.ENo).HasColumnName("E_No");
            entity.Property(e => e.ENotes)
                .HasColumnType("ntext")
                .HasColumnName("E_Notes");
            entity.Property(e => e.EPassword)
                .HasMaxLength(125)
                .HasColumnName("E_Password");
            entity.Property(e => e.EPhone)
                .HasMaxLength(125)
                .HasColumnName("E_Phone");
            entity.Property(e => e.EPhoneExt)
                .HasMaxLength(125)
                .HasColumnName("E_PhoneExt");
            entity.Property(e => e.EPosition).HasColumnName("E_Position");
            entity.Property(e => e.EProfession).HasColumnName("E_Profession");
            entity.Property(e => e.ERank).HasColumnName("E_Rank");
            entity.Property(e => e.ERepType).HasColumnName("E_RepType");
            entity.Property(e => e.ESection).HasColumnName("E_Section");
            entity.Property(e => e.ESignature)
                .HasMaxLength(50)
                .HasColumnName("E_Signature");
            entity.Property(e => e.EStartDate)
                .HasColumnType("datetime")
                .HasColumnName("E_StartDate");
            entity.Property(e => e.ESubSection).HasColumnName("E_SubSection");
            entity.Property(e => e.ETitle)
                .HasMaxLength(125)
                .HasColumnName("E_Title");
            entity.Property(e => e.PosId).HasColumnName("Pos_ID");
            entity.Property(e => e.PosName)
                .HasMaxLength(125)
                .HasColumnName("Pos_Name");
            entity.Property(e => e.PosPossibleRank1).HasColumnName("Pos_PossibleRank1");
            entity.Property(e => e.PosPossibleRank2).HasColumnName("Pos_PossibleRank2");
            entity.Property(e => e.PosSortOrder).HasColumnName("Pos_SortOrder");
            entity.Property(e => e.SecDepartment).HasColumnName("Sec_Department");
            entity.Property(e => e.SecId).HasColumnName("Sec_ID");
            entity.Property(e => e.SecName)
                .HasMaxLength(500)
                .HasColumnName("Sec_Name");
            entity.Property(e => e.SecPhoneExt)
                .HasMaxLength(125)
                .HasColumnName("Sec_PhoneExt");
            entity.Property(e => e.SecSname)
                .HasMaxLength(125)
                .HasColumnName("Sec_SName");
        });

        modelBuilder.Entity<FavFolder>(entity =>
        {
            entity.HasKey(e => e.FavFId).HasName("PK__FavFolders__35BCFE0A");

            entity.Property(e => e.FavFId).HasColumnName("FavF_ID");
            entity.Property(e => e.FavFCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("FavF_CreateDate");
            entity.Property(e => e.FavFCreateUser).HasColumnName("FavF_CreateUser");
            entity.Property(e => e.FavFIsSystem).HasColumnName("FavF_IsSystem");
            entity.Property(e => e.FavFName)
                .HasMaxLength(125)
                .HasColumnName("FavF_Name");
            entity.Property(e => e.FavFUser).HasColumnName("FavF_User");
        });

        modelBuilder.Entity<Favorite>(entity =>
        {
            entity.HasKey(e => e.FavId).HasName("PK__Favorites__37A5467C");

            entity.Property(e => e.FavId).HasColumnName("Fav_ID");
            entity.Property(e => e.FavCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("Fav_CreateDate");
            entity.Property(e => e.FavCreateUser).HasColumnName("Fav_CreateUser");
            entity.Property(e => e.FavFolder).HasColumnName("Fav_Folder");
            entity.Property(e => e.FavLink)
                .HasMaxLength(255)
                .HasColumnName("Fav_Link");
            entity.Property(e => e.FavTitle)
                .HasMaxLength(255)
                .HasColumnName("Fav_Title");
            entity.Property(e => e.FavUser).HasColumnName("Fav_User");
        });

        modelBuilder.Entity<FileManager>(entity =>
        {
            entity.HasKey(e => e.FmId);

            entity.ToTable("FileManager");

            entity.Property(e => e.FmId).HasColumnName("FM_ID");
            entity.Property(e => e.FmCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("FM_CreateDate");
            entity.Property(e => e.FmCreateUser).HasColumnName("FM_CreateUser");
            entity.Property(e => e.FmFm).HasColumnName("FM_FM");
            entity.Property(e => e.FmFmSub).HasColumnName("FM_FM_Sub");
            entity.Property(e => e.FmMinuteSheet).HasColumnName("FM_MinuteSheet");
            entity.Property(e => e.FmOlType).HasColumnName("FM_OL_Type");
            entity.Property(e => e.FmSection).HasColumnName("FM_Section");
            entity.Property(e => e.FmType).HasColumnName("FM_Type");
        });

        modelBuilder.Entity<FileManagerMain>(entity =>
        {
            entity.HasKey(e => e.FmnId);

            entity.ToTable("FileManagerMain");

            entity.Property(e => e.FmnId).HasColumnName("FMN_ID");
            entity.Property(e => e.FmnDepartment).HasColumnName("FMN_Department");
            entity.Property(e => e.FmnParent).HasColumnName("FMN_Parent");
            entity.Property(e => e.FmnPosition).HasColumnName("FMN_Position");
            entity.Property(e => e.FmnSection).HasColumnName("FMN_Section");
            entity.Property(e => e.FmnSortOrder).HasColumnName("FMN_SortOrder");
            entity.Property(e => e.FmnSubSection).HasColumnName("FMN_SubSection");
            entity.Property(e => e.FmnTitle)
                .HasMaxLength(2000)
                .HasColumnName("FMN_Title");
        });

        modelBuilder.Entity<FileManagerQry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("File_Manager_qry");

            entity.Property(e => e.FmCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("FM_CreateDate");
            entity.Property(e => e.FmCreateUser).HasColumnName("FM_CreateUser");
            entity.Property(e => e.FmFm).HasColumnName("FM_FM");
            entity.Property(e => e.FmFmSub).HasColumnName("FM_FM_Sub");
            entity.Property(e => e.FmId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FM_ID");
            entity.Property(e => e.FmMinuteSheet).HasColumnName("FM_MinuteSheet");
            entity.Property(e => e.FmOlType).HasColumnName("FM_OL_Type");
            entity.Property(e => e.FmSection).HasColumnName("FM_Section");
            entity.Property(e => e.FmType).HasColumnName("FM_Type");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__Logs__20C1E124");

            entity.Property(e => e.LogId).HasColumnName("Log_ID");
            entity.Property(e => e.LogAction).HasColumnName("Log_Action");
            entity.Property(e => e.LogDate)
                .HasColumnType("datetime")
                .HasColumnName("Log_Date");
            entity.Property(e => e.LogDescription)
                .HasColumnType("ntext")
                .HasColumnName("Log_Description");
            entity.Property(e => e.LogIpaddr)
                .HasMaxLength(125)
                .HasColumnName("Log_IPAddr");
            entity.Property(e => e.LogItem).HasColumnName("Log_Item");
            entity.Property(e => e.LogItemName)
                .HasColumnType("ntext")
                .HasColumnName("Log_ItemName");
            entity.Property(e => e.LogRefer)
                .HasMaxLength(255)
                .HasColumnName("Log_Refer");
            entity.Property(e => e.LogService).HasColumnName("Log_Service");
            entity.Property(e => e.LogTemplate)
                .HasMaxLength(255)
                .HasColumnName("Log_Template");
            entity.Property(e => e.LogTime)
                .HasColumnType("datetime")
                .HasColumnName("Log_Time");
            entity.Property(e => e.LogUrl)
                .HasMaxLength(1000)
                .HasColumnName("Log_URL");
            entity.Property(e => e.LogUser).HasColumnName("Log_User");
            entity.Property(e => e.LogUserName)
                .HasMaxLength(125)
                .HasColumnName("Log_UserName");
        });

        modelBuilder.Entity<Mail>(entity =>
        {
            entity.HasKey(e => e.MId);

            entity.Property(e => e.MId).HasColumnName("M_ID");
            entity.Property(e => e.MAttachments)
                .HasMaxLength(255)
                .HasColumnName("M_Attachments");
            entity.Property(e => e.MBccname)
                .HasMaxLength(2000)
                .HasColumnName("M_BCCName");
            entity.Property(e => e.MCategories)
                .HasMaxLength(255)
                .HasColumnName("M_Categories");
            entity.Property(e => e.MCcname)
                .HasMaxLength(255)
                .HasColumnName("M_CCName");
            entity.Property(e => e.MContacts)
                .HasMaxLength(255)
                .HasColumnName("M_Contacts");
            entity.Property(e => e.MEmployees)
                .HasMaxLength(255)
                .HasColumnName("M_Employees");
            entity.Property(e => e.MFolder).HasColumnName("M_Folder");
            entity.Property(e => e.MFrom).HasColumnName("M_From");
            entity.Property(e => e.MFromName)
                .HasMaxLength(125)
                .HasColumnName("M_FromName");
            entity.Property(e => e.MIsDeleted).HasColumnName("M_IsDeleted");
            entity.Property(e => e.MIsDraft).HasColumnName("M_IsDraft");
            entity.Property(e => e.MIsHtml).HasColumnName("M_IsHTML");
            entity.Property(e => e.MIsNotify).HasColumnName("M_IsNotify");
            entity.Property(e => e.MIsPrivate).HasColumnName("M_IsPrivate");
            entity.Property(e => e.MIsRead).HasColumnName("M_IsRead");
            entity.Property(e => e.MIsSent).HasColumnName("M_IsSent");
            entity.Property(e => e.MMessage)
                .HasColumnType("ntext")
                .HasColumnName("M_Message");
            entity.Property(e => e.MMsgType)
                .HasMaxLength(255)
                .HasColumnName("M_MsgType");
            entity.Property(e => e.MOmailId).HasColumnName("M_OMailID");
            entity.Property(e => e.MOwner).HasColumnName("M_Owner");
            entity.Property(e => e.MReceived)
                .HasColumnType("datetime")
                .HasColumnName("M_Received");
            entity.Property(e => e.MRefId).HasColumnName("M_RefID");
            entity.Property(e => e.MSent)
                .HasColumnType("datetime")
                .HasColumnName("M_Sent");
            entity.Property(e => e.MSfileName)
                .HasMaxLength(255)
                .HasColumnName("M_SFileName");
            entity.Property(e => e.MSubject)
                .HasMaxLength(255)
                .HasColumnName("M_Subject");
            entity.Property(e => e.MTo).HasColumnName("M_To");
            entity.Property(e => e.MToName)
                .HasMaxLength(255)
                .HasColumnName("M_ToName");
            entity.Property(e => e.MUniqueId).HasColumnName("M_UniqueID");
        });

        modelBuilder.Entity<MeetingAnnouncer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Meeting_Announcers");

            entity.Property(e => e.MaDep).HasColumnName("MA_Dep");
            entity.Property(e => e.MaEmpId).HasColumnName("MA_EmpID");
            entity.Property(e => e.MaId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MA_ID");
            entity.Property(e => e.MaMrid).HasColumnName("MA_MRID");
            entity.Property(e => e.MaPosition).HasColumnName("MA_Position");
            entity.Property(e => e.MaSec).HasColumnName("MA_Sec");
        });

        modelBuilder.Entity<MeetingGuest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Meeting_Guest");

            entity.Property(e => e.MgDep).HasColumnName("MG_Dep");
            entity.Property(e => e.MgExternalGuest)
                .HasMaxLength(500)
                .HasColumnName("MG_ExternalGuest");
            entity.Property(e => e.MgId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MG_ID");
            entity.Property(e => e.MgIsExternal).HasColumnName("MG_IsExternal");
            entity.Property(e => e.MgMrid).HasColumnName("MG_MRID");
            entity.Property(e => e.MgPosition).HasColumnName("MG_Position");
            entity.Property(e => e.MgSec).HasColumnName("MG_Sec");
        });

        modelBuilder.Entity<MeetingRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Meeting_Register");

            entity.Property(e => e.MDate)
                .HasColumnType("datetime")
                .HasColumnName("M_Date");
            entity.Property(e => e.MDescription).HasColumnName("M_Description");
            entity.Property(e => e.MEditDate)
                .HasColumnType("datetime")
                .HasColumnName("M_EditDate");
            entity.Property(e => e.MFrom).HasColumnName("M_From");
            entity.Property(e => e.MId)
                .ValueGeneratedOnAdd()
                .HasColumnName("M_ID");
            entity.Property(e => e.MInviationLetter)
                .HasMaxLength(100)
                .HasColumnName("M_InviationLetter");
            entity.Property(e => e.MIsConfirm).HasColumnName("M_IsConfirm");
            entity.Property(e => e.MOrganizedDep).HasColumnName("M_OrganizedDep");
            entity.Property(e => e.MOrganizedSec).HasColumnName("M_OrganizedSec");
            entity.Property(e => e.MPlace)
                .HasMaxLength(200)
                .HasColumnName("M_Place");
            entity.Property(e => e.MRegisteredDate)
                .HasColumnType("datetime")
                .HasColumnName("M_RegisteredDate");
            entity.Property(e => e.MRemark).HasColumnName("M_Remark");
            entity.Property(e => e.MTo).HasColumnName("M_To");
            entity.Property(e => e.MType).HasColumnName("M_Type");
        });

        modelBuilder.Entity<MeetingType>(entity =>
        {
            entity.HasKey(e => e.MtId).HasName("PK__Meeting___AEA8200D41B8C09B");

            entity.ToTable("Meeting_Type");

            entity.Property(e => e.MtId).HasColumnName("MT_ID");
            entity.Property(e => e.MtName)
                .HasMaxLength(50)
                .HasColumnName("MT_Name");
            entity.Property(e => e.MtSortOrder).HasColumnName("MT_SortOrder");
        });

        modelBuilder.Entity<MinuteSheet>(entity =>
        {
            entity.HasKey(e => e.MsId);

            entity.Property(e => e.MsId).HasColumnName("MS_ID");
            entity.Property(e => e.MsAttach)
                .HasMaxLength(2000)
                .HasColumnName("MS_Attach");
            entity.Property(e => e.MsBody)
                .HasColumnType("ntext")
                .HasColumnName("MS_Body");
            entity.Property(e => e.MsCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("MS_CreateDate");
            entity.Property(e => e.MsCurrent).HasColumnName("MS_Current");
            entity.Property(e => e.MsCurrentRank).HasColumnName("MS_CurrentRank");
            entity.Property(e => e.MsCurrentRemarks)
                .HasColumnType("ntext")
                .HasColumnName("MS_CurrentRemarks");
            entity.Property(e => e.MsCurrentSign)
                .HasMaxLength(100)
                .HasColumnName("MS_CurrentSign");
            entity.Property(e => e.MsDate)
                .HasColumnType("datetime")
                .HasColumnName("MS_Date");
            entity.Property(e => e.MsDepartMent)
                .HasMaxLength(1000)
                .HasColumnName("MS_DepartMent");
            entity.Property(e => e.MsMention)
                .HasColumnType("ntext")
                .HasColumnName("MS_Mention");
            entity.Property(e => e.MsOwner).HasColumnName("MS_Owner");
            entity.Property(e => e.MsParent)
                .HasDefaultValue(0)
                .HasColumnName("MS_Parent");
            entity.Property(e => e.MsRemarks)
                .HasColumnType("ntext")
                .HasColumnName("MS_Remarks");
            entity.Property(e => e.MsSender)
                .HasMaxLength(1000)
                .HasColumnName("MS_Sender");
            entity.Property(e => e.MsSenderRank).HasColumnName("MS_SenderRank");
            entity.Property(e => e.MsSentDone)
                .HasDefaultValue(0)
                .HasColumnName("MS_SentDone");
            entity.Property(e => e.MsSign)
                .HasMaxLength(50)
                .HasColumnName("MS_Sign");
            entity.Property(e => e.MsSubject)
                .HasColumnType("ntext")
                .HasColumnName("MS_Subject");
            entity.Property(e => e.MsUnique)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MS_Unique");
        });

        modelBuilder.Entity<Month>(entity =>
        {
            entity.HasKey(e => e.MonthId).HasName("PK__Month__3B75D760");

            entity.ToTable("Month");

            entity.Property(e => e.MonthId).HasColumnName("Month_ID");
            entity.Property(e => e.MonthName)
                .HasMaxLength(125)
                .HasColumnName("Month_Name");
            entity.Property(e => e.MonthNo).HasColumnName("Month_No");
        });

        modelBuilder.Entity<MsheetRmk>(entity =>
        {
            entity.HasKey(e => e.MsrId);

            entity.ToTable("MSheet_RMK");

            entity.Property(e => e.MsrId).HasColumnName("MSR_ID");
            entity.Property(e => e.MsrCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("MSR_CreateDate");
            entity.Property(e => e.MsrDate)
                .HasColumnType("datetime")
                .HasColumnName("MSR_Date");
            entity.Property(e => e.MsrFrom).HasColumnName("MSR_From");
            entity.Property(e => e.MsrFromPosition).HasColumnName("MSR_FromPosition");
            entity.Property(e => e.MsrFromSign)
                .HasMaxLength(50)
                .HasColumnName("MSR_FromSign");
            entity.Property(e => e.MsrIsCompleted)
                .HasDefaultValue(0)
                .HasColumnName("MSR_IsCompleted");
            entity.Property(e => e.MsrMs).HasColumnName("MSR_MS");
            entity.Property(e => e.MsrRemarks)
                .HasColumnType("ntext")
                .HasColumnName("MSR_Remarks");
            entity.Property(e => e.MsrStarter).HasColumnName("MSR_Starter");
            entity.Property(e => e.MsrTo).HasColumnName("MSR_To");
            entity.Property(e => e.MsrToPosition).HasColumnName("MSR_ToPosition");
        });

        modelBuilder.Entity<NoteSheet>(entity =>
        {
            entity.HasKey(e => e.NsId).HasName("PK__NoteSheet__22AA2996");

            entity.ToTable("NoteSheet");

            entity.Property(e => e.NsId).HasColumnName("NS_ID");
            entity.Property(e => e.NsAttachFile)
                .HasMaxLength(125)
                .HasColumnName("NS_AttachFile");
            entity.Property(e => e.NsCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("NS_CreateDate");
            entity.Property(e => e.NsCreateUser).HasColumnName("NS_CreateUser");
            entity.Property(e => e.NsDate)
                .HasColumnType("datetime")
                .HasColumnName("NS_Date");
            entity.Property(e => e.NsDesc)
                .HasColumnType("ntext")
                .HasColumnName("NS_Desc");
            entity.Property(e => e.NsFolder).HasColumnName("NS_Folder");
            entity.Property(e => e.NsFormNo)
                .HasMaxLength(255)
                .HasColumnName("NS_FormNo");
            entity.Property(e => e.NsHeader)
                .HasColumnType("ntext")
                .HasColumnName("NS_Header");
            entity.Property(e => e.NsIsFinish).HasColumnName("NS_IsFinish");
            entity.Property(e => e.NsIsdraft).HasColumnName("NS_Isdraft");
            entity.Property(e => e.NsPlace)
                .HasMaxLength(255)
                .HasColumnName("NS_Place");
            entity.Property(e => e.NsReference)
                .HasMaxLength(255)
                .HasColumnName("NS_Reference");
            entity.Property(e => e.NsTitle)
                .HasColumnType("ntext")
                .HasColumnName("NS_Title");
            entity.Property(e => e.NsUniqueId).HasColumnName("NS_UniqueID");
        });

        modelBuilder.Entity<Nsfolder>(entity =>
        {
            entity.HasKey(e => e.NsfId).HasName("PK__NSFolder__48CFD27E");

            entity.ToTable("NSFolder");

            entity.Property(e => e.NsfId).HasColumnName("NSF_ID");
            entity.Property(e => e.NsfCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("NSF_CreateDate");
            entity.Property(e => e.NsfName)
                .HasMaxLength(255)
                .HasColumnName("NSF_Name");
            entity.Property(e => e.NsfSortOrder).HasColumnName("NSF_SortOrder");
            entity.Property(e => e.NsfUser).HasColumnName("NSF_User");
        });

        modelBuilder.Entity<NsremarkType>(entity =>
        {
            entity.HasKey(e => e.NsremarkId).HasName("PK__NSRemarkType__267ABA7A");

            entity.ToTable("NSRemarkType");

            entity.Property(e => e.NsremarkId).HasColumnName("NSRemark_ID");
            entity.Property(e => e.NsremarkRemark)
                .HasMaxLength(255)
                .HasColumnName("NSRemark_Remark");
            entity.Property(e => e.NsremarkType1).HasColumnName("NSRemark_Type");
        });

        modelBuilder.Entity<NsshareUser>(entity =>
        {
            entity.HasKey(e => e.NssuserId).HasName("PK__NSShareUser__286302EC");

            entity.ToTable("NSShareUser");

            entity.Property(e => e.NssuserId).HasColumnName("NSSUser_ID");
            entity.Property(e => e.NssuserDate)
                .HasColumnType("datetime")
                .HasColumnName("NSSUser_Date");
            entity.Property(e => e.NssuserNoteSheet).HasColumnName("NSSUser_NoteSheet");
            entity.Property(e => e.NssuserUser).HasColumnName("NSSUser_User");
        });

        modelBuilder.Entity<Nstransaction>(entity =>
        {
            entity.HasKey(e => e.NstId).HasName("PK__NSTransaction__24927208");

            entity.ToTable("NSTransaction");

            entity.Property(e => e.NstId).HasColumnName("NST_ID");
            entity.Property(e => e.NstAttach)
                .HasMaxLength(255)
                .HasColumnName("NST_Attach");
            entity.Property(e => e.NstCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("NST_CreateDate");
            entity.Property(e => e.NstCreateUser).HasColumnName("NST_CreateUser");
            entity.Property(e => e.NstDate)
                .HasColumnType("datetime")
                .HasColumnName("NST_Date");
            entity.Property(e => e.NstFuser).HasColumnName("NST_FUser");
            entity.Property(e => e.NstInOut).HasColumnName("NST_InOut");
            entity.Property(e => e.NstIsFirst).HasColumnName("NST_IsFirst");
            entity.Property(e => e.NstIsPending).HasColumnName("NST_IsPending");
            entity.Property(e => e.NstNoteSheet).HasColumnName("NST_NoteSheet");
            entity.Property(e => e.NstRemark)
                .HasColumnType("ntext")
                .HasColumnName("NST_Remark");
            entity.Property(e => e.NstTuser).HasColumnName("NST_TUser");
        });

        modelBuilder.Entity<Nsuser>(entity =>
        {
            entity.HasKey(e => e.NsuserId).HasName("PK__NSUsers__2A4B4B5E");

            entity.ToTable("NSUsers");

            entity.Property(e => e.NsuserId).HasColumnName("NSUser_ID");
            entity.Property(e => e.NsuserCreateUser).HasColumnName("NSUser_CreateUser");
            entity.Property(e => e.NsuserNoteSheet).HasColumnName("NSUser_NoteSheet");
            entity.Property(e => e.NsuserUser).HasColumnName("NSUser_User");
        });

        modelBuilder.Entity<OfficeLRemark>(entity =>
        {
            entity.HasKey(e => e.OlrId).HasName("PK__OfficeL_Remark__5DCAEF64");

            entity.ToTable("OfficeL_Remark");

            entity.Property(e => e.OlrId).HasColumnName("OLR_ID");
            entity.Property(e => e.OlrCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("OLR_CreateDate");
            entity.Property(e => e.OlrMaker).HasColumnName("OLR_Maker");
            entity.Property(e => e.OlrMakerName)
                .HasMaxLength(125)
                .HasColumnName("OLR_MakerName");
            entity.Property(e => e.OlrOffice).HasColumnName("OLR_Office");
            entity.Property(e => e.OlrRemark)
                .HasColumnType("ntext")
                .HasColumnName("OLR_Remark");
        });

        modelBuilder.Entity<OfficeLetter>(entity =>
        {
            entity.HasKey(e => e.OlId).HasName("PK__OfficeLetter__4E88ABD4");

            entity.ToTable("OfficeLetter");

            entity.Property(e => e.OlId).HasColumnName("OL_ID");
            entity.Property(e => e.OlAttach)
                .HasMaxLength(255)
                .HasColumnName("OL_Attach");
            entity.Property(e => e.OlCat).HasColumnName("OL_Cat");
            entity.Property(e => e.OlCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("OL_CreateDate");
            entity.Property(e => e.OlCreateUser).HasColumnName("OL_CreateUser");
            entity.Property(e => e.OlDate)
                .HasColumnType("datetime")
                .HasColumnName("OL_Date");
            entity.Property(e => e.OlFrom)
                .HasMaxLength(255)
                .HasColumnName("OL_From");
            entity.Property(e => e.OlHeader)
                .HasColumnType("ntext")
                .HasColumnName("OL_Header");
            entity.Property(e => e.OlInOut).HasColumnName("OL_InOut");
            entity.Property(e => e.OlLevel).HasColumnName("OL_Level");
            entity.Property(e => e.OlMessage)
                .HasColumnType("ntext")
                .HasColumnName("OL_Message");
            entity.Property(e => e.OlPlace)
                .HasMaxLength(255)
                .HasColumnName("OL_Place");
            entity.Property(e => e.OlRefNo)
                .HasMaxLength(255)
                .HasColumnName("OL_RefNo");
            entity.Property(e => e.OlSubject)
                .HasColumnType("ntext")
                .HasColumnName("OL_Subject");
            entity.Property(e => e.OlType).HasColumnName("OL_Type");
        });

        modelBuilder.Entity<OfficeLetterRemark>(entity =>
        {
            entity.HasKey(e => e.OlrId);

            entity.ToTable("OfficeLetter_Remarks");

            entity.Property(e => e.OlrId).HasColumnName("OLR_ID");
            entity.Property(e => e.OlrPosition).HasColumnName("OLR_Position");
            entity.Property(e => e.OlrRemarks)
                .HasColumnType("ntext")
                .HasColumnName("OLR_Remarks");
            entity.Property(e => e.OlrSortOrder).HasColumnName("OLR_SortOrder");
        });

        modelBuilder.Entity<OfficeLetterV2>(entity =>
        {
            entity.HasKey(e => e.OlId);

            entity.ToTable("OfficeLetter_v2");

            entity.Property(e => e.OlId).HasColumnName("OL_ID");
            entity.Property(e => e.OlAttach)
                .HasMaxLength(4000)
                .HasColumnName("OL_Attach");
            entity.Property(e => e.OlBehalf).HasColumnName("OL_Behalf");
            entity.Property(e => e.OlBody)
                .HasColumnType("ntext")
                .HasColumnName("OL_Body");
            entity.Property(e => e.OlCopy)
                .HasMaxLength(4000)
                .HasColumnName("OL_Copy");
            entity.Property(e => e.OlCopyText)
                .HasMaxLength(4000)
                .HasColumnName("OL_CopyText");
            entity.Property(e => e.OlCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("OL_CreateDate");
            entity.Property(e => e.OlDate)
                .HasColumnType("datetime")
                .HasColumnName("OL_Date");
            entity.Property(e => e.OlDepartmentName)
                .HasMaxLength(2000)
                .HasColumnName("OL_DepartmentName");
            entity.Property(e => e.OlIsCopy).HasColumnName("OL_IsCopy");
            entity.Property(e => e.OlIsDist)
                .HasDefaultValue(0)
                .HasColumnName("OL_IsDist");
            entity.Property(e => e.OlIsPdf)
                .HasDefaultValue(0)
                .HasColumnName("OL_IsPDF");
            entity.Property(e => e.OlIsSend)
                .HasDefaultValue(0)
                .HasColumnName("OL_IsSend");
            entity.Property(e => e.OlIsSign)
                .HasDefaultValue(0)
                .HasColumnName("OL_IsSign");
            entity.Property(e => e.OlIsSignDone)
                .HasDefaultValue(0)
                .HasColumnName("OL_IsSignDone");
            entity.Property(e => e.OlMention)
                .HasColumnType("ntext")
                .HasColumnName("OL_Mention");
            entity.Property(e => e.OlNo)
                .HasMaxLength(1000)
                .HasColumnName("OL_No");
            entity.Property(e => e.OlOwner).HasColumnName("OL_Owner");
            entity.Property(e => e.OlOwnerName)
                .HasMaxLength(1000)
                .HasColumnName("OL_OwnerName");
            entity.Property(e => e.OlOwnerRank).HasColumnName("OL_OwnerRank");
            entity.Property(e => e.OlPageNo)
                .HasMaxLength(100)
                .HasColumnName("OL_PageNo");
            entity.Property(e => e.OlParent)
                .HasDefaultValue(0)
                .HasColumnName("OL_Parent");
            entity.Property(e => e.OlSecurity).HasColumnName("OL_Security");
            entity.Property(e => e.OlSendDepartment)
                .HasDefaultValue(0)
                .HasColumnName("OL_SendDepartment");
            entity.Property(e => e.OlSendSection)
                .HasDefaultValue(0)
                .HasColumnName("OL_SendSection");
            entity.Property(e => e.OlSender)
                .HasDefaultValue(0)
                .HasColumnName("OL_Sender");
            entity.Property(e => e.OlSenderRank).HasColumnName("OL_SenderRank");
            entity.Property(e => e.OlSentDone)
                .HasDefaultValue(0)
                .HasColumnName("OL_SentDone");
            entity.Property(e => e.OlShare).HasColumnName("OL_Share");
            entity.Property(e => e.OlSignature)
                .HasMaxLength(200)
                .HasColumnName("OL_Signature");
            entity.Property(e => e.OlSubject)
                .HasColumnType("ntext")
                .HasColumnName("OL_Subject");
            entity.Property(e => e.OlType)
                .HasDefaultValue(1)
                .HasColumnName("OL_Type");
        });

        modelBuilder.Entity<OlRegQry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OlRegQry");

            entity.Property(e => e.OlrAttach)
                .HasMaxLength(255)
                .HasColumnName("OLR_Attach");
            entity.Property(e => e.OlrCat).HasColumnName("OLR_Cat");
            entity.Property(e => e.OlrCcid).HasColumnName("OLR_CCID");
            entity.Property(e => e.OlrCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("OLR_CreateDate");
            entity.Property(e => e.OlrCreateUser).HasColumnName("OLR_CreateUser");
            entity.Property(e => e.OlrDate)
                .HasColumnType("datetime")
                .HasColumnName("OLR_Date");
            entity.Property(e => e.OlrFrom).HasColumnName("OLR_From");
            entity.Property(e => e.OlrHeader)
                .HasColumnType("ntext")
                .HasColumnName("OLR_Header");
            entity.Property(e => e.OlrId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OLR_ID");
            entity.Property(e => e.OlrInOut).HasColumnName("OLR_InOut");
            entity.Property(e => e.OlrIsArchive).HasColumnName("OLR_IsArchive");
            entity.Property(e => e.OlrIsFolder).HasColumnName("OLR_IsFolder");
            entity.Property(e => e.OlrIsRead).HasColumnName("OLR_IsRead");
            entity.Property(e => e.OlrIsSend).HasColumnName("OLR_IsSend");
            entity.Property(e => e.OlrLevel).HasColumnName("OLR_Level");
            entity.Property(e => e.OlrMessage)
                .HasColumnType("ntext")
                .HasColumnName("OLR_Message");
            entity.Property(e => e.OlrPlace)
                .HasMaxLength(255)
                .HasColumnName("OLR_Place");
            entity.Property(e => e.OlrRefId).HasColumnName("OLR_RefID");
            entity.Property(e => e.OlrRefNo)
                .HasMaxLength(255)
                .HasColumnName("OLR_RefNo");
            entity.Property(e => e.OlrSubject)
                .HasColumnType("ntext")
                .HasColumnName("OLR_Subject");
            entity.Property(e => e.OlrTo).HasColumnName("OLR_To");
            entity.Property(e => e.OlrType).HasColumnName("OLR_Type");
            entity.Property(e => e.OlrUniqueId).HasColumnName("OLR_UniqueID");
        });

        modelBuilder.Entity<Olcat>(entity =>
        {
            entity.HasKey(e => e.OlcId).HasName("PK__OLCat__4CA06362");

            entity.ToTable("OLCat");

            entity.Property(e => e.OlcId).HasColumnName("OLC_ID");
            entity.Property(e => e.OlcName)
                .HasMaxLength(255)
                .HasColumnName("OLC_Name");
            entity.Property(e => e.OlcSection).HasColumnName("OLC_Section");
            entity.Property(e => e.OlcSortOrder).HasColumnName("OLC_SortOrder");
        });

        modelBuilder.Entity<Olfolder>(entity =>
        {
            entity.HasKey(e => e.OlfId).HasName("PK__OLFolder__52593CB8");

            entity.ToTable("OLFolder");

            entity.Property(e => e.OlfId).HasColumnName("OLF_ID");
            entity.Property(e => e.OlfCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("OLF_CreateDate");
            entity.Property(e => e.OlfName)
                .HasMaxLength(255)
                .HasColumnName("OLF_Name");
            entity.Property(e => e.OlfOwner).HasColumnName("OLF_Owner");
        });

        modelBuilder.Entity<Olforward>(entity =>
        {
            entity.HasKey(e => e.OlfId);

            entity.ToTable("olforward");

            entity.Property(e => e.OlfId).HasColumnName("olf_id");
            entity.Property(e => e.OlfCreatedate)
                .HasColumnType("datetime")
                .HasColumnName("olf_createdate");
            entity.Property(e => e.OlfFrom).HasColumnName("olf_from");
            entity.Property(e => e.OlfMessage)
                .HasColumnType("ntext")
                .HasColumnName("olf_message");
            entity.Property(e => e.OlfOl).HasColumnName("olf_ol");
            entity.Property(e => e.OlfTo).HasColumnName("olf_to");
            entity.Property(e => e.OlfTolist)
                .HasMaxLength(1000)
                .HasColumnName("olf_tolist");
        });

        modelBuilder.Entity<Olinboxoutbox>(entity =>
        {
            entity.HasKey(e => e.OlioId).HasName("PK__OLInboxoutbox__59FA5E80");

            entity.ToTable("OLInboxoutbox");

            entity.Property(e => e.OlioId).HasColumnName("OLIO_ID");
            entity.Property(e => e.OlioFolder).HasColumnName("OLIO_Folder");
            entity.Property(e => e.OlioOlregId).HasColumnName("OLIO_OLRegID");
        });

        modelBuilder.Entity<Oliofolder>(entity =>
        {
            entity.HasKey(e => e.OlfId).HasName("PK__OLIOFolders__5812160E");

            entity.ToTable("OLIOFolders");

            entity.Property(e => e.OlfId).HasColumnName("OLF_ID");
            entity.Property(e => e.OlfCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("OLF_CreateDate");
            entity.Property(e => e.OlfInout).HasColumnName("OLF_Inout");
            entity.Property(e => e.OlfName)
                .HasMaxLength(255)
                .HasColumnName("OLF_Name");
            entity.Property(e => e.OlfSortOrder).HasColumnName("OLF_SortOrder");
            entity.Property(e => e.OlfUser).HasColumnName("OLF_User");
        });

        modelBuilder.Entity<Olno>(entity =>
        {
            entity.HasKey(e => e.OlnId);

            entity.ToTable("OLNo");

            entity.Property(e => e.OlnId).HasColumnName("OLN_ID");
            entity.Property(e => e.OlnDepartment).HasColumnName("OLN_Department");
            entity.Property(e => e.OlnNo).HasColumnName("OLN_No");
            entity.Property(e => e.OlnOl)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OLN_OL");
            entity.Property(e => e.OlnSection).HasColumnName("OLN_Section");
            entity.Property(e => e.OlnType).HasColumnName("OLN_Type");
            entity.Property(e => e.OlnYear).HasColumnName("OLN_Year");
        });

        modelBuilder.Entity<Olread>(entity =>
        {
            entity.HasKey(e => e.OlrId);

            entity.ToTable("OLRead");

            entity.Property(e => e.OlrId).HasColumnName("OLR_ID");
            entity.Property(e => e.OlrCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("OLR_CreateDate");
            entity.Property(e => e.OlrOl).HasColumnName("OLR_OL");
            entity.Property(e => e.OlrType).HasColumnName("OLR_Type");
            entity.Property(e => e.OlrUser).HasColumnName("OLR_User");
        });

        modelBuilder.Entity<Olreg>(entity =>
        {
            entity.HasKey(e => e.OlrId).HasName("PK__OLReg__5441852A");

            entity.ToTable("OLReg");

            entity.Property(e => e.OlrId).HasColumnName("OLR_ID");
            entity.Property(e => e.OlrAttach)
                .HasMaxLength(255)
                .HasColumnName("OLR_Attach");
            entity.Property(e => e.OlrCat).HasColumnName("OLR_Cat");
            entity.Property(e => e.OlrCcid).HasColumnName("OLR_CCID");
            entity.Property(e => e.OlrCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("OLR_CreateDate");
            entity.Property(e => e.OlrCreateUser).HasColumnName("OLR_CreateUser");
            entity.Property(e => e.OlrDate)
                .HasColumnType("datetime")
                .HasColumnName("OLR_Date");
            entity.Property(e => e.OlrFrom).HasColumnName("OLR_From");
            entity.Property(e => e.OlrHeader)
                .HasColumnType("ntext")
                .HasColumnName("OLR_Header");
            entity.Property(e => e.OlrInOut).HasColumnName("OLR_InOut");
            entity.Property(e => e.OlrIsArchive).HasColumnName("OLR_IsArchive");
            entity.Property(e => e.OlrIsFolder).HasColumnName("OLR_IsFolder");
            entity.Property(e => e.OlrIsRead)
                .HasDefaultValue(false)
                .HasColumnName("OLR_IsRead");
            entity.Property(e => e.OlrIsSend).HasColumnName("OLR_IsSend");
            entity.Property(e => e.OlrLevel).HasColumnName("OLR_Level");
            entity.Property(e => e.OlrMessage)
                .HasColumnType("ntext")
                .HasColumnName("OLR_Message");
            entity.Property(e => e.OlrPlace)
                .HasMaxLength(255)
                .HasColumnName("OLR_Place");
            entity.Property(e => e.OlrRefId).HasColumnName("OLR_RefID");
            entity.Property(e => e.OlrRefNo)
                .HasMaxLength(255)
                .HasColumnName("OLR_RefNo");
            entity.Property(e => e.OlrSubject)
                .HasColumnType("ntext")
                .HasColumnName("OLR_Subject");
            entity.Property(e => e.OlrTo).HasColumnName("OLR_To");
            entity.Property(e => e.OlrType).HasColumnName("OLR_Type");
            entity.Property(e => e.OlrUniqueId).HasColumnName("OLR_UniqueID");
        });

        modelBuilder.Entity<Olshare>(entity =>
        {
            entity.HasKey(e => e.OlsId).HasName("PK_OL_Share");

            entity.ToTable("OLShare");

            entity.Property(e => e.OlsId).HasColumnName("OLS_ID");
            entity.Property(e => e.OlsCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("OLS_CreateDate");
            entity.Property(e => e.OlsOl).HasColumnName("OLS_OL");
            entity.Property(e => e.OlsTo).HasColumnName("OLS_To");
            entity.Property(e => e.OlsToList)
                .HasMaxLength(2000)
                .HasColumnName("OLS_ToList");
        });

        modelBuilder.Entity<Olstep>(entity =>
        {
            entity.HasKey(e => e.OlsId).HasName("PK_OL_Steps");

            entity.ToTable("OLSteps");

            entity.Property(e => e.OlsId).HasColumnName("OLS_ID");
            entity.Property(e => e.OlsCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("OLS_CreateDate");
            entity.Property(e => e.OlsFrom).HasColumnName("OLS_From");
            entity.Property(e => e.OlsIsCompleted)
                .HasDefaultValue(0)
                .HasColumnName("OLS_IsCompleted");
            entity.Property(e => e.OlsOl).HasColumnName("OLS_OL");
            entity.Property(e => e.OlsRemarks)
                .HasColumnType("ntext")
                .HasColumnName("OLS_Remarks");
            entity.Property(e => e.OlsTo).HasColumnName("OLS_To");
            entity.Property(e => e.OlsToList)
                .HasMaxLength(2000)
                .HasColumnName("OLS_ToList");
        });

        modelBuilder.Entity<Oltype>(entity =>
        {
            entity.HasKey(e => e.OltId).HasName("PK__OLType__4AB81AF0");

            entity.ToTable("OLType");

            entity.Property(e => e.OltId).HasColumnName("OLT_ID");
            entity.Property(e => e.OltName)
                .HasMaxLength(255)
                .HasColumnName("OLT_Name");
            entity.Property(e => e.OltSortOrder).HasColumnName("OLT_SortOrder");
        });

        modelBuilder.Entity<Oluser>(entity =>
        {
            entity.HasKey(e => e.OluId).HasName("PK__OLUsers__5070F446");

            entity.ToTable("OLUsers");

            entity.Property(e => e.OluId).HasColumnName("OLU_ID");
            entity.Property(e => e.OluCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("OLU_CreateDate");
            entity.Property(e => e.OluOl).HasColumnName("OLU_OL");
            entity.Property(e => e.OluOwner).HasColumnName("OLU_Owner");
            entity.Property(e => e.OluUser).HasColumnName("OLU_User");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.PosId).HasName("PK__Positions__1ED998B2");

            entity.Property(e => e.PosId).HasColumnName("Pos_ID");
            entity.Property(e => e.PosName)
                .HasMaxLength(125)
                .HasColumnName("Pos_Name");
            entity.Property(e => e.PosPossibleRank1).HasColumnName("Pos_PossibleRank1");
            entity.Property(e => e.PosPossibleRank2).HasColumnName("Pos_PossibleRank2");
            entity.Property(e => e.PosSname)
                .HasMaxLength(100)
                .HasColumnName("Pos_SName");
            entity.Property(e => e.PosSortOrder).HasColumnName("Pos_SortOrder");
        });

        modelBuilder.Entity<Rep>(entity =>
        {
            entity.HasKey(e => e.RepId).HasName("PK_Rep_1");

            entity.ToTable("Rep");

            entity.Property(e => e.RepId).HasColumnName("Rep_ID");
            entity.Property(e => e.RepAttach)
                .HasMaxLength(125)
                .HasColumnName("Rep_Attach");
            entity.Property(e => e.RepCat).HasColumnName("Rep_Cat");
            entity.Property(e => e.RepCatCc).HasColumnName("Rep_CatCC");
            entity.Property(e => e.RepCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("Rep_CreateDate");
            entity.Property(e => e.RepCreateUser).HasColumnName("Rep_CreateUser");
            entity.Property(e => e.RepDate)
                .HasColumnType("datetime")
                .HasColumnName("Rep_Date");
            entity.Property(e => e.RepHeader)
                .HasColumnType("ntext")
                .HasColumnName("Rep_Header");
            entity.Property(e => e.RepIsArchive).HasColumnName("Rep_IsArchive");
            entity.Property(e => e.RepIsPublic).HasColumnName("Rep_IsPublic");
            entity.Property(e => e.RepIsSecret).HasColumnName("Rep_IsSecret");
            entity.Property(e => e.RepIsturndown).HasColumnName("Rep_Isturndown");
            entity.Property(e => e.RepLevel).HasColumnName("Rep_Level");
            entity.Property(e => e.RepMessage)
                .HasColumnType("ntext")
                .HasColumnName("Rep_Message");
            entity.Property(e => e.RepPlace)
                .HasMaxLength(255)
                .HasColumnName("Rep_Place");
            entity.Property(e => e.RepRefNo)
                .HasMaxLength(255)
                .HasColumnName("Rep_RefNo");
            entity.Property(e => e.RepSubject)
                .HasColumnType("ntext")
                .HasColumnName("Rep_Subject");
            entity.Property(e => e.RepTddate)
                .HasColumnType("datetime")
                .HasColumnName("Rep_TDDate");
            entity.Property(e => e.RepUniqueId).HasColumnName("Rep_UniqueID");
        });

        modelBuilder.Entity<RepCat>(entity =>
        {
            entity.HasKey(e => e.RcId).HasName("PK__RepCat__74794A92");

            entity.ToTable("RepCat");

            entity.Property(e => e.RcId).HasColumnName("RC_ID");
            entity.Property(e => e.RcDepartment).HasColumnName("RC_Department");
            entity.Property(e => e.RcIsArchive)
                .HasDefaultValue(false)
                .HasColumnName("RC_IsArchive");
            entity.Property(e => e.RcIsSecret).HasColumnName("RC_IsSecret");
            entity.Property(e => e.RcName)
                .HasMaxLength(500)
                .HasColumnName("RC_Name");
            entity.Property(e => e.RcSection).HasColumnName("RC_Section");
        });

        modelBuilder.Entity<RepCatOldVersion16Feb13>(entity =>
        {
            entity.HasKey(e => e.RcId).HasName("PK__RepCat__31EC6D26");

            entity.ToTable("RepCat_OldVersion16Feb13");

            entity.Property(e => e.RcId).HasColumnName("RC_ID");
            entity.Property(e => e.RcDepartment).HasColumnName("RC_Department");
            entity.Property(e => e.RcIsArchive)
                .HasDefaultValue(false)
                .HasColumnName("RC_IsArchive");
            entity.Property(e => e.RcName)
                .HasColumnType("ntext")
                .HasColumnName("RC_Name");
            entity.Property(e => e.RcSection).HasColumnName("RC_Section");
        });

        modelBuilder.Entity<RepOldVersion16Feb13>(entity =>
        {
            entity.HasKey(e => e.RepId).HasName("PK_Rep");

            entity.ToTable("Rep_OldVersion16Feb13");

            entity.Property(e => e.RepId).HasColumnName("Rep_ID");
            entity.Property(e => e.RepAttach)
                .HasMaxLength(125)
                .HasColumnName("Rep_Attach");
            entity.Property(e => e.RepCat).HasColumnName("Rep_Cat");
            entity.Property(e => e.RepCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("Rep_CreateDate");
            entity.Property(e => e.RepCreateUser).HasColumnName("Rep_CreateUser");
            entity.Property(e => e.RepDate)
                .HasColumnType("datetime")
                .HasColumnName("Rep_Date");
            entity.Property(e => e.RepHeader)
                .HasColumnType("ntext")
                .HasColumnName("Rep_Header");
            entity.Property(e => e.RepIsArchive).HasColumnName("Rep_IsArchive");
            entity.Property(e => e.RepIsPublic).HasColumnName("Rep_IsPublic");
            entity.Property(e => e.RepIsturndown).HasColumnName("Rep_Isturndown");
            entity.Property(e => e.RepLevel).HasColumnName("Rep_Level");
            entity.Property(e => e.RepMessage)
                .HasColumnType("ntext")
                .HasColumnName("Rep_Message");
            entity.Property(e => e.RepPlace)
                .HasMaxLength(255)
                .HasColumnName("Rep_Place");
            entity.Property(e => e.RepRefNo)
                .HasMaxLength(255)
                .HasColumnName("Rep_RefNo");
            entity.Property(e => e.RepSubject)
                .HasColumnType("ntext")
                .HasColumnName("Rep_Subject");
            entity.Property(e => e.RepTddate)
                .HasColumnType("datetime")
                .HasColumnName("Rep_TDDate");
            entity.Property(e => e.RepUniqueId).HasColumnName("Rep_UniqueID");
        });

        modelBuilder.Entity<RepQry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RepQry");

            entity.Property(e => e.RepAttach)
                .HasMaxLength(125)
                .HasColumnName("Rep_Attach");
            entity.Property(e => e.RepCat).HasColumnName("Rep_Cat");
            entity.Property(e => e.RepCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("Rep_CreateDate");
            entity.Property(e => e.RepCreateUser).HasColumnName("Rep_CreateUser");
            entity.Property(e => e.RepDate)
                .HasColumnType("datetime")
                .HasColumnName("Rep_Date");
            entity.Property(e => e.RepHeader)
                .HasColumnType("ntext")
                .HasColumnName("Rep_Header");
            entity.Property(e => e.RepId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Rep_ID");
            entity.Property(e => e.RepIsArchive).HasColumnName("Rep_IsArchive");
            entity.Property(e => e.RepIsPublic).HasColumnName("Rep_IsPublic");
            entity.Property(e => e.RepIsturndown).HasColumnName("Rep_Isturndown");
            entity.Property(e => e.RepLevel).HasColumnName("Rep_Level");
            entity.Property(e => e.RepMessage)
                .HasColumnType("ntext")
                .HasColumnName("Rep_Message");
            entity.Property(e => e.RepPlace)
                .HasMaxLength(255)
                .HasColumnName("Rep_Place");
            entity.Property(e => e.RepRefNo)
                .HasMaxLength(255)
                .HasColumnName("Rep_RefNo");
            entity.Property(e => e.RepSubject)
                .HasColumnType("ntext")
                .HasColumnName("Rep_Subject");
            entity.Property(e => e.RepTddate)
                .HasColumnType("datetime")
                .HasColumnName("Rep_TDDate");
            entity.Property(e => e.RepUniqueId).HasColumnName("Rep_UniqueID");
        });

        modelBuilder.Entity<RepRemark>(entity =>
        {
            entity.HasKey(e => e.RrId).HasName("PK__RepRemark__7849DB76");

            entity.ToTable("RepRemark");

            entity.Property(e => e.RrId).HasColumnName("RR_ID");
            entity.Property(e => e.RrCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("RR_CreateDate");
            entity.Property(e => e.RrRemark)
                .HasColumnType("ntext")
                .HasColumnName("RR_Remark");
            entity.Property(e => e.RrReport).HasColumnName("RR_Report");
            entity.Property(e => e.RrUser).HasColumnName("RR_User");
        });

        modelBuilder.Entity<RepRemarkCategory>(entity =>
        {
            entity.HasKey(e => e.RrcId).HasName("PK__RepRemarkCategor__7A3223E8");

            entity.ToTable("RepRemarkCategory");

            entity.Property(e => e.RrcId).HasColumnName("RRC_ID");
            entity.Property(e => e.RrcCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("RRC_CreateDate");
            entity.Property(e => e.RrcSortOrder).HasColumnName("RRC_SortOrder");
            entity.Property(e => e.RrcTitle)
                .HasMaxLength(400)
                .HasColumnName("RRC_Title");
        });

        modelBuilder.Entity<RepRemarkCategoryOldVersion16Feb13>(entity =>
        {
            entity.HasKey(e => e.RrcId).HasName("PK_RepRemarkCategory");

            entity.ToTable("RepRemarkCategory_OldVersion16Feb13");

            entity.Property(e => e.RrcId).HasColumnName("RRC_ID");
            entity.Property(e => e.RrcCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("RRC_CreateDate");
            entity.Property(e => e.RrcSortOrder).HasColumnName("RRC_SortOrder");
            entity.Property(e => e.RrcTitle)
                .HasMaxLength(400)
                .HasColumnName("RRC_Title");
        });

        modelBuilder.Entity<RepRemarkOldVersion16Feb13>(entity =>
        {
            entity.HasKey(e => e.RrId).HasName("PK_RepRemark");

            entity.ToTable("RepRemark_OldVersion16Feb13");

            entity.Property(e => e.RrId).HasColumnName("RR_ID");
            entity.Property(e => e.RrCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("RR_CreateDate");
            entity.Property(e => e.RrRemark)
                .HasColumnType("ntext")
                .HasColumnName("RR_Remark");
            entity.Property(e => e.RrReport).HasColumnName("RR_Report");
            entity.Property(e => e.RrUser).HasColumnName("RR_User");
        });

        modelBuilder.Entity<RepRemarkQry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RepRemarkQry");

            entity.Property(e => e.RrId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RR_ID");
        });

        modelBuilder.Entity<RepRemarkType>(entity =>
        {
            entity.HasKey(e => e.RremarkId).HasName("PK__RepRemarkType__7C1A6C5A");

            entity.ToTable("RepRemarkType");

            entity.Property(e => e.RremarkId).HasColumnName("RRemark_ID");
            entity.Property(e => e.RremarkCategory).HasColumnName("RRemark_Category");
            entity.Property(e => e.RremarkPos).HasColumnName("RRemark_Pos");
            entity.Property(e => e.RremarkRemark)
                .HasMaxLength(255)
                .HasColumnName("RRemark_Remark");
            entity.Property(e => e.RremarkSortOrder).HasColumnName("RRemark_SortOrder");
            entity.Property(e => e.RremarkType).HasColumnName("RRemark_Type");
        });

        modelBuilder.Entity<RepRemarkTypeOldVersion16Feb13>(entity =>
        {
            entity.HasKey(e => e.RremarkId).HasName("PK_RepRemarkType");

            entity.ToTable("RepRemarkType_OldVersion16Feb13");

            entity.Property(e => e.RremarkId).HasColumnName("RRemark_ID");
            entity.Property(e => e.RremarkCategory).HasColumnName("RRemark_Category");
            entity.Property(e => e.RremarkPos).HasColumnName("RRemark_Pos");
            entity.Property(e => e.RremarkRemark)
                .HasMaxLength(255)
                .HasColumnName("RRemark_Remark");
            entity.Property(e => e.RremarkSortOrder).HasColumnName("RRemark_SortOrder");
            entity.Property(e => e.RremarkType).HasColumnName("RRemark_Type");
        });

        modelBuilder.Entity<RepRemarkTypebk>(entity =>
        {
            entity.HasKey(e => e.RremarkId).HasName("PK__RepRemarkType__3D5E1FD2");

            entity.ToTable("RepRemarkTypebk");

            entity.Property(e => e.RremarkId).HasColumnName("RRemark_ID");
            entity.Property(e => e.RremarkCategory).HasColumnName("RRemark_Category");
            entity.Property(e => e.RremarkPos).HasColumnName("RRemark_Pos");
            entity.Property(e => e.RremarkRemark)
                .HasColumnType("ntext")
                .HasColumnName("RRemark_Remark");
            entity.Property(e => e.RremarkSortOrder)
                .HasDefaultValue(99)
                .HasColumnName("RRemark_SortOrder");
            entity.Property(e => e.RremarkType).HasColumnName("RRemark_Type");
        });

        modelBuilder.Entity<RepShare>(entity =>
        {
            entity.HasKey(e => e.RshareId).HasName("PK__RepShare__7E02B4CC");

            entity.ToTable("RepShare");

            entity.Property(e => e.RshareId).HasColumnName("RShare_ID");
            entity.Property(e => e.RshareCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("RShare_CreateDate");
            entity.Property(e => e.RshareIsRead).HasColumnName("RShare_IsRead");
            entity.Property(e => e.RshareOwner).HasColumnName("RShare_Owner");
            entity.Property(e => e.RshareRemark)
                .HasColumnType("ntext")
                .HasColumnName("RShare_Remark");
            entity.Property(e => e.RshareRep).HasColumnName("RShare_Rep");
            entity.Property(e => e.RshareTo).HasColumnName("RShare_To");
            entity.Property(e => e.RshareUsers)
                .HasMaxLength(255)
                .HasColumnName("RShare_Users");
        });

        modelBuilder.Entity<RepShareOldVersion16Feb13>(entity =>
        {
            entity.HasKey(e => e.RshareId).HasName("PK__RepShare__440B1D61");

            entity.ToTable("RepShare_OldVersion16Feb13");

            entity.Property(e => e.RshareId).HasColumnName("RShare_ID");
            entity.Property(e => e.RshareCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("RShare_CreateDate");
            entity.Property(e => e.RshareIsRead).HasColumnName("RShare_IsRead");
            entity.Property(e => e.RshareOwner).HasColumnName("RShare_Owner");
            entity.Property(e => e.RshareRemark)
                .HasColumnType("ntext")
                .HasColumnName("RShare_Remark");
            entity.Property(e => e.RshareRep).HasColumnName("RShare_Rep");
            entity.Property(e => e.RshareTo).HasColumnName("RShare_To");
            entity.Property(e => e.RshareUsers)
                .HasMaxLength(255)
                .HasColumnName("RShare_Users");
        });

        modelBuilder.Entity<RepTran>(entity =>
        {
            entity.HasKey(e => e.RtId).HasName("PK__RepTran__7FEAFD3E");

            entity.ToTable("RepTran");

            entity.Property(e => e.RtId).HasColumnName("RT_ID");
            entity.Property(e => e.RtCreateUser).HasColumnName("RT_CreateUser");
            entity.Property(e => e.RtDate)
                .HasColumnType("datetime")
                .HasColumnName("RT_Date");
            entity.Property(e => e.RtFile)
                .HasMaxLength(125)
                .HasColumnName("RT_File");
            entity.Property(e => e.RtLevel).HasColumnName("RT_Level");
            entity.Property(e => e.RtRemark)
                .HasColumnType("ntext")
                .HasColumnName("RT_Remark");
            entity.Property(e => e.RtReport).HasColumnName("RT_Report");
        });

        modelBuilder.Entity<RepTranOldVersion16Feb13>(entity =>
        {
            entity.HasKey(e => e.RtId).HasName("PK__RepTran__2C3393D0");

            entity.ToTable("RepTran_OldVersion16Feb13");

            entity.Property(e => e.RtId).HasColumnName("RT_ID");
            entity.Property(e => e.RtCreateUser).HasColumnName("RT_CreateUser");
            entity.Property(e => e.RtDate)
                .HasColumnType("datetime")
                .HasColumnName("RT_Date");
            entity.Property(e => e.RtFile)
                .HasMaxLength(125)
                .HasColumnName("RT_File");
            entity.Property(e => e.RtLevel).HasColumnName("RT_Level");
            entity.Property(e => e.RtRemark)
                .HasColumnType("ntext")
                .HasColumnName("RT_Remark");
            entity.Property(e => e.RtReport).HasColumnName("RT_Report");
        });

        modelBuilder.Entity<RepUser>(entity =>
        {
            entity.HasKey(e => e.RuId).HasName("PK__RepUsers__01D345B0");

            entity.Property(e => e.RuId).HasColumnName("RU_ID");
            entity.Property(e => e.RuIsTransaction).HasColumnName("RU_IsTransaction");
            entity.Property(e => e.RuReport).HasColumnName("RU_Report");
            entity.Property(e => e.RuUser).HasColumnName("RU_User");
        });

        modelBuilder.Entity<RepUsersOldVersion16Feb13>(entity =>
        {
            entity.HasKey(e => e.RuId).HasName("PK__RepUsers__2E1BDC42");

            entity.ToTable("RepUsers_OldVersion16Feb13");

            entity.Property(e => e.RuId).HasColumnName("RU_ID");
            entity.Property(e => e.RuIsTransaction).HasColumnName("RU_IsTransaction");
            entity.Property(e => e.RuReport).HasColumnName("RU_Report");
            entity.Property(e => e.RuUser).HasColumnName("RU_User");
        });

        modelBuilder.Entity<ReportHead>(entity =>
        {
            entity.HasKey(e => e.RhId).HasName("PK__ReportHead__76619304");

            entity.ToTable("ReportHead");

            entity.Property(e => e.RhId).HasColumnName("RH_ID");
            entity.Property(e => e.RhDepartment).HasColumnName("RH_Department");
            entity.Property(e => e.RhText)
                .HasColumnType("ntext")
                .HasColumnName("RH_Text");
        });

        modelBuilder.Entity<ReportHeadOldVersion16Feb13>(entity =>
        {
            entity.HasKey(e => e.RhId).HasName("PK__ReportHead__4222D4EF");

            entity.ToTable("ReportHead_OldVersion16Feb13");

            entity.Property(e => e.RhId).HasColumnName("RH_ID");
            entity.Property(e => e.RhDepartment).HasColumnName("RH_Department");
            entity.Property(e => e.RhText)
                .HasColumnType("ntext")
                .HasColumnName("RH_Text");
        });

        modelBuilder.Entity<Section>(entity =>
        {
            entity.HasKey(e => e.SecId).HasName("PK__Sections__1B0907CE");

            entity.Property(e => e.SecId).HasColumnName("Sec_ID");
            entity.Property(e => e.SecDepartment).HasColumnName("Sec_Department");
            entity.Property(e => e.SecName)
                .HasMaxLength(500)
                .HasColumnName("Sec_Name");
            entity.Property(e => e.SecPhoneExt)
                .HasMaxLength(125)
                .HasColumnName("Sec_PhoneExt");
            entity.Property(e => e.SecSname)
                .HasMaxLength(125)
                .HasColumnName("Sec_SName");
        });

        modelBuilder.Entity<SubSection>(entity =>
        {
            entity.HasKey(e => e.SsId);

            entity.ToTable("Sub_Sections");

            entity.Property(e => e.SsId).HasColumnName("SS_ID");
            entity.Property(e => e.SsDepartment).HasColumnName("SS_Department");
            entity.Property(e => e.SsSection).HasColumnName("SS_Section");
            entity.Property(e => e.SsSortOrder).HasColumnName("SS_SortOrder");
            entity.Property(e => e.SsTitle)
                .HasMaxLength(1000)
                .HasColumnName("SS_Title");
        });

        modelBuilder.Entity<SysLink>(entity =>
        {
            entity.HasKey(e => e.SlinkId).HasName("PK__SysLinks__398D8EEE");

            entity.Property(e => e.SlinkId).HasColumnName("SLink_ID");
            entity.Property(e => e.SlinkCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("SLink_CreateDate");
            entity.Property(e => e.SlinkCreateUser).HasColumnName("SLink_CreateUser");
            entity.Property(e => e.SlinkLink)
                .HasMaxLength(255)
                .HasColumnName("SLink_Link");
            entity.Property(e => e.SlinkTitle)
                .HasMaxLength(255)
                .HasColumnName("SLink_Title");
        });

        modelBuilder.Entity<Tduser>(entity =>
        {
            entity.HasKey(e => e.TduId).HasName("PK__TDUsers__5629CD9C");

            entity.ToTable("TDUsers");

            entity.Property(e => e.TduId).HasColumnName("TDU_ID");
            entity.Property(e => e.TduReport).HasColumnName("TDU_Report");
            entity.Property(e => e.TduUser).HasColumnName("TDU_User");
        });

        modelBuilder.Entity<Text>(entity =>
        {
            entity.HasKey(e => e.TextId).HasName("PK__Text__33D4B598");

            entity.ToTable("Text");

            entity.Property(e => e.TextId).HasColumnName("Text_ID");
            entity.Property(e => e.TextName)
                .HasColumnType("ntext")
                .HasColumnName("Text_Name");
            entity.Property(e => e.TextType)
                .HasMaxLength(125)
                .HasColumnName("Text_Type");
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("User Account");

            entity.Property(e => e.EActive).HasColumnName("E_Active");
            entity.Property(e => e.EAddr1)
                .HasMaxLength(125)
                .HasColumnName("E_Addr1");
            entity.Property(e => e.EAddr2)
                .HasMaxLength(125)
                .HasColumnName("E_Addr2");
            entity.Property(e => e.EAddr3)
                .HasMaxLength(125)
                .HasColumnName("E_Addr3");
            entity.Property(e => e.EAddr4)
                .HasMaxLength(125)
                .HasColumnName("E_Addr4");
            entity.Property(e => e.ECategories).HasColumnName("E_Categories");
            entity.Property(e => e.ECreateDate)
                .HasColumnType("datetime")
                .HasColumnName("E_CreateDate");
            entity.Property(e => e.EDepartment).HasColumnName("E_Department");
            entity.Property(e => e.EDutyCategory).HasColumnName("E_DutyCategory");
            entity.Property(e => e.EEditDate)
                .HasColumnType("datetime")
                .HasColumnName("E_EditDate");
            entity.Property(e => e.EEmail)
                .HasMaxLength(125)
                .HasColumnName("E_Email");
            entity.Property(e => e.EFullname)
                .HasMaxLength(125)
                .HasColumnName("E_Fullname");
            entity.Property(e => e.EGender).HasColumnName("E_Gender");
            entity.Property(e => e.EHeadRank).HasColumnName("E_HeadRank");
            entity.Property(e => e.EId)
                .ValueGeneratedOnAdd()
                .HasColumnName("E_ID");
            entity.Property(e => e.EIsHead).HasColumnName("E_IsHead");
            entity.Property(e => e.ELevel).HasColumnName("E_Level");
            entity.Property(e => e.EMobile)
                .HasMaxLength(125)
                .HasColumnName("E_Mobile");
            entity.Property(e => e.EName)
                .HasMaxLength(125)
                .HasColumnName("E_Name");
            entity.Property(e => e.ENo).HasColumnName("E_No");
            entity.Property(e => e.ENotes)
                .HasColumnType("ntext")
                .HasColumnName("E_Notes");
            entity.Property(e => e.EPassword)
                .HasMaxLength(125)
                .HasColumnName("E_Password");
            entity.Property(e => e.EPhone)
                .HasMaxLength(125)
                .HasColumnName("E_Phone");
            entity.Property(e => e.EPhoneExt)
                .HasMaxLength(125)
                .HasColumnName("E_PhoneExt");
            entity.Property(e => e.EPosition).HasColumnName("E_Position");
            entity.Property(e => e.EProfession).HasColumnName("E_Profession");
            entity.Property(e => e.ERank).HasColumnName("E_Rank");
            entity.Property(e => e.ERepType).HasColumnName("E_RepType");
            entity.Property(e => e.ESection).HasColumnName("E_Section");
            entity.Property(e => e.EStartDate)
                .HasColumnType("datetime")
                .HasColumnName("E_StartDate");
            entity.Property(e => e.ETitle)
                .HasMaxLength(125)
                .HasColumnName("E_Title");
        });

        modelBuilder.Entity<UserLevel>(entity =>
        {
            entity.HasKey(e => e.UlId).HasName("PK__UserLevel__1CF15040");

            entity.ToTable("UserLevel");

            entity.Property(e => e.UlId).HasColumnName("UL_ID");
            entity.Property(e => e.UlLevel).HasColumnName("UL_Level");
            entity.Property(e => e.UlTitle)
                .HasMaxLength(125)
                .HasColumnName("UL_Title");
        });

        modelBuilder.Entity<Venue>(entity =>
        {
            entity.HasKey(e => e.VId).HasName("PK__Venue__61F3893D3BFFE745");

            entity.ToTable("Venue");

            entity.Property(e => e.VId).HasColumnName("V_ID");
            entity.Property(e => e.VName)
                .HasMaxLength(500)
                .HasColumnName("V_Name");
            entity.Property(e => e.VSortOrder).HasColumnName("V_SortOrder");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
