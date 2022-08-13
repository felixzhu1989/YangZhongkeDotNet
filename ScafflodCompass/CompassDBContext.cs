using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScafflodCompass
{
    public partial class CompassDBContext : DbContext
    {
        public CompassDBContext()
        {
        }

        public CompassDBContext(DbContextOptions<CompassDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abd200> Abd200s { get; set; } = null!;
        public virtual DbSet<Abd300> Abd300s { get; set; } = null!;
        public virtual DbSet<AfterSaleFeedback> AfterSaleFeedbacks { get; set; } = null!;
        public virtual DbSet<An> Ans { get; set; } = null!;
        public virtual DbSet<Bcj300> Bcj300s { get; set; } = null!;
        public virtual DbSet<Bcj330> Bcj330s { get; set; } = null!;
        public virtual DbSet<Bf200> Bf200s { get; set; } = null!;
        public virtual DbSet<CategoriesMarine> CategoriesMarines { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<CeilingAccessory> CeilingAccessories { get; set; } = null!;
        public virtual DbSet<CeilingCutList> CeilingCutLists { get; set; } = null!;
        public virtual DbSet<CeilingPackingList> CeilingPackingLists { get; set; } = null!;
        public virtual DbSet<Ch610> Ch610s { get; set; } = null!;
        public virtual DbSet<CheckComment> CheckComments { get; set; } = null!;
        public virtual DbSet<Cj300> Cj300s { get; set; } = null!;
        public virtual DbSet<Cj330> Cj330s { get; set; } = null!;
        public virtual DbSet<Cmodf555> Cmodf555s { get; set; } = null!;
        public virtual DbSet<Cmodf555400> Cmodf555400s { get; set; } = null!;
        public virtual DbSet<Cmodf700t> Cmodf700ts { get; set; } = null!;
        public virtual DbSet<Cmodi555> Cmodi555s { get; set; } = null!;
        public virtual DbSet<Cmodi700t> Cmodi700ts { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<DesignWorkload> DesignWorkloads { get; set; } = null!;
        public virtual DbSet<DesignWorkloadMarine> DesignWorkloadMarines { get; set; } = null!;
        public virtual DbSet<Dp330> Dp330s { get; set; } = null!;
        public virtual DbSet<Dp340> Dp340s { get; set; } = null!;
        public virtual DbSet<Dpcj330> Dpcj330s { get; set; } = null!;
        public virtual DbSet<DrawingNumCodeRule> DrawingNumCodeRules { get; set; } = null!;
        public virtual DbSet<DrawingNumMatrix> DrawingNumMatrices { get; set; } = null!;
        public virtual DbSet<DrawingPlan> DrawingPlans { get; set; } = null!;
        public virtual DbSet<DrawingPlanMarine> DrawingPlanMarines { get; set; } = null!;
        public virtual DbSet<DxfcutList> DxfcutLists { get; set; } = null!;
        public virtual DbSet<FinancialDataMarine> FinancialDataMarines { get; set; } = null!;
        public virtual DbSet<FinancialDatum> FinancialData { get; set; } = null!;
        public virtual DbSet<Frkvf555> Frkvf555s { get; set; } = null!;
        public virtual DbSet<Fruvf555> Fruvf555s { get; set; } = null!;
        public virtual DbSet<GeneralRequirement> GeneralRequirements { get; set; } = null!;
        public virtual DbSet<GeneralRequirementsMarine> GeneralRequirementsMarines { get; set; } = null!;
        public virtual DbSet<Hme> Hmes { get; set; } = null!;
        public virtual DbSet<Hmf> Hmfs { get; set; } = null!;
        public virtual DbSet<Hmm> Hmms { get; set; } = null!;
        public virtual DbSet<HoodCutList> HoodCutLists { get; set; } = null!;
        public virtual DbSet<Hoodbcj> Hoodbcjs { get; set; } = null!;
        public virtual DbSet<Hwuvf555400> Hwuvf555400s { get; set; } = null!;
        public virtual DbSet<Hwuvf650> Hwuvf650s { get; set; } = null!;
        public virtual DbSet<Hwuvi650> Hwuvi650s { get; set; } = null!;
        public virtual DbSet<Hwuwf555> Hwuwf555s { get; set; } = null!;
        public virtual DbSet<Hwuwf555400> Hwuwf555400s { get; set; } = null!;
        public virtual DbSet<Hwuwf650> Hwuwf650s { get; set; } = null!;
        public virtual DbSet<Inf> Infs { get; set; } = null!;
        public virtual DbSet<Kchf555> Kchf555s { get; set; } = null!;
        public virtual DbSet<Kchi555> Kchi555s { get; set; } = null!;
        public virtual DbSet<Kcjdb800> Kcjdb800s { get; set; } = null!;
        public virtual DbSet<Kcjsb265> Kcjsb265s { get; set; } = null!;
        public virtual DbSet<Kcjsb290> Kcjsb290s { get; set; } = null!;
        public virtual DbSet<Kcjsb535> Kcjsb535s { get; set; } = null!;
        public virtual DbSet<Kcwdb800> Kcwdb800s { get; set; } = null!;
        public virtual DbSet<Kcwsb265> Kcwsb265s { get; set; } = null!;
        public virtual DbSet<Kcwsb535> Kcwsb535s { get; set; } = null!;
        public virtual DbSet<Kv> Kvs { get; set; } = null!;
        public virtual DbSet<Kvf400> Kvf400s { get; set; } = null!;
        public virtual DbSet<Kvf450400> Kvf450400s { get; set; } = null!;
        public virtual DbSet<Kvf555> Kvf555s { get; set; } = null!;
        public virtual DbSet<Kvf555400> Kvf555400s { get; set; } = null!;
        public virtual DbSet<Kvi400> Kvi400s { get; set; } = null!;
        public virtual DbSet<Kvi450300> Kvi450300s { get; set; } = null!;
        public virtual DbSet<Kvi555> Kvi555s { get; set; } = null!;
        public virtual DbSet<Kvimr555> Kvimr555s { get; set; } = null!;
        public virtual DbSet<Kvir555> Kvir555s { get; set; } = null!;
        public virtual DbSet<Kvv555> Kvv555s { get; set; } = null!;
        public virtual DbSet<Kwf555> Kwf555s { get; set; } = null!;
        public virtual DbSet<Kwi555> Kwi555s { get; set; } = null!;
        public virtual DbSet<Lfumc150dxf> Lfumc150dxfs { get; set; } = null!;
        public virtual DbSet<Lfumc150susdxf> Lfumc150susdxfs { get; set; } = null!;
        public virtual DbSet<Lfumc200dxf> Lfumc200dxfs { get; set; } = null!;
        public virtual DbSet<Lfumc200susdxf> Lfumc200susdxfs { get; set; } = null!;
        public virtual DbSet<Lfumc250dxf> Lfumc250dxfs { get; set; } = null!;
        public virtual DbSet<Lfumc250susdxf> Lfumc250susdxfs { get; set; } = null!;
        public virtual DbSet<Lfup> Lfups { get; set; } = null!;
        public virtual DbSet<Lfusa> Lfusas { get; set; } = null!;
        public virtual DbSet<Lfusc> Lfuscs { get; set; } = null!;
        public virtual DbSet<Lfuss> Lfusses { get; set; } = null!;
        public virtual DbSet<Lka258> Lka258s { get; set; } = null!;
        public virtual DbSet<Lkaspec> Lkaspecs { get; set; } = null!;
        public virtual DbSet<Lks258hcl> Lks258hcls { get; set; } = null!;
        public virtual DbSet<Lks270> Lks270s { get; set; } = null!;
        public virtual DbSet<Lks270hcl> Lks270hcls { get; set; } = null!;
        public virtual DbSet<Lksspec> Lksspecs { get; set; } = null!;
        public virtual DbSet<Lkst270> Lkst270s { get; set; } = null!;
        public virtual DbSet<Lled> Lleds { get; set; } = null!;
        public virtual DbSet<Lledum> Lleda { get; set; } = null!;
        public virtual DbSet<Llk> Llks { get; set; } = null!;
        public virtual DbSet<Llka> Llkas { get; set; } = null!;
        public virtual DbSet<Llkaj> Llkajs { get; set; } = null!;
        public virtual DbSet<Llksj> Llksjs { get; set; } = null!;
        public virtual DbSet<Lpz> Lpzs { get; set; } = null!;
        public virtual DbSet<Lsdost> Lsdosts { get; set; } = null!;
        public virtual DbSet<Mcpdxf> Mcpdxfs { get; set; } = null!;
        public virtual DbSet<ModuleTree> ModuleTrees { get; set; } = null!;
        public virtual DbSet<ModuleTreeMarine> ModuleTreeMarines { get; set; } = null!;
        public virtual DbSet<Mu1boxdxf> Mu1boxdxfs { get; set; } = null!;
        public virtual DbSet<Nocj300> Nocj300s { get; set; } = null!;
        public virtual DbSet<Nocj330> Nocj330s { get; set; } = null!;
        public virtual DbSet<Nocj340> Nocj340s { get; set; } = null!;
        public virtual DbSet<Nocjspec> Nocjspecs { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<ProjectLearned> ProjectLearneds { get; set; } = null!;
        public virtual DbSet<ProjectStatus> ProjectStatuses { get; set; } = null!;
        public virtual DbSet<ProjectTracking> ProjectTrackings { get; set; } = null!;
        public virtual DbSet<ProjectTrackingMarine> ProjectTrackingMarines { get; set; } = null!;
        public virtual DbSet<ProjectType> ProjectTypes { get; set; } = null!;
        public virtual DbSet<ProjectTypesMarine> ProjectTypesMarines { get; set; } = null!;
        public virtual DbSet<ProjectsMarine> ProjectsMarines { get; set; } = null!;
        public virtual DbSet<QualityFeedback> QualityFeedbacks { get; set; } = null!;
        public virtual DbSet<SemiBom> SemiBoms { get; set; } = null!;
        public virtual DbSet<SpecialRequirement> SpecialRequirements { get; set; } = null!;
        public virtual DbSet<SpecialRequirementsMarine> SpecialRequirementsMarines { get; set; } = null!;
        public virtual DbSet<Sspdome> Sspdomes { get; set; } = null!;
        public virtual DbSet<Sspflat> Sspflats { get; set; } = null!;
        public virtual DbSet<Ssphfd> Ssphfds { get; set; } = null!;
        public virtual DbSet<Ssptbd> Ssptbds { get; set; } = null!;
        public virtual DbSet<Ssptsd> Ssptsds { get; set; } = null!;
        public virtual DbSet<SubAssy> SubAssies { get; set; } = null!;
        public virtual DbSet<Tcsboxdxf> Tcsboxdxfs { get; set; } = null!;
        public virtual DbSet<Ucjdb800> Ucjdb800s { get; set; } = null!;
        public virtual DbSet<Ucjfccombidxf> Ucjfccombidxfs { get; set; } = null!;
        public virtual DbSet<Ucjsb385> Ucjsb385s { get; set; } = null!;
        public virtual DbSet<Ucjsb535> Ucjsb535s { get; set; } = null!;
        public virtual DbSet<Ucpdxf> Ucpdxfs { get; set; } = null!;
        public virtual DbSet<Ucwdb800> Ucwdb800s { get; set; } = null!;
        public virtual DbSet<Ucwsb535> Ucwsb535s { get; set; } = null!;
        public virtual DbSet<Ucwuvr4ldxf> Ucwuvr4ldxfs { get; set; } = null!;
        public virtual DbSet<Ucwuvr4sdxf> Ucwuvr4sdxfs { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserGroup> UserGroups { get; set; } = null!;
        public virtual DbSet<Uvf450> Uvf450s { get; set; } = null!;
        public virtual DbSet<Uvf450400> Uvf450400s { get; set; } = null!;
        public virtual DbSet<Uvf555> Uvf555s { get; set; } = null!;
        public virtual DbSet<Uvf555400> Uvf555400s { get; set; } = null!;
        public virtual DbSet<Uvi450300> Uvi450300s { get; set; } = null!;
        public virtual DbSet<Uvi555> Uvi555s { get; set; } = null!;
        public virtual DbSet<Uvi555400> Uvi555400s { get; set; } = null!;
        public virtual DbSet<Uvimr555> Uvimr555s { get; set; } = null!;
        public virtual DbSet<Uvimt555> Uvimt555s { get; set; } = null!;
        public virtual DbSet<Uvir555> Uvir555s { get; set; } = null!;
        public virtual DbSet<Uwf555> Uwf555s { get; set; } = null!;
        public virtual DbSet<Uwf555400> Uwf555400s { get; set; } = null!;
        public virtual DbSet<Uwi555> Uwi555s { get; set; } = null!;
        public virtual DbSet<ViewDelayQuery> ViewDelayQueries { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PDMSERVER\\SQLEXPRESSHALTON; Database=CompassDB; User Id = sa; Password=Epdm2018;TrustServerCertificate=true;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abd200>(entity =>
            {
                entity.ToTable("ABD200");

                entity.Property(e => e.Abd200id).HasColumnName("ABD200Id");

                entity.Property(e => e.Deepth)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((300))");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('200')");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('BOTH')");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Abd200s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_ABD200");
            });

            modelBuilder.Entity<Abd300>(entity =>
            {
                entity.ToTable("ABD300");

                entity.Property(e => e.Abd300id).HasColumnName("ABD300Id");

                entity.Property(e => e.Deepth)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((300))");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('300')");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('BOTH')");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Abd300s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_ABD300");
            });

            modelBuilder.Entity<AfterSaleFeedback>(entity =>
            {
                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Content)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AfterSaleFeedbacks)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_AF");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AfterSaleFeedbacks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AddedBy_AF");
            });

            modelBuilder.Entity<An>(entity =>
            {
                entity.ToTable("AN");

                entity.Property(e => e.Anid).HasColumnName("ANId");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Ans)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_AN");
            });

            modelBuilder.Entity<Bcj300>(entity =>
            {
                entity.ToTable("BCJ300");

                entity.Property(e => e.Bcj300id).HasColumnName("BCJ300Id");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SuType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Bcj300s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_BCJ300");
            });

            modelBuilder.Entity<Bcj330>(entity =>
            {
                entity.ToTable("BCJ330");

                entity.Property(e => e.Bcj330id).HasColumnName("BCJ330Id");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SuType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Bcj330s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_BCJ330");
            });

            modelBuilder.Entity<Bf200>(entity =>
            {
                entity.ToTable("BF200");

                entity.Property(e => e.Bf200id).HasColumnName("BF200Id");

                entity.Property(e => e.LeftLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.MpanelLength)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("MPanelLength");

                entity.Property(e => e.MpanelNo).HasColumnName("MPanelNo");

                entity.Property(e => e.RightLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WpanelLength)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("WPanelLength");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Bf200s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_BF200");
            });

            modelBuilder.Entity<CategoriesMarine>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("pk_CategoryIdMarine");

                entity.ToTable("CategoriesMarine");

                entity.HasIndex(e => e.CategoryName, "uq_CategoryNameMarine")
                    .IsUnique();

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.CategoryDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('请添加描述')");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kmlink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("KMLink")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastSaved)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModelImage)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModelPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ParentIdMarine");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.CategoryName, "uq_CategoryName")
                    .IsUnique();

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.CategoryDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('请添加描述')");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kmlink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("KMLink")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastSaved)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModelImage)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModelPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ParientId");
            });

            modelBuilder.Entity<CeilingAccessory>(entity =>
            {
                entity.Property(e => e.CeilingAccessoryId)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ClassNo).HasDefaultValueSql("((3))");

                entity.Property(e => e.CountingRule)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Height)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Length)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Material)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PartDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCS')");

                entity.Property(e => e.Width)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CeilingCutList>(entity =>
            {
                entity.HasKey(e => e.CutListId)
                    .HasName("pk_CutListId_Ceiling");

                entity.ToTable("CeilingCutList");

                entity.HasIndex(e => new { e.SubAssyId, e.PartNo }, "uq_CeilingCutList")
                    .IsUnique();

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Materials)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PartDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Thickness).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.SubAssy)
                    .WithMany(p => p.CeilingCutLists)
                    .HasForeignKey(d => d.SubAssyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SubAssyId_CeilingCutList");
            });

            modelBuilder.Entity<CeilingPackingList>(entity =>
            {
                entity.ToTable("CeilingPackingList");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CeilingAccessoryId)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ClassNo).HasDefaultValueSql("((3))");

                entity.Property(e => e.CountingRule)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Height)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Length)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('AREA1')");

                entity.Property(e => e.Material)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PartDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCS')");

                entity.Property(e => e.Width)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CeilingPackingLists)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_CeilingPackingList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CeilingPackingLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AddedBy_CeilingPackingList");
            });

            modelBuilder.Entity<Ch610>(entity =>
            {
                entity.ToTable("CH610");

                entity.Property(e => e.Ch610id).HasColumnName("CH610Id");

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('610')");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('BOTH')");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Ch610s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_CH610");
            });

            modelBuilder.Entity<CheckComment>(entity =>
            {
                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Content)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CheckComments)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_CC");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CheckComments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AddedBy_CC");
            });

            modelBuilder.Entity<Cj300>(entity =>
            {
                entity.ToTable("CJ300");

                entity.Property(e => e.Cj300id).HasColumnName("CJ300Id");

                entity.Property(e => e.BackCjside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BackCJSide");

                entity.Property(e => e.GutterSide)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LeftDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Lkside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LKSide");

                entity.Property(e => e.RightBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RightBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SuType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Cj300s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_CJ300");
            });

            modelBuilder.Entity<Cj330>(entity =>
            {
                entity.ToTable("CJ330");

                entity.Property(e => e.Cj330id).HasColumnName("CJ330Id");

                entity.Property(e => e.BackCjside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BackCJSide");

                entity.Property(e => e.GutterSide)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LeftDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Lkside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LKSide");

                entity.Property(e => e.RightBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RightBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SuType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Cj330s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_CJ330");
            });

            modelBuilder.Entity<Cmodf555>(entity =>
            {
                entity.ToTable("CMODF555");

                entity.Property(e => e.Cmodf555id).HasColumnName("CMODF555Id");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Inlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Cmodf555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_CMODF555");
            });

            modelBuilder.Entity<Cmodf555400>(entity =>
            {
                entity.ToTable("CMODF555400");

                entity.Property(e => e.Cmodf555400id).HasColumnName("CMODF555400Id");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Inlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Cmodf555400s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_CMODF555400");
            });

            modelBuilder.Entity<Cmodf700t>(entity =>
            {
                entity.HasKey(e => e.Cmodf700tsid)
                    .HasName("pk_CMODF700TSId");

                entity.ToTable("CMODF700TS");

                entity.Property(e => e.Cmodf700tsid).HasColumnName("CMODF700TSId");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('700')");

                entity.Property(e => e.Inlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Cmodf700ts)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_CMODF700TS");
            });

            modelBuilder.Entity<Cmodi555>(entity =>
            {
                entity.ToTable("CMODI555");

                entity.Property(e => e.Cmodi555id).HasColumnName("CMODI555Id");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Inlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Cmodi555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_CMODI555");
            });

            modelBuilder.Entity<Cmodi700t>(entity =>
            {
                entity.HasKey(e => e.Cmodi700tsid)
                    .HasName("pk_CMODI700TSId");

                entity.ToTable("CMODI700TS");

                entity.Property(e => e.Cmodi700tsid).HasColumnName("CMODI700TSId");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('700')");

                entity.Property(e => e.Inlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Cmodi700ts)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_CMODI700TS");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.CustomerName, "uq_CustomerName")
                    .IsUnique();

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DesignWorkload>(entity =>
            {
                entity.HasKey(e => e.WorkloadId)
                    .HasName("pk_WorkloadId");

                entity.ToTable("DesignWorkload");

                entity.HasIndex(e => e.Model, "uq_Model_DesignWorkload")
                    .IsUnique();

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModelDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkloadValue).HasColumnType("decimal(4, 2)");
            });

            modelBuilder.Entity<DesignWorkloadMarine>(entity =>
            {
                entity.HasKey(e => e.WorkloadId)
                    .HasName("pk_WorkloadIdMarine");

                entity.ToTable("DesignWorkloadMarine");

                entity.HasIndex(e => e.Model, "uq_Model_DesignWorkloadMarine")
                    .IsUnique();

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModelDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkloadValue).HasColumnType("decimal(4, 2)");
            });

            modelBuilder.Entity<Dp330>(entity =>
            {
                entity.ToTable("DP330");

                entity.Property(e => e.Dp330id).HasColumnName("DP330Id");

                entity.Property(e => e.BackCjside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BackCJSide");

                entity.Property(e => e.Dpside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DPSide");

                entity.Property(e => e.GutterSide)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LeftDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Lkside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LKSide");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RightBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RightBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Dp330s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_DP330");
            });

            modelBuilder.Entity<Dp340>(entity =>
            {
                entity.ToTable("DP340");

                entity.Property(e => e.Dp340id).HasColumnName("DP340Id");

                entity.Property(e => e.BackCjside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BackCJSide");

                entity.Property(e => e.Dpside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DPSide");

                entity.Property(e => e.GutterSide)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LeftDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Lkside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LKSide");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RightBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RightBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Dp340s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_DP340");
            });

            modelBuilder.Entity<Dpcj330>(entity =>
            {
                entity.ToTable("DPCJ330");

                entity.Property(e => e.Dpcj330id).HasColumnName("DPCJ330Id");

                entity.Property(e => e.BackCjside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BackCJSide");

                entity.Property(e => e.Dpside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DPSide");

                entity.Property(e => e.GutterSide)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LeftDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Lkside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LKSide");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RightBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RightBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SuType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Dpcj330s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_DPCJ330");
            });

            modelBuilder.Entity<DrawingNumCodeRule>(entity =>
            {
                entity.HasKey(e => e.CodeId)
                    .HasName("pk_CodeId");

                entity.ToTable("DrawingNumCodeRule");

                entity.Property(e => e.CodeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ParentId_CodeRule");
            });

            modelBuilder.Entity<DrawingNumMatrix>(entity =>
            {
                entity.HasKey(e => e.DrawingId)
                    .HasName("pk_DrawingId");

                entity.ToTable("DrawingNumMatrix");

                entity.HasIndex(e => e.DrawingNum, "uq_DrawingNum")
                    .IsUnique();

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DrawingDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DrawingImage).HasColumnType("text");

                entity.Property(e => e.DrawingNum)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DrawingType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DrawingNumMatrices)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UserId_DrawingNumMatrix");
            });

            modelBuilder.Entity<DrawingPlan>(entity =>
            {
                entity.ToTable("DrawingPlan");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DrReleaseTarget).HasColumnType("date");

                entity.Property(e => e.Item)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LabelImage).HasColumnType("text");

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotalWorkload).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.DrawingPlans)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_DrawingPlan");
            });

            modelBuilder.Entity<DrawingPlanMarine>(entity =>
            {
                entity.HasKey(e => e.DrawingPlanId)
                    .HasName("pk_DrawingPlanIdMarine");

                entity.ToTable("DrawingPlanMarine");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DrReleaseTarget).HasColumnType("date");

                entity.Property(e => e.Item)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LabelImage).HasColumnType("text");

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotalWorkload).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.DrawingPlanMarines)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_DrawingPlanMarine");
            });

            modelBuilder.Entity<DxfcutList>(entity =>
            {
                entity.HasKey(e => e.CutListId)
                    .HasName("pk_CutListId_DXF");

                entity.ToTable("DXFCutList");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Materials)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PartDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Thickness).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DxfcutLists)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CategoryId_DXFCutList");
            });

            modelBuilder.Entity<FinancialDataMarine>(entity =>
            {
                entity.HasKey(e => e.FinancialDataId)
                    .HasName("pk_FinancialDataId_Marine");

                entity.ToTable("FinancialDataMarine");

                entity.HasIndex(e => e.ProjectId, "uq_ProjectId_FinancialDataMarine")
                    .IsUnique();

                entity.Property(e => e.SalesValue)
                    .HasColumnType("decimal(8, 0)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Project)
                    .WithOne(p => p.FinancialDataMarine)
                    .HasForeignKey<FinancialDataMarine>(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_FinancialData_Marine");
            });

            modelBuilder.Entity<FinancialDatum>(entity =>
            {
                entity.HasKey(e => e.FinancialDataId)
                    .HasName("pk_FinancialDataId");

                entity.HasIndex(e => e.ProjectId, "uq_ProjectId_FinancialData")
                    .IsUnique();

                entity.Property(e => e.SalesValue)
                    .HasColumnType("decimal(8, 0)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Project)
                    .WithOne(p => p.FinancialDatum)
                    .HasForeignKey<FinancialDatum>(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_FinancialData");
            });

            modelBuilder.Entity<Frkvf555>(entity =>
            {
                entity.ToTable("FRKVF555");

                entity.Property(e => e.Frkvf555id).HasColumnName("FRKVF555Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Frkvf555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_FRKVF555");
            });

            modelBuilder.Entity<Fruvf555>(entity =>
            {
                entity.ToTable("FRUVF555");

                entity.Property(e => e.Fruvf555id).HasColumnName("FRUVF555Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Fruvf555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_FRUVF555");
            });

            modelBuilder.Entity<GeneralRequirement>(entity =>
            {
                entity.HasIndex(e => e.ProjectId, "uq_ProjectId_GR")
                    .IsUnique();

                entity.Property(e => e.AnsulprePipe)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ANSULPrePipe")
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.Ansulsystem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ANSULSystem")
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.InputPower)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('220/50Hz')");

                entity.Property(e => e.MainAssyPath)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Marvel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL")
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.RiskLevel).HasDefaultValueSql("((3))");

                entity.Property(e => e.TypeId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Project)
                    .WithOne(p => p.GeneralRequirement)
                    .HasForeignKey<GeneralRequirement>(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_GR");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.GeneralRequirements)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TypeId");
            });

            modelBuilder.Entity<GeneralRequirementsMarine>(entity =>
            {
                entity.HasKey(e => e.GeneralRequirementId)
                    .HasName("pk_GeneralRequirementIdMarine");

                entity.ToTable("GeneralRequirementsMarine");

                entity.HasIndex(e => e.ProjectId, "uq_ProjectId_GRMarine")
                    .IsUnique();

                entity.Property(e => e.AnsulprePipe)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ANSULPrePipe")
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.Ansulsystem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ANSULSystem")
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.InputPower)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('220/50Hz')");

                entity.Property(e => e.MainAssyPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL")
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.RiskLevel).HasDefaultValueSql("((3))");

                entity.Property(e => e.TypeId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Project)
                    .WithOne(p => p.GeneralRequirementsMarine)
                    .HasForeignKey<GeneralRequirementsMarine>(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_GRMarine");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.GeneralRequirementsMarines)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TypeIdMarine");
            });

            modelBuilder.Entity<Hme>(entity =>
            {
                entity.ToTable("HME");

                entity.Property(e => e.Hmeid).HasColumnName("HMEId");

                entity.Property(e => e.HangPosition)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Heater)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Height).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.InletDia).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.NamePlate)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NetPlug)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OutletDia).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.OutletHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PlugPosition)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PowerPlug)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PowerPlugDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TemperatureSwitch)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.WindPressure)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Hmes)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_HME");
            });

            modelBuilder.Entity<Hmf>(entity =>
            {
                entity.ToTable("HMF");

                entity.Property(e => e.Hmfid).HasColumnName("HMFId");

                entity.Property(e => e.HangPosition)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Heater)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Height).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.InletDia).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.NamePlate)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NetPlug)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OutletDia).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.OutletHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PlugPosition)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PowerPlug)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PowerPlugDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TemperatureSwitch)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.WindPressure)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Hmfs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_HMF");
            });

            modelBuilder.Entity<Hmm>(entity =>
            {
                entity.ToTable("HMM");

                entity.Property(e => e.Hmmid).HasColumnName("HMMId");

                entity.Property(e => e.HangPosition)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Heater)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Height).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.InletDia).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.NamePlate)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NetPlug)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OutletDia).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.OutletHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PlugPosition)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PowerPlug)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PowerPlugDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TemperatureSwitch)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.WindPressure)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Hmms)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_HMM");
            });

            modelBuilder.Entity<HoodCutList>(entity =>
            {
                entity.HasKey(e => e.CutListId)
                    .HasName("pk_CutListId_Hood");

                entity.ToTable("HoodCutList");

                entity.HasIndex(e => new { e.ModuleTreeId, e.PartNo }, "uq_HoodCutList")
                    .IsUnique();

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Materials)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PartDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Thickness).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.HoodCutLists)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ModuleTreeId_HoodCutList");
            });

            modelBuilder.Entity<Hoodbcj>(entity =>
            {
                entity.ToTable("HOODBCJ");

                entity.Property(e => e.Hoodbcjid).HasColumnName("HOODBCJId");

                entity.Property(e => e.Height).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Hoodbcjs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_HOODBCJ");
            });

            modelBuilder.Entity<Hwuvf555400>(entity =>
            {
                entity.ToTable("HWUVF555400");

                entity.Property(e => e.Hwuvf555400id).HasColumnName("HWUVF555400Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LightYdis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LightYDis");

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Hwuvf555400s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_HWUVF555400");
            });

            modelBuilder.Entity<Hwuvf650>(entity =>
            {
                entity.ToTable("HWUVF650");

                entity.Property(e => e.Hwuvf650id).HasColumnName("HWUVF650Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('650')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LightYdis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LightYDis");

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Hwuvf650s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_HWUVF650");
            });

            modelBuilder.Entity<Hwuvi650>(entity =>
            {
                entity.ToTable("HWUVI650");

                entity.Property(e => e.Hwuvi650id).HasColumnName("HWUVI650Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('650')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LightYdis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LightYDis");

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Hwuvi650s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_HWUVI650");
            });

            modelBuilder.Entity<Hwuwf555>(entity =>
            {
                entity.ToTable("HWUWF555");

                entity.Property(e => e.Hwuwf555id).HasColumnName("HWUWF555Id");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Inlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LightYdis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LightYDis");

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Hwuwf555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_HWUWF555");
            });

            modelBuilder.Entity<Hwuwf555400>(entity =>
            {
                entity.ToTable("HWUWF555400");

                entity.Property(e => e.Hwuwf555400id).HasColumnName("HWUWF555400Id");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Inlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LightYdis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LightYDis");

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Hwuwf555400s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_HWUWF555400");
            });

            modelBuilder.Entity<Hwuwf650>(entity =>
            {
                entity.ToTable("HWUWF650");

                entity.Property(e => e.Hwuwf650id).HasColumnName("HWUWF650Id");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('650')");

                entity.Property(e => e.Inlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LightYdis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LightYDis");

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Hwuwf650s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_HWUWF650");
            });

            modelBuilder.Entity<Inf>(entity =>
            {
                entity.ToTable("INF");

                entity.Property(e => e.Infid).HasColumnName("INFId");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Infs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_INF");
            });

            modelBuilder.Entity<Kchf555>(entity =>
            {
                entity.ToTable("KCHF555");

                entity.Property(e => e.Kchf555id).HasColumnName("KCHF555Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kchf555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KCHF555");
            });

            modelBuilder.Entity<Kchi555>(entity =>
            {
                entity.ToTable("KCHI555");

                entity.Property(e => e.Kchi555id).HasColumnName("KCHI555Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kchi555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KCHI555");
            });

            modelBuilder.Entity<Kcjdb800>(entity =>
            {
                entity.ToTable("KCJDB800");

                entity.Property(e => e.Kcjdb800id).HasColumnName("KCJDB800Id");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FcblindNo).HasColumnName("FCBlindNo");

                entity.Property(e => e.Fcside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCSide");

                entity.Property(e => e.FcsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideLeft");

                entity.Property(e => e.FcsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideRight");

                entity.Property(e => e.Fctype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCType");

                entity.Property(e => e.Gutter)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightCable)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LightPanelLeft).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightPanelRight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightPanelSide)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Ssptype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSPType");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kcjdb800s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KCJDB800");
            });

            modelBuilder.Entity<Kcjsb265>(entity =>
            {
                entity.ToTable("KCJSB265");

                entity.Property(e => e.Kcjsb265id).HasColumnName("KCJSB265Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FcblindNo).HasColumnName("FCBlindNo");

                entity.Property(e => e.Fcside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCSide");

                entity.Property(e => e.FcsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideLeft");

                entity.Property(e => e.FcsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideRight");

                entity.Property(e => e.Fctype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCType");

                entity.Property(e => e.Gutter)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Ssptype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSPType");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kcjsb265s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KCJSB265");
            });

            modelBuilder.Entity<Kcjsb290>(entity =>
            {
                entity.ToTable("KCJSB290");

                entity.Property(e => e.Kcjsb290id).HasColumnName("KCJSB290Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FcblindNo).HasColumnName("FCBlindNo");

                entity.Property(e => e.Fcside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCSide");

                entity.Property(e => e.FcsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideLeft");

                entity.Property(e => e.FcsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideRight");

                entity.Property(e => e.Fctype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCType");

                entity.Property(e => e.Gutter)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Ssptype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSPType");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kcjsb290s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KCJSB290");
            });

            modelBuilder.Entity<Kcjsb535>(entity =>
            {
                entity.ToTable("KCJSB535");

                entity.Property(e => e.Kcjsb535id).HasColumnName("KCJSB535Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FcblindNo).HasColumnName("FCBlindNo");

                entity.Property(e => e.Fcside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCSide");

                entity.Property(e => e.FcsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideLeft");

                entity.Property(e => e.FcsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideRight");

                entity.Property(e => e.Fctype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCType");

                entity.Property(e => e.Gutter)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightCable)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LightPanelLeft).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightPanelRight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightPanelSide)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Ssptype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSPType");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kcjsb535s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KCJSB535");
            });

            modelBuilder.Entity<Kcwdb800>(entity =>
            {
                entity.ToTable("KCWDB800");

                entity.Property(e => e.Kcwdb800id).HasColumnName("KCWDB800Id");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Dpside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DPSide");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FcblindNo).HasColumnName("FCBlindNo");

                entity.Property(e => e.Fcside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCSide");

                entity.Property(e => e.FcsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideLeft");

                entity.Property(e => e.FcsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideRight");

                entity.Property(e => e.Gutter)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Ssptype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSPType");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kcwdb800s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KCWDB800");
            });

            modelBuilder.Entity<Kcwsb265>(entity =>
            {
                entity.ToTable("KCWSB265");

                entity.Property(e => e.Kcwsb265id).HasColumnName("KCWSB265Id");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Dpside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DPSide");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FcblindNo).HasColumnName("FCBlindNo");

                entity.Property(e => e.Fcside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCSide");

                entity.Property(e => e.FcsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideLeft");

                entity.Property(e => e.FcsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideRight");

                entity.Property(e => e.Gutter)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Inlet)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Ssptype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSPType");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kcwsb265s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KCWSB265");
            });

            modelBuilder.Entity<Kcwsb535>(entity =>
            {
                entity.ToTable("KCWSB535");

                entity.Property(e => e.Kcwsb535id).HasColumnName("KCWSB535Id");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Dpside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DPSide");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FcblindNo).HasColumnName("FCBlindNo");

                entity.Property(e => e.Fcside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCSide");

                entity.Property(e => e.FcsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideLeft");

                entity.Property(e => e.FcsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideRight");

                entity.Property(e => e.Gutter)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Hclside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("HCLSide");

                entity.Property(e => e.HclsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HCLSideLeft");

                entity.Property(e => e.HclsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HCLSideRight");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Ssptype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSPType");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kcwsb535s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KCWSB535");
            });

            modelBuilder.Entity<Kv>(entity =>
            {
                entity.HasKey(e => e.Kvsid)
                    .HasName("pk_KVSId");

                entity.ToTable("KVS");

                entity.Property(e => e.Kvsid).HasColumnName("KVSId");

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('BOTH')");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kvs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KVS");
            });

            modelBuilder.Entity<Kvf400>(entity =>
            {
                entity.ToTable("KVF400");

                entity.Property(e => e.Kvf400id).HasColumnName("KVF400Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('400')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kvf400s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KVF400");
            });

            modelBuilder.Entity<Kvf450400>(entity =>
            {
                entity.ToTable("KVF450400");

                entity.Property(e => e.Kvf450400id).HasColumnName("KVF450400Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('450')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kvf450400s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KVF450400");
            });

            modelBuilder.Entity<Kvf555>(entity =>
            {
                entity.ToTable("KVF555");

                entity.Property(e => e.Kvf555id).HasColumnName("KVF555Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kvf555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KVF555");
            });

            modelBuilder.Entity<Kvf555400>(entity =>
            {
                entity.ToTable("KVF555400");

                entity.Property(e => e.Kvf555400id).HasColumnName("KVF555400Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kvf555400s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KVF555400");
            });

            modelBuilder.Entity<Kvi400>(entity =>
            {
                entity.ToTable("KVI400");

                entity.Property(e => e.Kvi400id).HasColumnName("KVI400Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('400')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kvi400s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KVI400");
            });

            modelBuilder.Entity<Kvi450300>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KVI450300");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('450')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Kvi450300id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("KVI450300Id");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany()
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KVI450300");
            });

            modelBuilder.Entity<Kvi555>(entity =>
            {
                entity.ToTable("KVI555");

                entity.Property(e => e.Kvi555id).HasColumnName("KVI555Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kvi555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KVI555");
            });

            modelBuilder.Entity<Kvimr555>(entity =>
            {
                entity.ToTable("KVIMR555");

                entity.Property(e => e.Kvimr555id).HasColumnName("KVIMR555Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kvimr555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KVIMR555");
            });

            modelBuilder.Entity<Kvir555>(entity =>
            {
                entity.ToTable("KVIR555");

                entity.Property(e => e.Kvir555id).HasColumnName("KVIR555Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExBeamLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('BOTH')");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kvir555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KVIR555");
            });

            modelBuilder.Entity<Kvv555>(entity =>
            {
                entity.ToTable("KVV555");

                entity.Property(e => e.Kvv555id).HasColumnName("KVV555Id");

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('BOTH')");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kvv555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KVV555");
            });

            modelBuilder.Entity<Kwf555>(entity =>
            {
                entity.ToTable("KWF555");

                entity.Property(e => e.Kwf555id).HasColumnName("KWF555Id");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Inlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kwf555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KWF555");
            });

            modelBuilder.Entity<Kwi555>(entity =>
            {
                entity.ToTable("KWI555");

                entity.Property(e => e.Kwi555id).HasColumnName("KWI555Id");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Inlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Kwi555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_KWI555");
            });

            modelBuilder.Entity<Lfumc150dxf>(entity =>
            {
                entity.ToTable("LFUMC150DXF");

                entity.Property(e => e.Lfumc150dxfid).HasColumnName("LFUMC150DXFId");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lfumc150dxfs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LFUMC150DXF");
            });

            modelBuilder.Entity<Lfumc150susdxf>(entity =>
            {
                entity.ToTable("LFUMC150SUSDXF");

                entity.Property(e => e.Lfumc150susdxfid).HasColumnName("LFUMC150SUSDXFId");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lfumc150susdxfs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LFUMC150SUSDXF");
            });

            modelBuilder.Entity<Lfumc200dxf>(entity =>
            {
                entity.ToTable("LFUMC200DXF");

                entity.Property(e => e.Lfumc200dxfid).HasColumnName("LFUMC200DXFId");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lfumc200dxfs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LFUMC200DXF");
            });

            modelBuilder.Entity<Lfumc200susdxf>(entity =>
            {
                entity.ToTable("LFUMC200SUSDXF");

                entity.Property(e => e.Lfumc200susdxfid).HasColumnName("LFUMC200SUSDXFId");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lfumc200susdxfs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LFUMC200SUSDXF");
            });

            modelBuilder.Entity<Lfumc250dxf>(entity =>
            {
                entity.ToTable("LFUMC250DXF");

                entity.Property(e => e.Lfumc250dxfid).HasColumnName("LFUMC250DXFId");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lfumc250dxfs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LFUMC250DXF");
            });

            modelBuilder.Entity<Lfumc250susdxf>(entity =>
            {
                entity.ToTable("LFUMC250SUSDXF");

                entity.Property(e => e.Lfumc250susdxfid).HasColumnName("LFUMC250SUSDXFId");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lfumc250susdxfs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LFUMC250SUSDXF");
            });

            modelBuilder.Entity<Lfup>(entity =>
            {
                entity.ToTable("LFUP");

                entity.Property(e => e.Lfupid).HasColumnName("LFUPId");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lfups)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LFUP");
            });

            modelBuilder.Entity<Lfusa>(entity =>
            {
                entity.ToTable("LFUSA");

                entity.Property(e => e.Lfusaid).HasColumnName("LFUSAId");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDia).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lfusas)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LFUSA");
            });

            modelBuilder.Entity<Lfusc>(entity =>
            {
                entity.ToTable("LFUSC");

                entity.Property(e => e.Lfuscid).HasColumnName("LFUSCId");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SuDia).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lfuscs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LFUSC");
            });

            modelBuilder.Entity<Lfuss>(entity =>
            {
                entity.ToTable("LFUSS");

                entity.Property(e => e.Lfussid).HasColumnName("LFUSSId");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDia).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lfusses)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LFUSS");
            });

            modelBuilder.Entity<Lka258>(entity =>
            {
                entity.ToTable("LKA258");

                entity.Property(e => e.Lka258id).HasColumnName("LKA258Id");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lka258s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LKA258");
            });

            modelBuilder.Entity<Lkaspec>(entity =>
            {
                entity.ToTable("LKASPEC");

                entity.Property(e => e.Lkaspecid).HasColumnName("LKASPECId");

                entity.Property(e => e.Height).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lkaspecs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LKASPEC");
            });

            modelBuilder.Entity<Lks258hcl>(entity =>
            {
                entity.ToTable("LKS258HCL");

                entity.Property(e => e.Lks258hclid).HasColumnName("LKS258HCLId");

                entity.Property(e => e.Hclside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("HCLSide");

                entity.Property(e => e.HclsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HCLSideLeft");

                entity.Property(e => e.HclsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HCLSideRight");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lks258hcls)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LKS258HCL");
            });

            modelBuilder.Entity<Lks270>(entity =>
            {
                entity.ToTable("LKS270");

                entity.Property(e => e.Lks270id).HasColumnName("LKS270Id");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Wbeam)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WBeam");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lks270s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LKS270");
            });

            modelBuilder.Entity<Lks270hcl>(entity =>
            {
                entity.ToTable("LKS270HCL");

                entity.Property(e => e.Lks270hclid).HasColumnName("LKS270HCLId");

                entity.Property(e => e.Hclside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("HCLSide");

                entity.Property(e => e.HclsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HCLSideLeft");

                entity.Property(e => e.HclsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HCLSideRight");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lks270hcls)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LKS270HCL");
            });

            modelBuilder.Entity<Lksspec>(entity =>
            {
                entity.ToTable("LKSSPEC");

                entity.Property(e => e.Lksspecid).HasColumnName("LKSSPECId");

                entity.Property(e => e.Height).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Wbeam)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WBeam");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lksspecs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LKSSPEC");
            });

            modelBuilder.Entity<Lkst270>(entity =>
            {
                entity.ToTable("LKST270");

                entity.Property(e => e.Lkst270id).HasColumnName("LKST270Id");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Wbeam)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WBeam");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lkst270s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LKST270");
            });

            modelBuilder.Entity<Lled>(entity =>
            {
                entity.HasKey(e => e.Lledsid)
                    .HasName("pk_LLEDSId");

                entity.ToTable("LLEDS");

                entity.Property(e => e.Lledsid).HasColumnName("LLEDSId");

                entity.Property(e => e.Length).HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lleds)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LLEDS");
            });

            modelBuilder.Entity<Lledum>(entity =>
            {
                entity.HasKey(e => e.Lledaid)
                    .HasName("pk_LLEDAId");

                entity.ToTable("LLEDA");

                entity.Property(e => e.Lledaid).HasColumnName("LLEDAId");

                entity.Property(e => e.Length).HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lleda)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LLEDA");
            });

            modelBuilder.Entity<Llk>(entity =>
            {
                entity.HasKey(e => e.Llksid)
                    .HasName("pk_LLKSId");

                entity.ToTable("LLKS");

                entity.Property(e => e.Llksid).HasColumnName("LLKSId");

                entity.Property(e => e.Length).HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Llks)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LLKS");
            });

            modelBuilder.Entity<Llka>(entity =>
            {
                entity.ToTable("LLKA");

                entity.Property(e => e.Llkaid).HasColumnName("LLKAId");

                entity.Property(e => e.Length).HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Llkas)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LLKA");
            });

            modelBuilder.Entity<Llkaj>(entity =>
            {
                entity.ToTable("LLKAJ");

                entity.Property(e => e.Llkajid).HasColumnName("LLKAJId");

                entity.Property(e => e.LeftLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.MidLength)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((295))");

                entity.Property(e => e.RightLength).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Llkajs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LLKAJ");
            });

            modelBuilder.Entity<Llksj>(entity =>
            {
                entity.ToTable("LLKSJ");

                entity.Property(e => e.Llksjid).HasColumnName("LLKSJId");

                entity.Property(e => e.LeftLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.MidLength)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((295))");

                entity.Property(e => e.RightLength).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Llksjs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LLKSJ");
            });

            modelBuilder.Entity<Lpz>(entity =>
            {
                entity.ToTable("LPZ");

                entity.Property(e => e.Lpzid).HasColumnName("LPZId");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ZpanelNo).HasColumnName("ZPanelNo");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lpzs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LPZ");
            });

            modelBuilder.Entity<Lsdost>(entity =>
            {
                entity.ToTable("LSDOST");

                entity.Property(e => e.Lsdostid).HasColumnName("LSDOSTId");

                entity.Property(e => e.Deepth)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((350))");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('285')");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('BOTH')");

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Lsdosts)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_LSDOST");
            });

            modelBuilder.Entity<Mcpdxf>(entity =>
            {
                entity.ToTable("MCPDXF");

                entity.Property(e => e.Mcpdxfid).HasColumnName("MCPDXFId");

                entity.Property(e => e.Deepth)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((205))");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('610')");

                entity.Property(e => e.Length)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((380))");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('BOTH')");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Mcpdxfs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_MCPDXF");
            });

            modelBuilder.Entity<ModuleTree>(entity =>
            {
                entity.ToTable("ModuleTree");

                entity.HasIndex(e => new { e.DrawingPlanId, e.Module }, "uq_ModuleTree")
                    .IsUnique();

                entity.Property(e => e.Module)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ModuleTrees)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CategoryId_ModuleTree");

                entity.HasOne(d => d.DrawingPlan)
                    .WithMany(p => p.ModuleTrees)
                    .HasForeignKey(d => d.DrawingPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DrawingPlanId_ModuleTree");
            });

            modelBuilder.Entity<ModuleTreeMarine>(entity =>
            {
                entity.HasKey(e => e.ModuleTreeId)
                    .HasName("pk_ModuleTreeIdMarine");

                entity.ToTable("ModuleTreeMarine");

                entity.HasIndex(e => new { e.DrawingPlanId, e.Module }, "uq_ModuleTreeMarine")
                    .IsUnique();

                entity.Property(e => e.Module)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ModuleTreeMarines)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CategoryId_ModuleTreeMarine");

                entity.HasOne(d => d.DrawingPlan)
                    .WithMany(p => p.ModuleTreeMarines)
                    .HasForeignKey(d => d.DrawingPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DrawingPlanId_ModuleTreeMarine");
            });

            modelBuilder.Entity<Mu1boxdxf>(entity =>
            {
                entity.ToTable("MU1BOXDXF");

                entity.Property(e => e.Mu1boxdxfid).HasColumnName("MU1BOXDXFId");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Mu1boxdxfs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_MU1BOXDXF");
            });

            modelBuilder.Entity<Nocj300>(entity =>
            {
                entity.ToTable("NOCJ300");

                entity.Property(e => e.Nocj300id).HasColumnName("NOCJ300Id");

                entity.Property(e => e.BackCjside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BackCJSide");

                entity.Property(e => e.GutterSide)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LeftDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Lkside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LKSide");

                entity.Property(e => e.RightBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RightBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Nocj300s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_NOCJ300");
            });

            modelBuilder.Entity<Nocj330>(entity =>
            {
                entity.ToTable("NOCJ330");

                entity.Property(e => e.Nocj330id).HasColumnName("NOCJ330Id");

                entity.Property(e => e.BackCjside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BackCJSide");

                entity.Property(e => e.GutterSide)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LeftDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Lkside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LKSide");

                entity.Property(e => e.RightBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RightBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Nocj330s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_NOCJ330");
            });

            modelBuilder.Entity<Nocj340>(entity =>
            {
                entity.ToTable("NOCJ340");

                entity.Property(e => e.Nocj340id).HasColumnName("NOCJ340Id");

                entity.Property(e => e.BackCjside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BackCJSide");

                entity.Property(e => e.Dpside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DPSide");

                entity.Property(e => e.GutterSide)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LeftDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Lkside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LKSide");

                entity.Property(e => e.RightBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RightBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Nocj340s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_NOCJ340");
            });

            modelBuilder.Entity<Nocjspec>(entity =>
            {
                entity.ToTable("NOCJSPEC");

                entity.Property(e => e.Nocjspecid).HasColumnName("NOCJSPECId");

                entity.Property(e => e.BackBend).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.BackCjside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BackCJSide");

                entity.Property(e => e.GutterSide)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LeftDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Lkside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LKSide");

                entity.Property(e => e.RightBeamDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RightBeamType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TopBend).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Nocjspecs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_NOCJSPEC");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasIndex(e => e.Odpno, "uq_ODPNo")
                    .IsUnique();

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Bpono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BPONo");

                entity.Property(e => e.HoodType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Hood')");

                entity.Property(e => e.Odpno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ODPNo");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingTime).HasColumnType("date");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk_CustomerId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AddedBy_Projects");
            });

            modelBuilder.Entity<ProjectLearned>(entity =>
            {
                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Content)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Kmlink)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("KMLink");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectLearneds)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_PL");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProjectLearneds)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AddedBy_PL");
            });

            modelBuilder.Entity<ProjectStatus>(entity =>
            {
                entity.ToTable("ProjectStatus");

                entity.HasIndex(e => e.ProjectStatusName, "uq_ProjectStatus")
                    .IsUnique();

                entity.Property(e => e.ProjectStatusName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDesc)
                    .HasMaxLength(25)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProjectTracking>(entity =>
            {
                entity.ToTable("ProjectTracking");

                entity.HasIndex(e => e.ProjectId, "uq_ProjectId_ProjectTracking")
                    .IsUnique();

                entity.Property(e => e.AddedDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeliverActual).HasColumnType("date");

                entity.Property(e => e.DrReleaseActual).HasColumnType("date");

                entity.Property(e => e.KickOffDate).HasColumnType("date");

                entity.Property(e => e.OdpreceiveDate)
                    .HasColumnType("date")
                    .HasColumnName("ODPReceiveDate");

                entity.Property(e => e.ProdFinishActual).HasColumnType("date");

                entity.HasOne(d => d.Project)
                    .WithOne(p => p.ProjectTracking)
                    .HasForeignKey<ProjectTracking>(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_ProjectTracking");

                entity.HasOne(d => d.ProjectStatus)
                    .WithMany(p => p.ProjectTrackings)
                    .HasForeignKey(d => d.ProjectStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectStatusId");
            });

            modelBuilder.Entity<ProjectTrackingMarine>(entity =>
            {
                entity.HasKey(e => e.ProjectTrackingId)
                    .HasName("pk_ProjectTrackingIdMarine");

                entity.ToTable("ProjectTrackingMarine");

                entity.HasIndex(e => e.ProjectId, "uq_ProjectId_ProjectTrackingMarine")
                    .IsUnique();

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeliverActual).HasColumnType("date");

                entity.Property(e => e.DrReleaseActual).HasColumnType("date");

                entity.Property(e => e.KickOffDate).HasColumnType("date");

                entity.Property(e => e.OdpreceiveDate)
                    .HasColumnType("date")
                    .HasColumnName("ODPReceiveDate");

                entity.Property(e => e.ProdFinishActual).HasColumnType("date");

                entity.HasOne(d => d.Project)
                    .WithOne(p => p.ProjectTrackingMarine)
                    .HasForeignKey<ProjectTrackingMarine>(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_ProjectTrackingMarine");

                entity.HasOne(d => d.ProjectStatus)
                    .WithMany(p => p.ProjectTrackingMarines)
                    .HasForeignKey(d => d.ProjectStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectStatusIdMarine");
            });

            modelBuilder.Entity<ProjectType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("pk_TypeId");

                entity.HasIndex(e => e.TypeName, "uq_TypeName")
                    .IsUnique();

                entity.Property(e => e.Kmlink)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("KMLink");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProjectTypesMarine>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("pk_TypeIdMarine");

                entity.ToTable("ProjectTypesMarine");

                entity.HasIndex(e => e.TypeName, "uq_TypeNameMarine")
                    .IsUnique();

                entity.Property(e => e.Kmlink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("KMLink");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProjectsMarine>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("pk_ProjectIdMarine");

                entity.ToTable("ProjectsMarine");

                entity.HasIndex(e => e.Odpno, "uq_ODPNoMarine")
                    .IsUnique();

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Bpono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BPONo");

                entity.Property(e => e.HoodType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Odpno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ODPNo");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingTime).HasColumnType("date");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ProjectsMarines)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk_CustomerIdMarine");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProjectsMarines)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_AddedBy_ProjectsMarine");
            });

            modelBuilder.Entity<QualityFeedback>(entity =>
            {
                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Content)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.QualityFeedbacks)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_QF");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.QualityFeedbacks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AddedBy_QF");
            });

            modelBuilder.Entity<SemiBom>(entity =>
            {
                entity.ToTable("SemiBom");

                entity.Property(e => e.DrawingNum)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SemiBoms)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_SemiBom");
            });

            modelBuilder.Entity<SpecialRequirement>(entity =>
            {
                entity.Property(e => e.Content)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SpecialRequirements)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_SR");
            });

            modelBuilder.Entity<SpecialRequirementsMarine>(entity =>
            {
                entity.HasKey(e => e.SpecialRequirementId)
                    .HasName("pk_SpecialRequirementIdMarine");

                entity.ToTable("SpecialRequirementsMarine");

                entity.Property(e => e.Content)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SpecialRequirementsMarines)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_SRMarine");
            });

            modelBuilder.Entity<Sspdome>(entity =>
            {
                entity.ToTable("SSPDOME");

                entity.Property(e => e.Sspdomeid).HasColumnName("SSPDOMEId");

                entity.Property(e => e.LeftLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MpanelNo).HasColumnName("MPanelNo");

                entity.Property(e => e.RightLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RightType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Sspdomes)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_SSPDOME");
            });

            modelBuilder.Entity<Sspflat>(entity =>
            {
                entity.ToTable("SSPFLAT");

                entity.Property(e => e.Sspflatid).HasColumnName("SSPFLATId");

                entity.Property(e => e.LeftLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MpanelNo).HasColumnName("MPanelNo");

                entity.Property(e => e.RightLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RightType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Sspflats)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_SSPFLAT");
            });

            modelBuilder.Entity<Ssphfd>(entity =>
            {
                entity.ToTable("SSPHFD");

                entity.Property(e => e.Ssphfdid).HasColumnName("SSPHFDId");

                entity.Property(e => e.LeftLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MpanelNo).HasColumnName("MPanelNo");

                entity.Property(e => e.RightLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RightType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Ssphfds)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_SSPHFD");
            });

            modelBuilder.Entity<Ssptbd>(entity =>
            {
                entity.ToTable("SSPTBD");

                entity.Property(e => e.Ssptbdid).HasColumnName("SSPTBDId");

                entity.Property(e => e.LeftLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MpanelNo).HasColumnName("MPanelNo");

                entity.Property(e => e.RightLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RightType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Ssptbds)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_SSPTBD");
            });

            modelBuilder.Entity<Ssptsd>(entity =>
            {
                entity.ToTable("SSPTSD");

                entity.Property(e => e.Ssptsdid).HasColumnName("SSPTSDId");

                entity.Property(e => e.LeftLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LeftType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MpanelNo).HasColumnName("MPanelNo");

                entity.Property(e => e.RightLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RightType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Ssptsds)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_SSPTSD");
            });

            modelBuilder.Entity<SubAssy>(entity =>
            {
                entity.ToTable("SubAssy");

                entity.HasIndex(e => new { e.ProjectId, e.SubAssyName, e.SubAssyPath }, "uq_SubAssyPath")
                    .IsUnique();

                entity.Property(e => e.SubAssyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubAssyPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SubAssies)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProjectId_SubAssy");
            });

            modelBuilder.Entity<Tcsboxdxf>(entity =>
            {
                entity.ToTable("TCSBOXDXF");

                entity.Property(e => e.Tcsboxdxfid).HasColumnName("TCSBOXDXFId");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Tcsboxdxfs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_TCSBOXDXF");
            });

            modelBuilder.Entity<Ucjdb800>(entity =>
            {
                entity.ToTable("UCJDB800");

                entity.Property(e => e.Ucjdb800id).HasColumnName("UCJDB800Id");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FcblindNo).HasColumnName("FCBlindNo");

                entity.Property(e => e.Fcside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCSide");

                entity.Property(e => e.FcsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideLeft");

                entity.Property(e => e.FcsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideRight");

                entity.Property(e => e.Gutter)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightCable)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Ssptype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSPType");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Ucjdb800s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UCJDB800");
            });

            modelBuilder.Entity<Ucjfccombidxf>(entity =>
            {
                entity.ToTable("UCJFCCOMBIDXF");

                entity.Property(e => e.Ucjfccombidxfid).HasColumnName("UCJFCCOMBIDXFId");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Ucjfccombidxfs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UCJFCCOMBIDXF");
            });

            modelBuilder.Entity<Ucjsb385>(entity =>
            {
                entity.ToTable("UCJSB385");

                entity.Property(e => e.Ucjsb385id).HasColumnName("UCJSB385Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FcblindNo).HasColumnName("FCBlindNo");

                entity.Property(e => e.Fcside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCSide");

                entity.Property(e => e.FcsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideLeft");

                entity.Property(e => e.FcsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideRight");

                entity.Property(e => e.Gutter)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Ssptype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSPType");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Ucjsb385s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UCJSB385");
            });

            modelBuilder.Entity<Ucjsb535>(entity =>
            {
                entity.ToTable("UCJSB535");

                entity.Property(e => e.Ucjsb535id).HasColumnName("UCJSB535Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FcblindNo).HasColumnName("FCBlindNo");

                entity.Property(e => e.Fcside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCSide");

                entity.Property(e => e.FcsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideLeft");

                entity.Property(e => e.FcsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideRight");

                entity.Property(e => e.Gutter)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightCable)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Ssptype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSPType");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Ucjsb535s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UCJSB535");
            });

            modelBuilder.Entity<Ucpdxf>(entity =>
            {
                entity.ToTable("UCPDXF");

                entity.Property(e => e.Ucpdxfid).HasColumnName("UCPDXFId");

                entity.Property(e => e.Deepth)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((185))");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('350')");

                entity.Property(e => e.Length)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((400))");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('BOTH')");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Ucpdxfs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UCPDXF");
            });

            modelBuilder.Entity<Ucwdb800>(entity =>
            {
                entity.ToTable("UCWDB800");

                entity.Property(e => e.Ucwdb800id).HasColumnName("UCWDB800Id");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Dpside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DPSide");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FcblindNo).HasColumnName("FCBlindNo");

                entity.Property(e => e.Fcside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCSide");

                entity.Property(e => e.FcsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideLeft");

                entity.Property(e => e.FcsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideRight");

                entity.Property(e => e.Gutter)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.SensorDis1).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SensorDis2).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Ssptype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSPType");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Ucwdb800s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UCWDB800");
            });

            modelBuilder.Entity<Ucwsb535>(entity =>
            {
                entity.ToTable("UCWSB535");

                entity.Property(e => e.Ucwsb535id).HasColumnName("UCWSB535Id");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Dpside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DPSide");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FcblindNo).HasColumnName("FCBlindNo");

                entity.Property(e => e.Fcside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FCSide");

                entity.Property(e => e.FcsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideLeft");

                entity.Property(e => e.FcsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("FCSideRight");

                entity.Property(e => e.Gutter)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GutterWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Hclside)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("HCLSide");

                entity.Property(e => e.HclsideLeft)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HCLSideLeft");

                entity.Property(e => e.HclsideRight)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HCLSideRight");

                entity.Property(e => e.Japan)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.SensorDis1).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SensorDis2).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Ssptype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SSPType");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Ucwsb535s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UCWSB535");
            });

            modelBuilder.Entity<Ucwuvr4ldxf>(entity =>
            {
                entity.ToTable("UCWUVR4LDXF");

                entity.Property(e => e.Ucwuvr4ldxfid).HasColumnName("UCWUVR4LDXFId");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Ucwuvr4ldxfs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UCWUVR4LDXF");
            });

            modelBuilder.Entity<Ucwuvr4sdxf>(entity =>
            {
                entity.ToTable("UCWUVR4SDXF");

                entity.Property(e => e.Ucwuvr4sdxfid).HasColumnName("UCWUVR4SDXFId");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Ucwuvr4sdxfs)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UCWUVR4SDXF");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserAccount, "uq_UserAccount")
                    .IsUnique();

                entity.Property(e => e.Contact)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('10010001000')")
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('xxx@halton.com')");

                entity.Property(e => e.EmailPwd)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserAccount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UserGroupId");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.HasIndex(e => e.GroupName, "uq_GroupName")
                    .IsUnique();

                entity.Property(e => e.GroupName)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Uvf450>(entity =>
            {
                entity.ToTable("UVF450");

                entity.Property(e => e.Uvf450id).HasColumnName("UVF450Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('450')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Uvf450s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UVF450");
            });

            modelBuilder.Entity<Uvf450400>(entity =>
            {
                entity.ToTable("UVF450400");

                entity.Property(e => e.Uvf450400id).HasColumnName("UVF450400Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('450')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Uvf450400s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UVF450400");
            });

            modelBuilder.Entity<Uvf555>(entity =>
            {
                entity.ToTable("UVF555");

                entity.Property(e => e.Uvf555id).HasColumnName("UVF555Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Uvf555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UVF555");
            });

            modelBuilder.Entity<Uvf555400>(entity =>
            {
                entity.ToTable("UVF555400");

                entity.Property(e => e.Uvf555400id).HasColumnName("UVF555400Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Uvf555400s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UVF555400");
            });

            modelBuilder.Entity<Uvi450300>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UVI450300");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('450')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Uvi450300id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UVI450300Id");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany()
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UVI450300");
            });

            modelBuilder.Entity<Uvi555>(entity =>
            {
                entity.ToTable("UVI555");

                entity.Property(e => e.Uvi555id).HasColumnName("UVI555Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Uvi555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ModuleTreeId_UVI555");
            });

            modelBuilder.Entity<Uvi555400>(entity =>
            {
                entity.ToTable("UVI555400");

                entity.Property(e => e.Uvi555400id).HasColumnName("UVI555400Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Uvi555400s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UVI555400");
            });

            modelBuilder.Entity<Uvimr555>(entity =>
            {
                entity.ToTable("UVIMR555");

                entity.Property(e => e.Uvimr555id).HasColumnName("UVIMR555Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Uvimr555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UVIMR555");
            });

            modelBuilder.Entity<Uvimt555>(entity =>
            {
                entity.ToTable("UVIMT555");

                entity.Property(e => e.Uvimt555id).HasColumnName("UVIMT555Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Uvimt555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UVIMT555");
            });

            modelBuilder.Entity<Uvir555>(entity =>
            {
                entity.ToTable("UVIR555");

                entity.Property(e => e.Uvir555id).HasColumnName("UVIR555Id");

                entity.Property(e => e.Andetector)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetector");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExBeamLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('BOTH')");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Uvir555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UVIR555");
            });

            modelBuilder.Entity<Uwf555>(entity =>
            {
                entity.ToTable("UWF555");

                entity.Property(e => e.Uwf555id).HasColumnName("UWF555Id");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Inlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Uwf555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UWF555");
            });

            modelBuilder.Entity<Uwf555400>(entity =>
            {
                entity.ToTable("UWF555400");

                entity.Property(e => e.Uwf555400id).HasColumnName("UWF555400Id");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Inlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SuDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Uwf555400s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UWF555400");
            });

            modelBuilder.Entity<Uwi555>(entity =>
            {
                entity.ToTable("UWI555");

                entity.Property(e => e.Uwi555id).HasColumnName("UWI555Id");

                entity.Property(e => e.AndetectorDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis1");

                entity.Property(e => e.AndetectorDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis2");

                entity.Property(e => e.AndetectorDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis3");

                entity.Property(e => e.AndetectorDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis4");

                entity.Property(e => e.AndetectorDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDetectorDis5");

                entity.Property(e => e.AndetectorEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANDetectorEnd");

                entity.Property(e => e.AndetectorNo).HasColumnName("ANDetectorNo");

                entity.Property(e => e.AndropDis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis1");

                entity.Property(e => e.AndropDis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis2");

                entity.Property(e => e.AndropDis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis3");

                entity.Property(e => e.AndropDis4)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis4");

                entity.Property(e => e.AndropDis5)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANDropDis5");

                entity.Property(e => e.AndropNo).HasColumnName("ANDropNo");

                entity.Property(e => e.Anside)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ANSide");

                entity.Property(e => e.Ansul)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ANSUL");

                entity.Property(e => e.Anydis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("ANYDis");

                entity.Property(e => e.BackToBack)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Deepth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExHeight).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExLength).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExRightDis).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ExWidth).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('555')");

                entity.Property(e => e.Inlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Irdis1)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis1");

                entity.Property(e => e.Irdis2)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis2");

                entity.Property(e => e.Irdis3)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("IRDis3");

                entity.Property(e => e.Irno).HasColumnName("IRNo");

                entity.Property(e => e.Ledlogo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEDLogo");

                entity.Property(e => e.LedspotDis)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("LEDSpotDis");

                entity.Property(e => e.LedspotNo).HasColumnName("LEDSpotNo");

                entity.Property(e => e.Length).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LightType)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Marvel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MARVEL");

                entity.Property(e => e.Outlet)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SidePanel)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Uvtype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UVType");

                entity.Property(e => e.WaterCollection)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuleTree)
                    .WithMany(p => p.Uwi555s)
                    .HasForeignKey(d => d.ModuleTreeId)
                    .HasConstraintName("fk_ModuleTreeId_UWI555");
            });

            modelBuilder.Entity<ViewDelayQuery>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_DelayQuery");

                entity.Property(e => e.DrActual).HasColumnType("date");

                entity.Property(e => e.Drtarget).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
