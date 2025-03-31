using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data.Models;

public partial class DratnaContext : DbContext
{
    public DratnaContext()
    {
    }

    public DratnaContext(DbContextOptions<DratnaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AbillInH> AbillInHs { get; set; }

    public virtual DbSet<AbillInL> AbillInLs { get; set; }

    public virtual DbSet<AbillInRetH> AbillInRetHs { get; set; }

    public virtual DbSet<AbillInRetL> AbillInRetLs { get; set; }

    public virtual DbSet<AbillOutH> AbillOutHs { get; set; }

    public virtual DbSet<AbillOutL> AbillOutLs { get; set; }

    public virtual DbSet<AbillOutRetH> AbillOutRetHs { get; set; }

    public virtual DbSet<AbillOutRetL> AbillOutRetLs { get; set; }

    public virtual DbSet<AccYear> AccYears { get; set; }

    public virtual DbSet<AgrpMast> AgrpMasts { get; set; }

    public virtual DbSet<AgrpMastUnder> AgrpMastUnders { get; set; }

    public virtual DbSet<BalanceSheetTemp> BalanceSheetTemps { get; set; }

    public virtual DbSet<BrnMast> BrnMasts { get; set; }

    public virtual DbSet<BrokenMast> BrokenMasts { get; set; }

    public virtual DbSet<CertMast> CertMasts { get; set; }

    public virtual DbSet<ColMast> ColMasts { get; set; }

    public virtual DbSet<Combination> Combinations { get; set; }

    public virtual DbSet<CombinationNew> CombinationNews { get; set; }

    public virtual DbSet<CompMast> CompMasts { get; set; }

    public virtual DbSet<CostUpdatLat> CostUpdatLats { get; set; }

    public virtual DbSet<CostUpdate> CostUpdates { get; set; }

    public virtual DbSet<CulMast> CulMasts { get; set; }

    public virtual DbSet<CurrMast> CurrMasts { get; set; }

    public virtual DbSet<CutDisc> CutDiscs { get; set; }

    public virtual DbSet<CutMast> CutMasts { get; set; }

    public virtual DbSet<DeptMast> DeptMasts { get; set; }

    public virtual DbSet<DesgMast> DesgMasts { get; set; }

    public virtual DbSet<DeveloperMast> DeveloperMasts { get; set; }

    public virtual DbSet<EfacMast> EfacMasts { get; set; }

    public virtual DbSet<FinestMast> FinestMasts { get; set; }

    public virtual DbSet<FloMast> FloMasts { get; set; }

    public virtual DbSet<FluoDisc> FluoDiscs { get; set; }

    public virtual DbSet<FrmMast> FrmMasts { get; set; }

    public virtual DbSet<GirdMast> GirdMasts { get; set; }

    public virtual DbSet<GrpMast> GrpMasts { get; set; }

    public virtual DbSet<Grtype> Grtypes { get; set; }

    public virtual DbSet<Hamast> Hamasts { get; set; }

    public virtual DbSet<ItemMast> ItemMasts { get; set; }

    public virtual DbSet<JewCustPkt> JewCustPkts { get; set; }

    public virtual DbSet<JewFinishedStk> JewFinishedStks { get; set; }

    public virtual DbSet<JewSizeMast> JewSizeMasts { get; set; }

    public virtual DbSet<JewWsh> JewWshes { get; set; }

    public virtual DbSet<JewWsimg> JewWsimgs { get; set; }

    public virtual DbSet<JewWsl> JewWsls { get; set; }

    public virtual DbSet<JouRefNo> JouRefNos { get; set; }

    public virtual DbSet<KtMast> KtMasts { get; set; }

    public virtual DbSet<LexeTime> LexeTimes { get; set; }

    public virtual DbSet<LexeVersion> LexeVersions { get; set; }

    public virtual DbSet<LooseDiamReturn> LooseDiamReturns { get; set; }

    public virtual DbSet<LustMast> LustMasts { get; set; }

    public virtual DbSet<MailConfigMast> MailConfigMasts { get; set; }

    public virtual DbSet<MemoPkt> MemoPkts { get; set; }

    public virtual DbSet<MenuMast> MenuMasts { get; set; }

    public virtual DbSet<MonthMast> MonthMasts { get; set; }

    public virtual DbSet<OfferH> OfferHs { get; set; }

    public virtual DbSet<OfferL> OfferLs { get; set; }

    public virtual DbSet<OpPur> OpPurs { get; set; }

    public virtual DbSet<OrdH> OrdHs { get; set; }

    public virtual DbSet<OrdIss> OrdIsses { get; set; }

    public virtual DbSet<OrdIssStone> OrdIssStones { get; set; }

    public virtual DbSet<OrdL> OrdLs { get; set; }

    public virtual DbSet<OrdRec> OrdRecs { get; set; }

    public virtual DbSet<OrdRecStone> OrdRecStones { get; set; }

    public virtual DbSet<ParMast> ParMasts { get; set; }

    public virtual DbSet<ParMast100620152> ParMast100620152s { get; set; }

    public virtual DbSet<ParPerson> ParPeople { get; set; }

    public virtual DbSet<ParPktMast> ParPktMasts { get; set; }

    public virtual DbSet<Parmast10062015> Parmast10062015s { get; set; }

    public virtual DbSet<PassMast> PassMasts { get; set; }

    public virtual DbSet<PbillH> PbillHs { get; set; }

    public virtual DbSet<PbillL> PbillLs { get; set; }

    public virtual DbSet<PbillLhOsTemp> PbillLhOsTemps { get; set; }

    public virtual DbSet<PbillRetH> PbillRetHs { get; set; }

    public virtual DbSet<PbillRetL> PbillRetLs { get; set; }

    public virtual DbSet<PcompMast> PcompMasts { get; set; }

    public virtual DbSet<PerAccMast> PerAccMasts { get; set; }

    public virtual DbSet<PerAccUser> PerAccUsers { get; set; }

    public virtual DbSet<PerAprMast> PerAprMasts { get; set; }

    public virtual DbSet<PerAprUser> PerAprUsers { get; set; }

    public virtual DbSet<PerMast> PerMasts { get; set; }

    public virtual DbSet<PerPurMast> PerPurMasts { get; set; }

    public virtual DbSet<PerPurUser> PerPurUsers { get; set; }

    public virtual DbSet<PerSaleMast> PerSaleMasts { get; set; }

    public virtual DbSet<PerSaleUser> PerSaleUsers { get; set; }

    public virtual DbSet<PerTradMast> PerTradMasts { get; set; }

    public virtual DbSet<PerTradUser> PerTradUsers { get; set; }

    public virtual DbSet<PersonMast> PersonMasts { get; set; }

    public virtual DbSet<PersonalLedgerListing> PersonalLedgerListings { get; set; }

    public virtual DbSet<PktEntJewImg> PktEntJewImgs { get; set; }

    public virtual DbSet<PktGroup> PktGroups { get; set; }

    public virtual DbSet<PktGroupTest> PktGroupTests { get; set; }

    public virtual DbSet<PktIss> PktIsses { get; set; }

    public virtual DbSet<PktIssOld> PktIssOlds { get; set; }

    public virtual DbSet<PktMast> PktMasts { get; set; }

    public virtual DbSet<PktOpn> PktOpns { get; set; }

    public virtual DbSet<Pktmast23052015> Pktmast23052015s { get; set; }

    public virtual DbSet<PracMast> PracMasts { get; set; }

    public virtual DbSet<PropertyMast> PropertyMasts { get; set; }

    public virtual DbSet<ProughH> ProughHs { get; set; }

    public virtual DbSet<ProughIss> ProughIsses { get; set; }

    public virtual DbSet<ProughL> ProughLs { get; set; }

    public virtual DbSet<QuaMast> QuaMasts { get; set; }

    public virtual DbSet<RapDisc> RapDiscs { get; set; }

    public virtual DbSet<RapPass> RapPasses { get; set; }

    public virtual DbSet<RapPer> RapPers { get; set; }

    public virtual DbSet<Rapaport> Rapaports { get; set; }

    public virtual DbSet<Raporg> Raporgs { get; set; }

    public virtual DbSet<RcustlstRpt> RcustlstRpts { get; set; }

    public virtual DbSet<RemaindMast> RemaindMasts { get; set; }

    public virtual DbSet<RsincMast> RsincMasts { get; set; }

    public virtual DbSet<RsuplstRpt> RsuplstRpts { get; set; }

    public virtual DbSet<SalEncRate> SalEncRates { get; set; }

    public virtual DbSet<SbillH> SbillHs { get; set; }

    public virtual DbSet<SbillH226> SbillH226s { get; set; }

    public virtual DbSet<SbillL> SbillLs { get; set; }

    public virtual DbSet<SbillL226> SbillL226s { get; set; }

    public virtual DbSet<SbillLhOsTemp> SbillLhOsTemps { get; set; }

    public virtual DbSet<SbillRetH> SbillRetHs { get; set; }

    public virtual DbSet<SbillRetL> SbillRetLs { get; set; }

    public virtual DbSet<SbincMast> SbincMasts { get; set; }

    public virtual DbSet<ShpMast> ShpMasts { get; set; }

    public virtual DbSet<SincMast> SincMasts { get; set; }

    public virtual DbSet<SizeMast> SizeMasts { get; set; }

    public virtual DbSet<SoincMast> SoincMasts { get; set; }

    public virtual DbSet<SpersonMast> SpersonMasts { get; set; }

    public virtual DbSet<StkTrfIss> StkTrfIsses { get; set; }

    public virtual DbSet<StkTrfP> StkTrfPs { get; set; }

    public virtual DbSet<StkTrnfRec> StkTrnfRecs { get; set; }

    public virtual DbSet<Stock2015> Stock2015s { get; set; }

    public virtual DbSet<Stock2016> Stock2016s { get; set; }

    public virtual DbSet<StockAdj> StockAdjs { get; set; }

    public virtual DbSet<StonNat> StonNats { get; set; }

    public virtual DbSet<TabAss> TabAsses { get; set; }

    public virtual DbSet<TabLium> TabLia { get; set; }

    public virtual DbSet<TabTran> TabTrans { get; set; }

    public virtual DbSet<TaskMast> TaskMasts { get; set; }

    public virtual DbSet<TbincMast> TbincMasts { get; set; }

    public virtual DbSet<TblBinaryFile> TblBinaryFiles { get; set; }

    public virtual DbSet<TempAbillInL> TempAbillInLs { get; set; }

    public virtual DbSet<TempAbillOutL> TempAbillOutLs { get; set; }

    public virtual DbSet<TempBalTab> TempBalTabs { get; set; }

    public virtual DbSet<TempPlperiod> TempPlperiods { get; set; }

    public virtual DbSet<TempPltab> TempPltabs { get; set; }

    public virtual DbSet<TempPltradTab> TempPltradTabs { get; set; }

    public virtual DbSet<Test29012016> Test29012016s { get; set; }

    public virtual DbSet<TincMast> TincMasts { get; set; }

    public virtual DbSet<ToincMast> ToincMasts { get; set; }

    public virtual DbSet<TransferTableList> TransferTableLists { get; set; }

    public virtual DbSet<Trmmast> Trmmasts { get; set; }

    public virtual DbSet<TrnMast> TrnMasts { get; set; }

    public virtual DbSet<TrnMast226> TrnMast226s { get; set; }

    public virtual DbSet<TrnMastLocal> TrnMastLocals { get; set; }

    public virtual DbSet<TrnMastOsTemp> TrnMastOsTemps { get; set; }

    public virtual DbSet<TypeMast> TypeMasts { get; set; }

    public virtual DbSet<UserComp> UserComps { get; set; }

    public virtual DbSet<UserRep> UserReps { get; set; }

    public virtual DbSet<VuGoldView> VuGoldViews { get; set; }

    public virtual DbSet<VuJewStockIssView> VuJewStockIssViews { get; set; }

    public virtual DbSet<Zlog> Zlogs { get; set; }

    public virtual DbSet<ZlogAppIn> ZlogAppIns { get; set; }

    public virtual DbSet<ZlogAppInRet> ZlogAppInRets { get; set; }

    public virtual DbSet<ZlogAppOut> ZlogAppOuts { get; set; }

    public virtual DbSet<ZlogAppOutRet> ZlogAppOutRets { get; set; }

    public virtual DbSet<ZlogPbillL> ZlogPbillLs { get; set; }

    public virtual DbSet<ZlogPbillLret> ZlogPbillLrets { get; set; }

    public virtual DbSet<ZlogPktEnt> ZlogPktEnts { get; set; }

    public virtual DbSet<ZlogSbillL> ZlogSbillLs { get; set; }

    public virtual DbSet<ZlogSbillLret> ZlogSbillLrets { get; set; }

    public virtual DbSet<ZlogTrnMast> ZlogTrnMasts { get; set; }

    public virtual DbSet<ZsbillH> ZsbillHs { get; set; }

    public virtual DbSet<ZsbillL> ZsbillLs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-T5MN2V5;Database=DRatna;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AbillInH>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.CompCode, e.AcYear })
                .HasName("PK_ABillInH_1")
                .HasFillFactor(90);

            entity.ToTable("ABillInH");

            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.CanInv).HasDefaultValue(false);
            entity.Property(e => e.Carat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Conv)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.DueDay).HasDefaultValue(0);
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("LUser");
            entity.Property(e => e.Memo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.NetAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("P_Code");
            entity.Property(e => e.PrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PR_Code");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SType");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<AbillInL>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear })
                .HasName("PK_ABillInL_1")
                .HasFillFactor(90);

            entity.ToTable("ABillInL");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.CCode)
                .HasDefaultValue((short)0)
                .HasColumnName("C_Code");
            entity.Property(e => e.Carat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Conv)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("D_Code");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("I_Code");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Pcs).HasDefaultValue(0);
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PId");
            entity.Property(e => e.QCode)
                .HasDefaultValue((short)0)
                .HasColumnName("Q_Code");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SzCode)
                .HasDefaultValue((short)0)
                .HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<AbillInRetH>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.CompCode, e.AcYear })
                .HasName("PK_ABillInRetH_1")
                .HasFillFactor(90);

            entity.ToTable("ABillInRetH");

            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Conv)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.DueDay).HasDefaultValue(0);
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("LUser");
            entity.Property(e => e.Memo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.NetAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("P_Code");
            entity.Property(e => e.PrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PR_Code");
            entity.Property(e => e.RCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<AbillInRetL>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear })
                .HasName("PK_ABillInRetL_1")
                .HasFillFactor(90);

            entity.ToTable("ABillInRetL");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Comp_Code");
            entity.Property(e => e.AacYear)
                .HasDefaultValue(0)
                .HasColumnName("AAcYear");
            entity.Property(e => e.Amemo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AMemo");
            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.AsrNo)
                .HasDefaultValue(0)
                .HasColumnName("ASrNo");
            entity.Property(e => e.AtrnNo)
                .HasDefaultValue(0)
                .HasColumnName("ATrnNo");
            entity.Property(e => e.CCode)
                .HasDefaultValue((short)0)
                .HasColumnName("C_Code");
            entity.Property(e => e.Carat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Conv)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("D_Code");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("I_Code");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Pcs).HasDefaultValue(0);
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PId");
            entity.Property(e => e.QCode)
                .HasDefaultValue((short)0)
                .HasColumnName("Q_Code");
            entity.Property(e => e.RCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SzCode)
                .HasDefaultValue((short)0)
                .HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<AbillOutH>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.CompCode, e.AcYear })
                .HasName("PK_ABillOutH_1")
                .HasFillFactor(90);

            entity.ToTable("ABillOutH");

            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Memo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<AbillOutL>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear })
                .HasName("PK_ABillOutL_1")
                .HasFillFactor(90);

            entity.ToTable("ABillOutL");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<AbillOutRetH>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.CompCode, e.AcYear })
                .HasName("PK_ABillOutRetH_1")
                .HasFillFactor(90);

            entity.ToTable("ABillOutRetH");

            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Memo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<AbillOutRetL>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear })
                .HasName("PK_ABillOutRetL_1")
                .HasFillFactor(90);

            entity.ToTable("ABillOutRetL");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.AacYear).HasColumnName("AAcYear");
            entity.Property(e => e.Amemo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AMemo");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AsrNo).HasColumnName("ASrNo");
            entity.Property(e => e.AtrnNo).HasColumnName("ATrnNo");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<AccYear>(entity =>
        {
            entity.HasKey(e => new { e.CompCode, e.AcYear }).HasFillFactor(90);

            entity.ToTable("AccYear");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.FtrnDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("FTrnDate");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TtrnDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("TTrnDate");
        });

        modelBuilder.Entity<AgrpMast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AGrpMast");

            entity.Property(e => e.AgrCode).HasColumnName("AGR_Code");
            entity.Property(e => e.AgrName)
                .HasMaxLength(30)
                .HasColumnName("AGR_Name");
            entity.Property(e => e.AgrUnder).HasColumnName("AGR_Under");
            entity.Property(e => e.FacCode).HasColumnName("FAC_Code");
            entity.Property(e => e.GrAlias)
                .HasMaxLength(30)
                .HasColumnName("GR_Alias");
            entity.Property(e => e.GrBal)
                .HasMaxLength(1)
                .HasColumnName("GR_Bal");
            entity.Property(e => e.GrBspl)
                .HasMaxLength(1)
                .HasColumnName("GR_Bspl");
            entity.Property(e => e.GrFix).HasColumnName("GR_Fix");
            entity.Property(e => e.GrLevel).HasColumnName("GR_Level");
            entity.Property(e => e.GrOrder).HasColumnName("GR_Order");
            entity.Property(e => e.GrReal)
                .HasMaxLength(30)
                .HasColumnName("GR_Real");
            entity.Property(e => e.GrType).HasColumnName("GR_Type");
            entity.Property(e => e.SCode)
                .HasMaxLength(2)
                .HasColumnName("S_Code");
            entity.Property(e => e.TacCode).HasColumnName("TAC_Code");
        });

        modelBuilder.Entity<AgrpMastUnder>(entity =>
        {
            entity.HasKey(e => new { e.GrCode, e.SgrCode }).HasFillFactor(90);

            entity.ToTable("AGrpMastUnder");

            entity.Property(e => e.SgrCode).HasColumnName("SGrCode");
            entity.Property(e => e.GrLevel).HasColumnName("Gr_Level");
        });

        modelBuilder.Entity<BalanceSheetTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("balanceSheet_Temp");

            entity.Property(e => e.Aagrcode).HasColumnName("AAGRCode");
            entity.Property(e => e.Aagrname)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("AAGRName");
            entity.Property(e => e.Agrorder).HasColumnName("AGROrder");
            entity.Property(e => e.Aitotal)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("AITotal");
            entity.Property(e => e.Aototal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("AOTotal");
            entity.Property(e => e.Apcode)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("APCode");
            entity.Property(e => e.Apname)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("APName");
            entity.Property(e => e.Aprn)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("APRN");
            entity.Property(e => e.Arn)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("ARN");
            entity.Property(e => e.Assets).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Frn).HasColumnName("FRN");
            entity.Property(e => e.Frn1).HasColumnName("FRN1");
            entity.Property(e => e.Lagrcode).HasColumnName("LAGRCode");
            entity.Property(e => e.Lagrname)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("LAGRName");
            entity.Property(e => e.Lgrorder).HasColumnName("LGROrder");
            entity.Property(e => e.Liabilities).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Litotal)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("LITotal");
            entity.Property(e => e.Lototal)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("LOTotal");
            entity.Property(e => e.Lpcode)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("LPCode");
            entity.Property(e => e.Lpname)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("LPName");
            entity.Property(e => e.Lprn)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LPRN");
            entity.Property(e => e.Lrn)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LRN");
        });

        modelBuilder.Entity<BrnMast>(entity =>
        {
            entity.HasKey(e => e.BrnCode)
                .HasName("PK_BRNMAST")
                .HasFillFactor(90);

            entity.ToTable("BrnMast");

            entity.Property(e => e.BrnCode)
                .ValueGeneratedNever()
                .HasColumnName("BRN_Code");
            entity.Property(e => e.BrnName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BRN_Name");
            entity.Property(e => e.Per).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.SortName)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BrokenMast>(entity =>
        {
            entity.HasKey(e => e.BroCode).HasFillFactor(90);

            entity.ToTable("BrokenMast");

            entity.Property(e => e.BroCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BRO_Code");
            entity.Property(e => e.BroName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BRO_Name");
        });

        modelBuilder.Entity<CertMast>(entity =>
        {
            entity.HasKey(e => e.CrCode)
                .HasName("PK_CERTMAST")
                .HasFillFactor(90);

            entity.ToTable("CertMast");

            entity.Property(e => e.CrCode)
                .ValueGeneratedNever()
                .HasColumnName("CR_Code");
            entity.Property(e => e.CrName)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CR_Name");
            entity.Property(e => e.Per).HasColumnType("numeric(8, 2)");
        });

        modelBuilder.Entity<ColMast>(entity =>
        {
            entity.HasKey(e => e.CCode)
                .HasName("PK_COLMAST")
                .HasFillFactor(90);

            entity.ToTable("ColMast");

            entity.Property(e => e.CCode)
                .ValueGeneratedNever()
                .HasColumnName("C_Code");
            entity.Property(e => e.CName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("C_Name");
        });

        modelBuilder.Entity<Combination>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Combination");

            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.CName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("C_Name");
            entity.Property(e => e.Pgcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PGCode");
            entity.Property(e => e.Pgname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PGName");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.QName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Q_Name");
            entity.Property(e => e.SCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_Name");
            entity.Property(e => e.SortCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.SzName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SZ_Name");
        });

        modelBuilder.Entity<CombinationNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CombinationNew");

            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.CName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("C_Name");
            entity.Property(e => e.Pgcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PGCode");
            entity.Property(e => e.Pgname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PGName");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.QName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Q_Name");
            entity.Property(e => e.SCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_Name");
            entity.Property(e => e.SortCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.SzName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SZ_Name");
        });

        modelBuilder.Entity<CompMast>(entity =>
        {
            entity.HasKey(e => e.CompCode)
                .HasName("PK_MCompMast")
                .HasFillFactor(90);

            entity.ToTable("CompMast");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.CompName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Comp_Name");
            entity.Property(e => e.DecimalValue).HasDefaultValue((short)0);
            entity.Property(e => e.Type)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CostUpdatLat>(entity =>
        {
            entity.HasKey(e => e.AutoId)
                .HasName("PK_CostUpdatLat_1")
                .HasFillFactor(90);

            entity.ToTable("CostUpdatLat");

            entity.Property(e => e.AutoId).HasColumnName("AutoID");
            entity.Property(e => e.Cdate)
                .HasColumnType("smalldatetime")
                .HasColumnName("CDate");
            entity.Property(e => e.CnCy)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.CompName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.Ctime)
                .HasColumnType("datetime")
                .HasColumnName("CTime");
            entity.Property(e => e.CurAvg).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.Price).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.PurType)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CostUpdate>(entity =>
        {
            entity.HasKey(e => e.AutoId)
                .HasName("PK_CostUpdate_1")
                .HasFillFactor(90);

            entity.ToTable("CostUpdate");

            entity.HasIndex(e => new { e.AcYear, e.CompCode }, "InxCostUpdateAcyearCompCode").HasFillFactor(90);

            entity.Property(e => e.AutoId).HasColumnName("AutoID");
            entity.Property(e => e.Cdate)
                .HasColumnType("smalldatetime")
                .HasColumnName("CDate");
            entity.Property(e => e.CnCy)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.CompName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.Ctime)
                .HasColumnType("datetime")
                .HasColumnName("CTime");
            entity.Property(e => e.CurAvg)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DiffAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.OrgPrice).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.Price).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.PurType)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.StkCts).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<CulMast>(entity =>
        {
            entity.HasKey(e => e.CuCode)
                .HasName("PK_CULMAST")
                .HasFillFactor(90);

            entity.ToTable("CulMast");

            entity.Property(e => e.CuCode)
                .ValueGeneratedNever()
                .HasColumnName("CU_Code");
            entity.Property(e => e.CuName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CU_Name");
            entity.Property(e => e.Per).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.SortName)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CurrMast>(entity =>
        {
            entity.HasKey(e => e.CnCy)
                .HasName("PK_Currency")
                .HasFillFactor(90);

            entity.ToTable("CurrMast");

            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.PcnCy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PCnCy");
        });

        modelBuilder.Entity<CutDisc>(entity =>
        {
            entity.HasKey(e => new { e.SzCode, e.CCode, e.SCode, e.CtCode }).HasFillFactor(90);

            entity.ToTable("CutDisc");

            entity.Property(e => e.SzCode).HasColumnName("SZ_CODE");
            entity.Property(e => e.CCode).HasColumnName("C_CODE");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_CODE");
            entity.Property(e => e.CtCode).HasColumnName("CT_Code");
            entity.Property(e => e.Q1).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q10).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q11).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q2).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q3).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q4).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q5).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q6).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q7).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q8).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q9).HasColumnType("numeric(8, 2)");
        });

        modelBuilder.Entity<CutMast>(entity =>
        {
            entity.HasKey(e => e.CtCode)
                .HasName("PK_CUTMAST")
                .HasFillFactor(90);

            entity.ToTable("CutMast");

            entity.Property(e => e.CtCode)
                .ValueGeneratedNever()
                .HasColumnName("CT_Code");
            entity.Property(e => e.CtName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CT_Name");
            entity.Property(e => e.CtsName)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CTS_Name");
        });

        modelBuilder.Entity<DeptMast>(entity =>
        {
            entity.HasKey(e => e.DpCode)
                .HasName("PK_DepMast")
                .HasFillFactor(90);

            entity.ToTable("DeptMast");

            entity.Property(e => e.DpCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DP_Code");
            entity.Property(e => e.DpName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DP_Name");
            entity.Property(e => e.Prefix)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesgMast>(entity =>
        {
            entity.HasKey(e => e.DCode).HasFillFactor(90);

            entity.ToTable("DesgMast");

            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.DName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("D_Name");
        });

        modelBuilder.Entity<DeveloperMast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DeveloperMast");

            entity.Property(e => e.DelSpname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DelSPName");
            entity.Property(e => e.DetNoSpname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DetNoSPName");
            entity.Property(e => e.FormName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GetSpname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GetSPName");
            entity.Property(e => e.InsUpsSpname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InsUpsSPName");
            entity.Property(e => e.MenuName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EfacMast>(entity =>
        {
            entity.HasKey(e => e.EfCode)
                .HasName("PK_EFACMAST")
                .HasFillFactor(90);

            entity.ToTable("EFacMast");

            entity.Property(e => e.EfCode)
                .ValueGeneratedNever()
                .HasColumnName("EF_Code");
            entity.Property(e => e.EfName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EF_Name");
            entity.Property(e => e.Per).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.SortName)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FinestMast>(entity =>
        {
            entity.HasKey(e => e.FCode).HasFillFactor(90);

            entity.ToTable("FinestMast");

            entity.Property(e => e.FCode)
                .ValueGeneratedNever()
                .HasColumnName("F_Code");
            entity.Property(e => e.Desc1)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FloMast>(entity =>
        {
            entity.HasKey(e => e.FlCode)
                .HasName("PK_FLOMAST")
                .HasFillFactor(90);

            entity.ToTable("FLoMast");

            entity.Property(e => e.FlCode)
                .ValueGeneratedNever()
                .HasColumnName("FL_Code");
            entity.Property(e => e.FlName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FL_Name");
            entity.Property(e => e.FsName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FS_Name");
        });

        modelBuilder.Entity<FluoDisc>(entity =>
        {
            entity.HasKey(e => new { e.SzCode, e.CCode, e.SCode, e.FlCode }).HasFillFactor(90);

            entity.ToTable("FluoDisc");

            entity.Property(e => e.SzCode).HasColumnName("SZ_CODE");
            entity.Property(e => e.CCode).HasColumnName("C_CODE");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_CODE");
            entity.Property(e => e.FlCode).HasColumnName("FL_Code");
            entity.Property(e => e.Q1).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q10).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q11).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q2).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q3).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q4).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q5).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q6).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q7).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q8).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q9).HasColumnType("numeric(8, 2)");
        });

        modelBuilder.Entity<FrmMast>(entity =>
        {
            entity.HasKey(e => e.FormId)
                .HasName("PK_FRMMAST")
                .HasFillFactor(90);

            entity.ToTable("FrmMast");

            entity.Property(e => e.FormId)
                .ValueGeneratedNever()
                .HasColumnName("FORM_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCR");
            entity.Property(e => e.FormName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FORM_NAME");
        });

        modelBuilder.Entity<GirdMast>(entity =>
        {
            entity.HasKey(e => e.GrCode).HasFillFactor(90);

            entity.ToTable("GirdMast");

            entity.Property(e => e.GrCode)
                .ValueGeneratedNever()
                .HasColumnName("GR_Code");
            entity.Property(e => e.GrName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GR_Name");
            entity.Property(e => e.SortName)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GrpMast>(entity =>
        {
            entity.HasKey(e => e.GrCode)
                .HasName("PK_GRPMAST")
                .HasFillFactor(90);

            entity.ToTable("GrpMast");

            entity.Property(e => e.GrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GR_Code");
            entity.Property(e => e.GrName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GR_Name");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Grtype>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRType");

            entity.Property(e => e.GrName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GR_Name");
            entity.Property(e => e.GrType).HasColumnName("GR_Type");
        });

        modelBuilder.Entity<Hamast>(entity =>
        {
            entity.HasKey(e => e.HaCode)
                .HasName("PK_HAMAST")
                .HasFillFactor(90);

            entity.ToTable("HAMast");

            entity.Property(e => e.HaCode)
                .ValueGeneratedNever()
                .HasColumnName("HA_Code");
            entity.Property(e => e.HaName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HA_Name");
            entity.Property(e => e.Per).HasColumnType("numeric(10, 2)");
        });

        modelBuilder.Entity<ItemMast>(entity =>
        {
            entity.HasKey(e => e.ICode).HasFillFactor(90);

            entity.ToTable("ItemMast");

            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.IName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("I_Name");
        });

        modelBuilder.Entity<JewCustPkt>(entity =>
        {
            entity.HasKey(e => new { e.Pid, e.Oper }).HasFillFactor(90);

            entity.ToTable("JewCustPkt");

            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JewFinishedStk>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear, e.Type }).HasFillFactor(90);

            entity.ToTable("JewFinishedStk");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 3)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.LabRate)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("Lab_Rate");
            entity.Property(e => e.LabWeight)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("Lab_Weight");
            entity.Property(e => e.Labour).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<JewSizeMast>(entity =>
        {
            entity.HasKey(e => e.JCode).HasFillFactor(90);

            entity.ToTable("JewSizeMast");

            entity.Property(e => e.JCode)
                .ValueGeneratedNever()
                .HasColumnName("J_Code");
            entity.Property(e => e.Desc1)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JewWsh>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.CompCode })
                .HasName("PK_PktJewH")
                .HasFillFactor(90);

            entity.ToTable("JewWSH");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DelDate).HasColumnType("datetime");
            entity.Property(e => e.Fineness)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IssBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Quan).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Scarat)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SCarat");
            entity.Property(e => e.Stamp)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TrnDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.Wsno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WSNo");
        });

        modelBuilder.Entity<JewWsimg>(entity =>
        {
            entity.HasKey(e => new { e.Pid, e.CompCode })
                .HasName("PK_PktJewImg_1")
                .HasFillFactor(90);

            entity.ToTable("JewWSImg");

            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.JewImg).HasColumnType("image");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JewWsl>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode })
                .HasName("PK_PktJewDet")
                .HasFillFactor(90);

            entity.ToTable("JewWSL");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 3)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.Quan).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Rate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.Scarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("SCarat");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.TrnDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<JouRefNo>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.AcYear, e.CompCode, e.DetNo, e.Dtp, e.DacYear, e.SrNo }).HasFillFactor(90);

            entity.ToTable("JouRefNo");

            entity.Property(e => e.CompCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Dtp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DTP");
            entity.Property(e => e.DacYear).HasColumnName("DAcYear");
            entity.Property(e => e.SrNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KtMast>(entity =>
        {
            entity.HasKey(e => e.Kt)
                .HasName("PK_KtMast_1")
                .HasFillFactor(90);

            entity.ToTable("KtMast");

            entity.Property(e => e.Kt)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.GoldPrice).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Per).HasColumnType("numeric(10, 2)");
        });

        modelBuilder.Entity<LexeTime>(entity =>
        {
            entity.HasKey(e => e.Udate)
                .HasName("PK_LatestUpdate")
                .HasFillFactor(90);

            entity.ToTable("LExeTime");

            entity.Property(e => e.Udate)
                .HasColumnType("datetime")
                .HasColumnName("UDate");
        });

        modelBuilder.Entity<LexeVersion>(entity =>
        {
            entity.HasKey(e => e.Version).HasFillFactor(90);

            entity.ToTable("LExeVersion");

            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LooseDiamReturn>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear, e.Type })
                .HasName("PK_LosseDiamReturn")
                .HasFillFactor(90);

            entity.ToTable("LooseDiamReturn");

            entity.HasIndex(e => new { e.AcYear, e.CompCode }, "InxLooseDiamReturnAcyearCompCode").HasFillFactor(90);

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CCode)
                .HasDefaultValue((short)0)
                .HasColumnName("C_Code");
            entity.Property(e => e.CnCy)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PendCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode)
                .HasDefaultValue((short)0)
                .HasColumnName("Q_Code");
            entity.Property(e => e.Rate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RetCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.RetDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SzCode)
                .HasDefaultValue((short)0)
                .HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TrnTime).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<LustMast>(entity =>
        {
            entity.HasKey(e => e.LuCode)
                .HasName("PK_LUSTMAST")
                .HasFillFactor(90);

            entity.ToTable("LustMast");

            entity.Property(e => e.LuCode)
                .ValueGeneratedNever()
                .HasColumnName("LU_Code");
            entity.Property(e => e.LuName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LU_Name");
            entity.Property(e => e.Per).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.SortName)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MailConfigMast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MailConfigMast");

            entity.Property(e => e.CcemailId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CCEmailID");
            entity.Property(e => e.FromEmailId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FromEmailID");
            entity.Property(e => e.IsSsl).HasColumnName("IsSSL");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Smtp)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MemoPkt>(entity =>
        {
            entity.HasKey(e => new { e.Pid, e.Oper, e.CompCode }).HasFillFactor(90);

            entity.ToTable("MemoPkt");

            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
        });

        modelBuilder.Entity<MenuMast>(entity =>
        {
            entity.HasKey(e => e.MId).HasFillFactor(90);

            entity.ToTable("MenuMast");

            entity.Property(e => e.MId)
                .ValueGeneratedNever()
                .HasColumnName("M_ID");
            entity.Property(e => e.BName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("B_NAME");
            entity.Property(e => e.FormId).HasColumnName("FORM_ID");
            entity.Property(e => e.MName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("M_NAME");
        });

        modelBuilder.Entity<MonthMast>(entity =>
        {
            entity.HasKey(e => e.MonthNo).HasFillFactor(90);

            entity.ToTable("MonthMast");

            entity.Property(e => e.MonthNo).ValueGeneratedNever();
            entity.Property(e => e.MonthName)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MonthSortName)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OfferH>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.CompCode, e.AcYear })
                .HasName("PK_OfferH_1")
                .HasFillFactor(90);

            entity.ToTable("OfferH");

            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.AdvPay).HasColumnType("money");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AmtDiff).HasColumnType("money");
            entity.Property(e => e.BoutOk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BOutOk");
            entity.Property(e => e.BpayAmt)
                .HasColumnType("money")
                .HasColumnName("BPayAmt");
            entity.Property(e => e.BrCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CertAmt).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CommAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.CommPer)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 3)");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LabourRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.NcertAmt)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NCertAmt");
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.OutOk)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PayAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PrCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.Reference)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SracYear).HasColumnName("SRAcYear");
            entity.Property(e => e.Sramount)
                .HasColumnType("money")
                .HasColumnName("SRAmount");
            entity.Property(e => e.SrcompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SRComp_Code");
            entity.Property(e => e.SrinvNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SRInvNo");
            entity.Property(e => e.SrtrnNo).HasColumnName("SRTrnNo");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.TermAmt1).HasColumnType("money");
            entity.Property(e => e.TermAmt2).HasColumnType("money");
            entity.Property(e => e.TermAmt3).HasColumnType("money");
            entity.Property(e => e.TermAmt4).HasColumnType("money");
            entity.Property(e => e.TermAmt5).HasColumnType("money");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.VatAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.VatPer).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<OfferL>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.AcYear, e.CompCode })
                .HasName("PK_OfferL_1")
                .HasFillFactor(90);

            entity.ToTable("OfferL");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.BrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.CertAmt).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CommAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.CommPer)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.CurrCost)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gamount)
                .HasColumnType("money")
                .HasColumnName("GAmount");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.ImpFor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpInvNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpStkCts).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lp3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP3");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Lt3)
                .HasColumnType("money")
                .HasColumnName("LT3");
            entity.Property(e => e.MacYear).HasColumnName("MAcYear");
            entity.Property(e => e.MemoOut)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MsrNo).HasColumnName("MSrNo");
            entity.Property(e => e.MtrnNo).HasColumnName("MTrnNo");
            entity.Property(e => e.NcertAmt)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NCertAmt");
            entity.Property(e => e.OrgAvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PdisPer)
                .HasColumnType("money")
                .HasColumnName("PDisPer");
            entity.Property(e => e.PdisW)
                .HasColumnType("money")
                .HasColumnName("PDisW");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.RefType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.VatAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.VatPer).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<OpPur>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OpPur");

            entity.Property(e => e.Amount)
                .HasColumnType("money")
                .HasColumnName("amount");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
        });

        modelBuilder.Entity<OrdH>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.CompCode, e.AcYear })
                .HasName("PK_OrdH_1")
                .HasFillFactor(90);

            entity.ToTable("OrdH");

            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.JewSketch).HasColumnType("image");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OPer");
            entity.Property(e => e.OrdDate).HasColumnType("datetime");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Qty).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrdIss>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear, e.Type })
                .HasName("PK_OrdIss_1")
                .HasFillFactor(90);

            entity.ToTable("OrdIss");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.Carat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 3)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Idate)
                .HasColumnType("smalldatetime")
                .HasColumnName("IDate");
            entity.Property(e => e.InvNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Qty)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 0)");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Tpid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TPID");
            entity.Property(e => e.TrnTime).HasColumnType("smalldatetime");
            entity.Property(e => e.Weight)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<OrdIssStone>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear, e.Type })
                .HasName("PK_OrdIssStone_1")
                .HasFillFactor(90);

            entity.ToTable("OrdIssStone");

            entity.HasIndex(e => new { e.AcYear, e.CompCode }, "InxOrdIssStoneAcyearCompCode").HasFillFactor(90);

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.AvailableCarat).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Carat).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FinalAftConv)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Idate)
                .HasColumnType("smalldatetime")
                .HasColumnName("IDate");
            entity.Property(e => e.IssWeight)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.JewId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Kt)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.KtConvRate)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.OrgAvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Pcs).HasDefaultValue(0);
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.Rate)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.RetCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.RetDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.Tpid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TPId");
            entity.Property(e => e.TrnTime).HasColumnType("smalldatetime");
            entity.Property(e => e.UsedCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.UsedPcs).HasDefaultValue(0);
        });

        modelBuilder.Entity<OrdL>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear }).HasFillFactor(90);

            entity.ToTable("OrdL");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 3)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.FCode).HasColumnName("F_Code");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.JCode).HasColumnName("J_Code");
            entity.Property(e => e.MacYear)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MAcYear");
            entity.Property(e => e.MsrNo).HasColumnName("MSrNo");
            entity.Property(e => e.MtrnNo).HasColumnName("MTrnNo");
            entity.Property(e => e.Mtype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MType");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.OrdDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.ParPid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.Qty).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.Rate).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RecNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
        });

        modelBuilder.Entity<OrdRec>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear })
                .HasName("PK_OrdRec_1")
                .HasFillFactor(90);

            entity.ToTable("OrdRec");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.DCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FinalAftConv)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Idate)
                .HasColumnType("smalldatetime")
                .HasColumnName("IDate");
            entity.Property(e => e.IinvNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IInvNo");
            entity.Property(e => e.ItrnNo).HasColumnName("ITrnNo");
            entity.Property(e => e.JewId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Kt)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.KtConvRate)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.LabourAmount)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.LabourRate)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Qty)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 0)");
            entity.Property(e => e.Rdate)
                .HasColumnType("smalldatetime")
                .HasColumnName("RDate");
            entity.Property(e => e.RecWeight)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalUsedCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalUsedPcs).HasDefaultValue(0);
            entity.Property(e => e.TrnTime).HasColumnType("smalldatetime");
            entity.Property(e => e.Weight)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<OrdRecStone>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear, e.Type })
                .HasName("PK_OrdRecStone_1")
                .HasFillFactor(90);

            entity.ToTable("OrdRecStone");

            entity.HasIndex(e => new { e.AcYear, e.CompCode }, "InxOrdRecStoneAcyearCompCode").HasFillFactor(90);

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Carat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FinalAftConv)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.FinalPendCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.FinalUsedCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Idate)
                .HasColumnType("smalldatetime")
                .HasColumnName("IDate");
            entity.Property(e => e.ItrnNo).HasColumnName("ITrnNo");
            entity.Property(e => e.JewId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Kt)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.KtConvRate)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.LabourAmount)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.LabourRate)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.OrgAvgRate)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PendPcs).HasDefaultValue(0);
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.Rate)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Rdate)
                .HasColumnType("smalldatetime")
                .HasColumnName("RDate");
            entity.Property(e => e.RecWeight)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.RetCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RetCarat1)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RetCarat2)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RetCarat3)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RetCarat4)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RetCarat5)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RetDate1).HasColumnType("smalldatetime");
            entity.Property(e => e.RetDate2).HasColumnType("smalldatetime");
            entity.Property(e => e.RetDate3).HasColumnType("smalldatetime");
            entity.Property(e => e.RetDate4).HasColumnType("smalldatetime");
            entity.Property(e => e.RetDate5).HasColumnType("smalldatetime");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnTime).HasColumnType("smalldatetime");
            entity.Property(e => e.UsedPcs).HasDefaultValue(0);
        });

        modelBuilder.Entity<ParMast>(entity =>
        {
            entity.HasKey(e => new { e.PCode, e.CompCode, e.AcYear })
                .HasName("PK_OLD")
                .HasFillFactor(90);

            entity.ToTable("ParMast");

            entity.Property(e => e.PCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.AgrCode).HasColumnName("AGR_Code");
            entity.Property(e => e.Btconv)
                .HasColumnType("money")
                .HasColumnName("BTConv");
            entity.Property(e => e.BtsameCur).HasColumnName("BTSameCur");
            entity.Property(e => e.CnCy)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.GrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GR_Code");
            entity.Property(e => e.Grading)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.IpettyCash).HasColumnName("IPettyCash");
            entity.Property(e => e.LabourRate)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Limit).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Oamount)
                .HasColumnType("money")
                .HasColumnName("OAmount");
            entity.Property(e => e.OamountL)
                .HasColumnType("money")
                .HasColumnName("OAmountL");
            entity.Property(e => e.PName)
                .HasMaxLength(500)
                .HasColumnName("P_Name");
            entity.Property(e => e.PType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("P_Type");
            entity.Property(e => e.Pphoto)
                .HasColumnType("image")
                .HasColumnName("PPhoto");
            entity.Property(e => e.Ptag)
                .HasColumnType("image")
                .HasColumnName("PTag");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.SkipBillOs).HasColumnName("SkipBillOS");
            entity.Property(e => e.VatNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ParMast100620152>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParMast10062015_2");

            entity.Property(e => e.AgrCode).HasColumnName("AGR_Code");
            entity.Property(e => e.Btconv)
                .HasColumnType("money")
                .HasColumnName("BTConv");
            entity.Property(e => e.BtsameCur).HasColumnName("BTSameCur");
            entity.Property(e => e.CnCy)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.GrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GR_Code");
            entity.Property(e => e.Grading)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.IpettyCash).HasColumnName("IPettyCash");
            entity.Property(e => e.LabourRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Limit).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Oamount)
                .HasColumnType("money")
                .HasColumnName("OAmount");
            entity.Property(e => e.OamountL)
                .HasColumnType("money")
                .HasColumnName("OAmountL");
            entity.Property(e => e.PCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PName)
                .HasMaxLength(500)
                .HasColumnName("P_Name");
            entity.Property(e => e.PType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("P_Type");
            entity.Property(e => e.Pphoto)
                .HasColumnType("image")
                .HasColumnName("PPhoto");
            entity.Property(e => e.Ptag)
                .HasColumnType("image")
                .HasColumnName("PTag");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.VatNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ParPerson>(entity =>
        {
            entity.HasKey(e => new { e.PCode, e.PrCode, e.AcYear, e.CompCode }).HasFillFactor(90);

            entity.ToTable("ParPerson");

            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
        });

        modelBuilder.Entity<ParPktMast>(entity =>
        {
            entity.HasKey(e => new { e.ParPid, e.CompCode })
                .HasName("PK_ParPktMast_1")
                .HasFillFactor(90);

            entity.ToTable("ParPktMast");

            entity.Property(e => e.ParPid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ParPId");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Ord).HasDefaultValue(0);
            entity.Property(e => e.ParPidName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ParPIdName");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
        });

        modelBuilder.Entity<Parmast10062015>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Parmast10062015");

            entity.Property(e => e.AgrCode).HasColumnName("AGR_Code");
            entity.Property(e => e.Btconv)
                .HasColumnType("money")
                .HasColumnName("BTConv");
            entity.Property(e => e.BtsameCur).HasColumnName("BTSameCur");
            entity.Property(e => e.CnCy)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.GrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GR_Code");
            entity.Property(e => e.Grading)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.IpettyCash).HasColumnName("IPettyCash");
            entity.Property(e => e.LabourRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Limit).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Oamount)
                .HasColumnType("money")
                .HasColumnName("OAmount");
            entity.Property(e => e.OamountL)
                .HasColumnType("money")
                .HasColumnName("OAmountL");
            entity.Property(e => e.PCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PName)
                .HasMaxLength(500)
                .HasColumnName("P_Name");
            entity.Property(e => e.PType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("P_Type");
            entity.Property(e => e.Pphoto)
                .HasColumnType("image")
                .HasColumnName("PPhoto");
            entity.Property(e => e.Ptag)
                .HasColumnType("image")
                .HasColumnName("PTag");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.VatNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PassMast>(entity =>
        {
            entity.HasKey(e => e.UserId).HasFillFactor(90);

            entity.ToTable("PassMast");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cat)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PbillH>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.CompCode, e.AcYear })
                .HasName("PK_PBILLH_1")
                .HasFillFactor(90);

            entity.ToTable("PBillH");

            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.AdvReceived).HasColumnType("money");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AmtDiff).HasColumnType("money");
            entity.Property(e => e.BCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("B_Code");
            entity.Property(e => e.BoutOk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BOutOk");
            entity.Property(e => e.BpayAmt)
                .HasColumnType("money")
                .HasColumnName("BPayAmt");
            entity.Property(e => e.BrCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DocContentType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Doc_Content_Type");
            entity.Property(e => e.DocData).HasColumnName("Doc_Data");
            entity.Property(e => e.DocName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Doc_Name");
            entity.Property(e => e.DpCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DP_Code");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.OutOk)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PayAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.Pcom)
                .HasColumnType("money")
                .HasColumnName("PCom");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PracYear).HasColumnName("PRAcYear");
            entity.Property(e => e.Pramount)
                .HasColumnType("money")
                .HasColumnName("PRAmount");
            entity.Property(e => e.PrcompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRComp_Code");
            entity.Property(e => e.PrinvNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRInvNo");
            entity.Property(e => e.PrtrnNo).HasColumnName("PRTrnNo");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.TermAmt1).HasColumnType("money");
            entity.Property(e => e.TermAmt2).HasColumnType("money");
            entity.Property(e => e.TermAmt3).HasColumnType("money");
            entity.Property(e => e.TermAmt4).HasColumnType("money");
            entity.Property(e => e.TermAmt5).HasColumnType("money");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<PbillL>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear })
                .HasName("PK_PBILLL_1")
                .HasFillFactor(90);

            entity.ToTable("PBillL");

            entity.HasIndex(e => new { e.AcYear, e.CompCode }, "InxPbillLAcyearCompCode").HasFillFactor(90);

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.BrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ForDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gamount)
                .HasColumnType("money")
                .HasColumnName("GAmount");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lp3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP3");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Lt3)
                .HasColumnType("money")
                .HasColumnName("LT3");
            entity.Property(e => e.MacYear).HasColumnName("MAcYear");
            entity.Property(e => e.MemoIn)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MsrNo).HasColumnName("MSrNo");
            entity.Property(e => e.MtrnNo).HasColumnName("MTrnNo");
            entity.Property(e => e.OrgAvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.Pcom)
                .HasColumnType("money")
                .HasColumnName("PCom");
            entity.Property(e => e.PcomPer)
                .HasColumnType("money")
                .HasColumnName("PComPer");
            entity.Property(e => e.Pcs).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PdisPer)
                .HasColumnType("money")
                .HasColumnName("PDisPer");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Spkt).HasColumnName("SPkt");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.VatAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.VatPer).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<PbillLhOsTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PBillLH_OS_Temp");

            entity.Property(e => e.AdvReceived).HasColumnType("money");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AmtDiff).HasColumnType("money");
            entity.Property(e => e.BCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("B_Code");
            entity.Property(e => e.BoutOk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BOutOk");
            entity.Property(e => e.BpayAmt)
                .HasColumnType("money")
                .HasColumnName("BPayAmt");
            entity.Property(e => e.BrCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DocContentType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Doc_Content_Type");
            entity.Property(e => e.DocData).HasColumnName("Doc_Data");
            entity.Property(e => e.DocName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Doc_Name");
            entity.Property(e => e.DpCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DP_Code");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.OutOk)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PayAmt).HasColumnType("money");
            entity.Property(e => e.Pcom)
                .HasColumnType("money")
                .HasColumnName("PCom");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PracYear).HasColumnName("PRAcYear");
            entity.Property(e => e.Pramount)
                .HasColumnType("money")
                .HasColumnName("PRAmount");
            entity.Property(e => e.PrcompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRComp_Code");
            entity.Property(e => e.PrinvNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRInvNo");
            entity.Property(e => e.PrtrnNo).HasColumnName("PRTrnNo");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.TermAmt1).HasColumnType("money");
            entity.Property(e => e.TermAmt2).HasColumnType("money");
            entity.Property(e => e.TermAmt3).HasColumnType("money");
            entity.Property(e => e.TermAmt4).HasColumnType("money");
            entity.Property(e => e.TermAmt5).HasColumnType("money");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<PbillRetH>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.CompCode, e.AcYear })
                .HasName("PK_PBillRetH_1")
                .HasFillFactor(90);

            entity.ToTable("PBillRetH");

            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("B_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.OutOk)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PayAmt).HasColumnType("money");
            entity.Property(e => e.Pcom)
                .HasColumnType("money")
                .HasColumnName("PCom");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.TermAmt1).HasColumnType("money");
            entity.Property(e => e.TermAmt2).HasColumnType("money");
            entity.Property(e => e.TermAmt3).HasColumnType("money");
            entity.Property(e => e.TermAmt4).HasColumnType("money");
            entity.Property(e => e.TermAmt5).HasColumnType("money");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<PbillRetL>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear })
                .HasName("PK_PBillRetL_1")
                .HasFillFactor(90);

            entity.ToTable("PBillRetL");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gamount)
                .HasColumnType("money")
                .HasColumnName("GAmount");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lp3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP3");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Lt3)
                .HasColumnType("money")
                .HasColumnName("LT3");
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.PacYear).HasColumnName("PAcYear");
            entity.Property(e => e.Pcom)
                .HasColumnType("money")
                .HasColumnName("PCom");
            entity.Property(e => e.PcomPer)
                .HasColumnType("money")
                .HasColumnName("PComPer");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PdisPer)
                .HasColumnType("money")
                .HasColumnName("PDisPer");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.PinvNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PInvNo");
            entity.Property(e => e.PsrNo).HasColumnName("PSrNo");
            entity.Property(e => e.PtrnNo).HasColumnName("PTrnNo");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<PcompMast>(entity =>
        {
            entity.HasKey(e => new { e.PcompCode, e.CompCode, e.AcYear })
                .HasName("PK_COMPMAST")
                .HasFillFactor(90);

            entity.ToTable("PCompMast");

            entity.Property(e => e.PcompCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PComp_Code");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.AccName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AccNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Add1).HasMaxLength(500);
            entity.Property(e => e.Add2).HasMaxLength(500);
            entity.Property(e => e.Bank)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Bmobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BMobile");
            entity.Property(e => e.Bname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BName");
            entity.Property(e => e.Bphone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BPhone");
            entity.Property(e => e.Btype)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BType");
            entity.Property(e => e.ChinAdd).HasMaxLength(200);
            entity.Property(e => e.ChinBd)
                .HasColumnType("smalldatetime")
                .HasColumnName("ChinBD");
            entity.Property(e => e.ChinName).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Desg1).HasMaxLength(500);
            entity.Property(e => e.Desg2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Email1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Moa)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MOA");
            entity.Property(e => e.Mobile1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PName)
                .HasMaxLength(500)
                .HasColumnName("P_Name");
            entity.Property(e => e.PcompName)
                .HasMaxLength(500)
                .HasColumnName("PComp_Name");
            entity.Property(e => e.PerCode)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Per_Code");
            entity.Property(e => e.Person1).HasMaxLength(500);
            entity.Property(e => e.Person2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Phone1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SkypeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SkypePass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Swcode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SWCode");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PerAccMast>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasFillFactor(90);

            entity.ToTable("PerAccMast");

            entity.Property(e => e.SrNo).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PerAccUser>(entity =>
        {
            entity.HasKey(e => new { e.UserName, e.SrNo }).HasFillFactor(90);

            entity.ToTable("PerAccUser");

            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Pass)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Vw).HasColumnName("VW");
        });

        modelBuilder.Entity<PerAprMast>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasFillFactor(90);

            entity.ToTable("PerAprMast");

            entity.Property(e => e.SrNo).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PerAprUser>(entity =>
        {
            entity.HasKey(e => new { e.UserName, e.SrNo }).HasFillFactor(90);

            entity.ToTable("PerAprUser");

            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Pass)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Vw).HasColumnName("VW");
        });

        modelBuilder.Entity<PerMast>(entity =>
        {
            entity.HasKey(e => new { e.UserName, e.FormName })
                .HasName("PK_PERMAST")
                .HasFillFactor(90);

            entity.ToTable("PerMast");

            entity.Property(e => e.UserName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.FormName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FORM_NAME");
            entity.Property(e => e.Del).HasColumnName("DEL");
            entity.Property(e => e.Ins).HasColumnName("INS");
            entity.Property(e => e.Pass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PASS");
            entity.Property(e => e.Spass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPASS");
            entity.Property(e => e.Upd).HasColumnName("UPD");
            entity.Property(e => e.Viw).HasColumnName("VIW");
        });

        modelBuilder.Entity<PerPurMast>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasFillFactor(90);

            entity.ToTable("PerPurMast");

            entity.Property(e => e.SrNo).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PerPurUser>(entity =>
        {
            entity.HasKey(e => new { e.UserName, e.SrNo }).HasFillFactor(90);

            entity.ToTable("PerPurUser");

            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Pass)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Vw).HasColumnName("VW");
        });

        modelBuilder.Entity<PerSaleMast>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasFillFactor(90);

            entity.ToTable("PerSaleMast");

            entity.Property(e => e.SrNo).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PerSaleUser>(entity =>
        {
            entity.HasKey(e => new { e.UserName, e.SrNo }).HasFillFactor(90);

            entity.ToTable("PerSaleUser");

            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Pass)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Vw).HasColumnName("VW");
        });

        modelBuilder.Entity<PerTradMast>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasFillFactor(90);

            entity.ToTable("PerTradMast");

            entity.Property(e => e.SrNo).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PerTradUser>(entity =>
        {
            entity.HasKey(e => new { e.UserName, e.SrNo }).HasFillFactor(90);

            entity.ToTable("PerTradUser");

            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Pass)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Vw).HasColumnName("VW");
        });

        modelBuilder.Entity<PersonMast>(entity =>
        {
            entity.HasKey(e => new { e.PrCode, e.AcYear, e.CompCode })
                .HasName("PK_PersonMast_1")
                .HasFillFactor(90);

            entity.ToTable("PersonMast");

            entity.Property(e => e.PrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.CertPer).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.NcertPer)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NCertPer");
            entity.Property(e => e.PrName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_Name");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PersonalLedgerListing>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'Personal Ledger Listing$'");

            entity.Property(e => e.AgrCode).HasColumnName("AGR_Code");
            entity.Property(e => e.CnCy).HasMaxLength(255);
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("CODE");
            entity.Property(e => e.CompCode).HasColumnName("Comp_Code");
            entity.Property(e => e.GrCode)
                .HasMaxLength(255)
                .HasColumnName("GR_Code");
            entity.Property(e => e.PType)
                .HasMaxLength(255)
                .HasColumnName("P_Type");
            entity.Property(e => e.Party).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<PktEntJewImg>(entity =>
        {
            entity.HasKey(e => new { e.Pid, e.CompCode })
                .HasName("PK_PktEntJewImg_1")
                .HasFillFactor(90);

            entity.ToTable("PktEntJewImg");

            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.JewImg).HasColumnType("image");
            entity.Property(e => e.JewThumbnailImg).HasColumnType("image");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PktGroup>(entity =>
        {
            entity.HasKey(e => e.PgCode).HasFillFactor(90);

            entity.ToTable("PktGroup");

            entity.Property(e => e.PgCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PG_Code");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.PgName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PG_Name");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
        });

        modelBuilder.Entity<PktGroupTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PktGroup_Test");

            entity.Property(e => e.CCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("C_CODE");
            entity.Property(e => e.CName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("C_NAME");
            entity.Property(e => e.PgCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PG_CODE");
            entity.Property(e => e.PgName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PG_NAME");
            entity.Property(e => e.QCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Q_CODE");
            entity.Property(e => e.QName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Q_NAME");
            entity.Property(e => e.SCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_CODE");
            entity.Property(e => e.SName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_NAME");
            entity.Property(e => e.SzCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SZ_CODE");
            entity.Property(e => e.SzName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SZ_NAME");
        });

        modelBuilder.Entity<PktIss>(entity =>
        {
            entity.HasKey(e => new { e.DetNo, e.CompCode, e.Pid })
                .HasName("PK_PktIss_1")
                .HasFillFactor(90);

            entity.ToTable("PktIss");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Descr)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Idate)
                .HasColumnType("smalldatetime")
                .HasColumnName("IDate");
            entity.Property(e => e.Itime)
                .HasColumnType("datetime")
                .HasColumnName("ITime");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PrCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PktIssOld>(entity =>
        {
            entity.HasKey(e => new { e.DetNo, e.CompCode, e.Pid }).HasFillFactor(90);

            entity.ToTable("PktIss_OLD");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Descr)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Idate)
                .HasColumnType("smalldatetime")
                .HasColumnName("IDate");
            entity.Property(e => e.Itime)
                .HasColumnType("datetime")
                .HasColumnName("ITime");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PrCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PktMast>(entity =>
        {
            entity.HasKey(e => new { e.Pid, e.CompCode })
                .HasName("PK_PktEnt")
                .HasFillFactor(90);

            entity.ToTable("PktMast");

            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.AvgCost).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AvgRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.BinCode).HasColumnName("BIN_Code");
            entity.Property(e => e.BrnCode).HasColumnName("BRN_Code");
            entity.Property(e => e.BroCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BRO_Code");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Cangle)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CAngle");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CertNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Cheight)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CHeight");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.CrCode).HasColumnName("CR_Code");
            entity.Property(e => e.CrtMax).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CrtMin).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CtCode).HasColumnName("CT_Code");
            entity.Property(e => e.CuCode).HasColumnName("CU_Code");
            entity.Property(e => e.CurCost).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Descr)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Diameter).HasColumnType("numeric(8, 3)");
            entity.Property(e => e.EfCode).HasColumnName("EF_Code");
            entity.Property(e => e.FlCode).HasColumnName("FL_Code");
            entity.Property(e => e.ForDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Girdle).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.GrCodeK).HasColumnName("GR_CodeK");
            entity.Property(e => e.GrCodeN).HasColumnName("GR_CodeN");
            entity.Property(e => e.Gweight)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("GWeight");
            entity.Property(e => e.HaCode).HasColumnName("HA_Code");
            entity.Property(e => e.Height).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Length).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.LuCode).HasColumnName("LU_Code");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Margin).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.OinCode).HasColumnName("OIN_Code");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Pangle)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("PAngle");
            entity.Property(e => e.ParPid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ParPId");
            entity.Property(e => e.Pass).HasColumnName("PAss");
            entity.Property(e => e.Per).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.PgCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PG_Code");
            entity.Property(e => e.Pheight)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("PHeight");
            entity.Property(e => e.PoCode).HasColumnName("PO_Code");
            entity.Property(e => e.PurQuan).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.Quan).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Rap).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Rate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Ratio).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Reference)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Rfidtag)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("RFIDTag");
            entity.Property(e => e.RinCode).HasColumnName("RIN_Code");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SalCurSym)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SalQuan).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Sass).HasColumnName("SAss");
            entity.Property(e => e.SbinCode).HasColumnName("SBIN_Code");
            entity.Property(e => e.SinCode).HasColumnName("SIN_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.SoinCode).HasColumnName("SOIN_Code");
            entity.Property(e => e.Spkt).HasColumnName("SPkt");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SrateMin)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SRateMin");
            entity.Property(e => e.SyCode).HasColumnName("SY_Code");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.Table1).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.TinCode).HasColumnName("TIN_Code");
            entity.Property(e => e.TotDepth).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Width).HasColumnType("numeric(8, 2)");
        });

        modelBuilder.Entity<PktOpn>(entity =>
        {
            entity.HasKey(e => new { e.AcYear, e.Pid, e.CompCode })
                .HasName("PK_PKTOPN")
                .HasFillFactor(90);

            entity.ToTable("PktOpn");

            entity.HasIndex(e => new { e.AcYear, e.CompCode }, "InxPktOpnAcyearCompCode").HasFillFactor(90);

            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Carat).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Rate).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TrnDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<Pktmast23052015>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pktmast23052015");

            entity.Property(e => e.AvgCost).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.BinCode).HasColumnName("BIN_Code");
            entity.Property(e => e.BrnCode).HasColumnName("BRN_Code");
            entity.Property(e => e.BroCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BRO_Code");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Cangle)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CAngle");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CertNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Cheight)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CHeight");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.CrCode).HasColumnName("CR_Code");
            entity.Property(e => e.CrtMax).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CrtMin).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CtCode).HasColumnName("CT_Code");
            entity.Property(e => e.CuCode).HasColumnName("CU_Code");
            entity.Property(e => e.CurCost).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Descr)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Diameter).HasColumnType("numeric(8, 3)");
            entity.Property(e => e.EfCode).HasColumnName("EF_Code");
            entity.Property(e => e.FlCode).HasColumnName("FL_Code");
            entity.Property(e => e.Girdle).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.GrCodeK).HasColumnName("GR_CodeK");
            entity.Property(e => e.GrCodeN).HasColumnName("GR_CodeN");
            entity.Property(e => e.Gweight)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("GWeight");
            entity.Property(e => e.HaCode).HasColumnName("HA_Code");
            entity.Property(e => e.Height).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Length).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.LuCode).HasColumnName("LU_Code");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Margin).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.OinCode).HasColumnName("OIN_Code");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Pangle)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("PAngle");
            entity.Property(e => e.ParPid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ParPId");
            entity.Property(e => e.Pass).HasColumnName("PAss");
            entity.Property(e => e.Per).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Pheight)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("PHeight");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.PoCode).HasColumnName("PO_Code");
            entity.Property(e => e.PurQuan).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.Quan).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Rap).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Rate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Ratio).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Rfidtag)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("RFIDTag");
            entity.Property(e => e.RinCode).HasColumnName("RIN_Code");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SalCurSym)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SalQuan).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Sass).HasColumnName("SAss");
            entity.Property(e => e.SbinCode).HasColumnName("SBIN_Code");
            entity.Property(e => e.SinCode).HasColumnName("SIN_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.SoinCode).HasColumnName("SOIN_Code");
            entity.Property(e => e.Spkt).HasColumnName("SPkt");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SrateMin)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SRateMin");
            entity.Property(e => e.SyCode).HasColumnName("SY_Code");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.Table1).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.TinCode).HasColumnName("TIN_Code");
            entity.Property(e => e.TotDepth).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Width).HasColumnType("numeric(8, 2)");
        });

        modelBuilder.Entity<PracMast>(entity =>
        {
            entity.HasKey(e => e.QCode)
                .HasName("PK_dbo.PracMast")
                .HasFillFactor(90);

            entity.ToTable("PracMast");

            entity.Property(e => e.QCode)
                .ValueGeneratedNever()
                .HasColumnName("Q_Code");
            entity.Property(e => e.QName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Q_Name");
        });

        modelBuilder.Entity<PropertyMast>(entity =>
        {
            entity.HasKey(e => e.PropId)
                .HasName("PK_Property")
                .HasFillFactor(90);

            entity.ToTable("PropertyMast");

            entity.Property(e => e.PropId).HasMaxLength(50);
            entity.Property(e => e.PropText)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.PropValue)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 0)");
        });

        modelBuilder.Entity<ProughH>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.AcYear, e.CompCode, e.Type }).HasFillFactor(90);

            entity.ToTable("PRoughH");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("LUser");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TotMkamt)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("TotMKAmt");
            entity.Property(e => e.TotPcarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("TotPCarat");
            entity.Property(e => e.TotRcarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("TotRCarat");
            entity.Property(e => e.TotTrCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 3)");
            entity.Property(e => e.TrnDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProughIss>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear, e.Type }).HasFillFactor(90);

            entity.ToTable("PRoughIss");

            entity.HasIndex(e => new { e.AcYear, e.CompCode }, "InxPRoughIssAcyearCompCode").HasFillFactor(90);

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.AvailableCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 4)");
            entity.Property(e => e.InvNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IssCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.Rate)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TrnTime).HasColumnType("smalldatetime");
            entity.Property(e => e.UsedCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
        });

        modelBuilder.Entity<ProughL>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.AcYear, e.CompCode, e.Type }).HasFillFactor(90);

            entity.ToTable("PRoughL");

            entity.HasIndex(e => new { e.AcYear, e.CompCode }, "InxPRoughLAcyearCompCode").HasFillFactor(90);

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Carat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 3)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("LUser");
            entity.Property(e => e.MacYear).HasColumnName("MAcYear");
            entity.Property(e => e.Mcamt)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("MCAmt");
            entity.Property(e => e.Mcrate)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("MCRate");
            entity.Property(e => e.MemoOut)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MsrNo)
                .HasDefaultValue(0)
                .HasColumnName("MSrNo");
            entity.Property(e => e.MtrnNo)
                .HasDefaultValue(0)
                .HasColumnName("MTrnNo");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Pcarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("PCarat");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.Rcarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("RCarat");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.Tpid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TPId");
            entity.Property(e => e.TranAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.TranCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 3)");
            entity.Property(e => e.TranRate)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.TrnDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.UsedCarat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 3)");
        });

        modelBuilder.Entity<QuaMast>(entity =>
        {
            entity.HasKey(e => e.QCode)
                .HasName("PK_QUAMAST")
                .HasFillFactor(90);

            entity.ToTable("QuaMast");

            entity.Property(e => e.QCode)
                .ValueGeneratedNever()
                .HasColumnName("Q_Code");
            entity.Property(e => e.QName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Q_Name");
        });

        modelBuilder.Entity<RapDisc>(entity =>
        {
            entity.HasKey(e => new { e.SzCode, e.CCode, e.SCode }).HasFillFactor(90);

            entity.ToTable("RapDisc");

            entity.Property(e => e.SzCode).HasColumnName("SZ_CODE");
            entity.Property(e => e.CCode).HasColumnName("C_CODE");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_CODE");
            entity.Property(e => e.Q1).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q10).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q11).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q2).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q3).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q4).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q5).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q6).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q7).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q8).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Q9).HasColumnType("numeric(8, 2)");
        });

        modelBuilder.Entity<RapPass>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("RapPass");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RapPer>(entity =>
        {
            entity.HasKey(e => e.Uid).HasFillFactor(90);

            entity.ToTable("RapPer");

            entity.Property(e => e.Uid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UId");
        });

        modelBuilder.Entity<Rapaport>(entity =>
        {
            entity.HasKey(e => new { e.SzCode, e.CCode, e.SCode }).HasFillFactor(90);

            entity.ToTable("RAPAPORT");

            entity.Property(e => e.SzCode)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("SZ_CODE");
            entity.Property(e => e.CCode)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("C_CODE");
            entity.Property(e => e.SCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_CODE");
            entity.Property(e => e.D1).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.D10).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.D11).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.D2).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.D3).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.D4).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.D5).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.D6).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.D7).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.D8).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.D9).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q1).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q10).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q11).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q2).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q3).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q4).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q5).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q6).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q7).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q8).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q9).HasColumnType("numeric(10, 2)");
        });

        modelBuilder.Entity<Raporg>(entity =>
        {
            entity.HasKey(e => new { e.SzCode, e.CCode, e.SCode }).HasFillFactor(90);

            entity.ToTable("RAPORG");

            entity.Property(e => e.SzCode)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("SZ_CODE");
            entity.Property(e => e.CCode)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("C_CODE");
            entity.Property(e => e.SCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_CODE");
            entity.Property(e => e.FCarat)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("F_Carat");
            entity.Property(e => e.Oq1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("OQ1");
            entity.Property(e => e.Oq10)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("OQ10");
            entity.Property(e => e.Oq11)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("OQ11");
            entity.Property(e => e.Oq2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("OQ2");
            entity.Property(e => e.Oq3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("OQ3");
            entity.Property(e => e.Oq4)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("OQ4");
            entity.Property(e => e.Oq5)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("OQ5");
            entity.Property(e => e.Oq6)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("OQ6");
            entity.Property(e => e.Oq7)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("OQ7");
            entity.Property(e => e.Oq8)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("OQ8");
            entity.Property(e => e.Oq9)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("OQ9");
            entity.Property(e => e.Q1).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q10).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q11).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q2).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q3).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q4).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q5).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q6).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q7).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q8).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Q9).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.TCarat)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("T_Carat");
        });

        modelBuilder.Entity<RcustlstRpt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rcustlst#rpt$");

            entity.Property(e => e.AgrCode).HasColumnName("AGR_Code");
            entity.Property(e => e.CnCy).HasMaxLength(255);
            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.CompCode).HasColumnName("Comp_Code");
            entity.Property(e => e.GrCode)
                .HasMaxLength(255)
                .HasColumnName("GR_Code");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PType)
                .HasMaxLength(255)
                .HasColumnName("P_Type");
        });

        modelBuilder.Entity<RemaindMast>(entity =>
        {
            entity.HasKey(e => e.RemCode)
                .HasName("PK_Remainder")
                .HasFillFactor(90);

            entity.ToTable("RemaindMast");

            entity.Property(e => e.RemCode)
                .ValueGeneratedNever()
                .HasColumnName("Rem_Code");
            entity.Property(e => e.Action)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RemTime)
                .HasColumnType("datetime")
                .HasColumnName("Rem_Time");
            entity.Property(e => e.Remark)
                .HasMaxLength(5000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RsincMast>(entity =>
        {
            entity.HasKey(e => e.RsinCode)
                .HasName("PK_RINCMAST")
                .HasFillFactor(90);

            entity.ToTable("RSIncMast");

            entity.Property(e => e.RsinCode)
                .ValueGeneratedNever()
                .HasColumnName("RSIN_Code");
            entity.Property(e => e.Per).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.RsinName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RSIN_Name");
            entity.Property(e => e.SortName)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RsuplstRpt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rsuplst#rpt$");

            entity.Property(e => e.AgrCode).HasColumnName("AGR_Code");
            entity.Property(e => e.CnCy).HasMaxLength(255);
            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.CompCode).HasColumnName("Comp_Code");
            entity.Property(e => e.GrCode)
                .HasMaxLength(255)
                .HasColumnName("GR_Code");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PType)
                .HasMaxLength(255)
                .HasColumnName("P_Type");
        });

        modelBuilder.Entity<SalEncRate>(entity =>
        {
            entity.HasKey(e => new { e.CompCode, e.Digit }).HasFillFactor(90);

            entity.ToTable("SalEncRate");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Digit)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.EncVal)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SbillH>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.CompCode, e.AcYear })
                .HasName("PK_SBillH_1")
                .HasFillFactor(90);

            entity.ToTable("SBillH");

            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.AdvPay).HasColumnType("money");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AmtDiff).HasColumnType("money");
            entity.Property(e => e.BoutOk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BOutOk");
            entity.Property(e => e.BpayAmt)
                .HasColumnType("money")
                .HasColumnName("BPayAmt");
            entity.Property(e => e.BrCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CertAmt).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CommAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.CommCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comm_Code");
            entity.Property(e => e.CommPer)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 3)");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LabourRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.NcertAmt)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NCertAmt");
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.OutOk)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PayAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PrCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.Reference)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SracYear).HasColumnName("SRAcYear");
            entity.Property(e => e.Sramount)
                .HasColumnType("money")
                .HasColumnName("SRAmount");
            entity.Property(e => e.SrcompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SRComp_Code");
            entity.Property(e => e.SrinvNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SRInvNo");
            entity.Property(e => e.SrtrnNo).HasColumnName("SRTrnNo");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.TermAmt1).HasColumnType("money");
            entity.Property(e => e.TermAmt2).HasColumnType("money");
            entity.Property(e => e.TermAmt3).HasColumnType("money");
            entity.Property(e => e.TermAmt4).HasColumnType("money");
            entity.Property(e => e.TermAmt5).HasColumnType("money");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.VatAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.VatPer).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<SbillH226>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SBillH226");

            entity.Property(e => e.AdvPay).HasColumnType("money");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AmtDiff).HasColumnType("money");
            entity.Property(e => e.BoutOk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BOutOk");
            entity.Property(e => e.BpayAmt)
                .HasColumnType("money")
                .HasColumnName("BPayAmt");
            entity.Property(e => e.BrCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CertAmt).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CommAmt).HasColumnType("money");
            entity.Property(e => e.CommPer).HasColumnType("numeric(10, 3)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LabourRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.NcertAmt)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NCertAmt");
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.OutOk)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PayAmt).HasColumnType("money");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PrCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.Reference)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SracYear).HasColumnName("SRAcYear");
            entity.Property(e => e.Sramount)
                .HasColumnType("money")
                .HasColumnName("SRAmount");
            entity.Property(e => e.SrcompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SRComp_Code");
            entity.Property(e => e.SrinvNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SRInvNo");
            entity.Property(e => e.SrtrnNo).HasColumnName("SRTrnNo");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.TermAmt1).HasColumnType("money");
            entity.Property(e => e.TermAmt2).HasColumnType("money");
            entity.Property(e => e.TermAmt3).HasColumnType("money");
            entity.Property(e => e.TermAmt4).HasColumnType("money");
            entity.Property(e => e.TermAmt5).HasColumnType("money");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.VatAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.VatPer).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<SbillL>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.AcYear, e.CompCode })
                .HasName("PK_SBillL_1")
                .HasFillFactor(90);

            entity.ToTable("SBillL");

            entity.HasIndex(e => new { e.AcYear, e.CompCode }, "InxSBillLAcyearCompCode").HasFillFactor(90);

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.BrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.CertAmt).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CommAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.CommPer)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.CurrCost)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ForDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gamount)
                .HasColumnType("money")
                .HasColumnName("GAmount");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.ImpFor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpInvNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpStkCts).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lp3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP3");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Lt3)
                .HasColumnType("money")
                .HasColumnName("LT3");
            entity.Property(e => e.MacYear).HasColumnName("MAcYear");
            entity.Property(e => e.MemoOut)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MsrNo).HasColumnName("MSrNo");
            entity.Property(e => e.MtrnNo).HasColumnName("MTrnNo");
            entity.Property(e => e.NcertAmt)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NCertAmt");
            entity.Property(e => e.OrgAvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.Pcs).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PdisPer)
                .HasColumnType("money")
                .HasColumnName("PDisPer");
            entity.Property(e => e.PdisW)
                .HasColumnType("money")
                .HasColumnName("PDisW");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.RefType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.VatAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.VatPer).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<SbillL226>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SBillL226");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.BrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.CertAmt).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CommAmt).HasColumnType("money");
            entity.Property(e => e.CommPer).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.CurrCost).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gamount)
                .HasColumnType("money")
                .HasColumnName("GAmount");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.ImpFor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpInvNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpStkCts).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lp3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP3");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Lt3)
                .HasColumnType("money")
                .HasColumnName("LT3");
            entity.Property(e => e.MacYear).HasColumnName("MAcYear");
            entity.Property(e => e.MemoOut)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MsrNo).HasColumnName("MSrNo");
            entity.Property(e => e.MtrnNo).HasColumnName("MTrnNo");
            entity.Property(e => e.NcertAmt)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NCertAmt");
            entity.Property(e => e.OrgAvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PdisPer)
                .HasColumnType("money")
                .HasColumnName("PDisPer");
            entity.Property(e => e.PdisW)
                .HasColumnType("money")
                .HasColumnName("PDisW");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.RefType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.VatAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.VatPer).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<SbillLhOsTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SBillLH_OS_Temp");

            entity.Property(e => e.AdvPay).HasColumnType("money");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AmtDiff).HasColumnType("money");
            entity.Property(e => e.BoutOk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BOutOk");
            entity.Property(e => e.BpayAmt)
                .HasColumnType("money")
                .HasColumnName("BPayAmt");
            entity.Property(e => e.BrCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CertAmt).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CommAmt).HasColumnType("money");
            entity.Property(e => e.CommPer).HasColumnType("numeric(10, 3)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LabourRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.NcertAmt)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NCertAmt");
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.OutOk)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PayAmt).HasColumnType("money");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PrCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.Reference)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SracYear).HasColumnName("SRAcYear");
            entity.Property(e => e.Sramount)
                .HasColumnType("money")
                .HasColumnName("SRAmount");
            entity.Property(e => e.SrcompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SRComp_Code");
            entity.Property(e => e.SrinvNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SRInvNo");
            entity.Property(e => e.SrtrnNo).HasColumnName("SRTrnNo");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.TermAmt1).HasColumnType("money");
            entity.Property(e => e.TermAmt2).HasColumnType("money");
            entity.Property(e => e.TermAmt3).HasColumnType("money");
            entity.Property(e => e.TermAmt4).HasColumnType("money");
            entity.Property(e => e.TermAmt5).HasColumnType("money");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.VatAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.VatPer).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<SbillRetH>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.CompCode, e.AcYear })
                .HasName("PK_SBillRetH_1")
                .HasFillFactor(90);

            entity.ToTable("SBillRetH");

            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AmtDiff).HasColumnType("money");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.CertAmt).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.NcertAmt)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NCertAmt");
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.OutOk)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PayAmt).HasColumnType("money");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PrCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<SbillRetL>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear })
                .HasName("PK_SBillRetL_1")
                .HasFillFactor(90);

            entity.ToTable("SBillRetL");

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.CertAmt).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Gamount)
                .HasColumnType("money")
                .HasColumnName("GAmount");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lp3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP3");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Lt3)
                .HasColumnType("money")
                .HasColumnName("LT3");
            entity.Property(e => e.NcertAmt)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NCertAmt");
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PdisPer)
                .HasColumnType("money")
                .HasColumnName("PDisPer");
            entity.Property(e => e.PdisW)
                .HasColumnType("money")
                .HasColumnName("PDisW");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SacYear).HasColumnName("SAcYear");
            entity.Property(e => e.SinvNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SInvNo");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SsrNo).HasColumnName("SSrNo");
            entity.Property(e => e.StrnNo).HasColumnName("STrnNo");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<SbincMast>(entity =>
        {
            entity.HasKey(e => e.SbinCode)
                .HasName("PK_SBINCMAST")
                .HasFillFactor(90);

            entity.ToTable("SBIncMast");

            entity.Property(e => e.SbinCode)
                .ValueGeneratedNever()
                .HasColumnName("SBIN_Code");
            entity.Property(e => e.Per).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.SbinName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SBIN_Name");
            entity.Property(e => e.SortName)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ShpMast>(entity =>
        {
            entity.HasKey(e => e.SCode)
                .HasName("PK_SHPMAST")
                .HasFillFactor(90);

            entity.ToTable("ShpMast");

            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_Name");
        });

        modelBuilder.Entity<SincMast>(entity =>
        {
            entity.HasKey(e => e.SinCode)
                .HasName("PK_SINCMAST")
                .HasFillFactor(90);

            entity.ToTable("SIncMast");

            entity.Property(e => e.SinCode)
                .ValueGeneratedNever()
                .HasColumnName("SIN_Code");
            entity.Property(e => e.Per).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.SinName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SIN_Name");
            entity.Property(e => e.SortName)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SizeMast>(entity =>
        {
            entity.HasKey(e => e.SzCode)
                .HasName("PK_SIZEMAST")
                .HasFillFactor(90);

            entity.ToTable("SizeMast");

            entity.Property(e => e.SzCode)
                .ValueGeneratedNever()
                .HasColumnName("SZ_Code");
            entity.Property(e => e.Desc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FSize)
                .HasColumnType("numeric(8, 3)")
                .HasColumnName("F_Size");
            entity.Property(e => e.TSize)
                .HasColumnType("numeric(8, 3)")
                .HasColumnName("T_Size");
        });

        modelBuilder.Entity<SoincMast>(entity =>
        {
            entity.HasKey(e => e.SoinCode)
                .HasName("PK_SOINCMAST")
                .HasFillFactor(90);

            entity.ToTable("SOIncMast");

            entity.Property(e => e.SoinCode)
                .ValueGeneratedNever()
                .HasColumnName("SOIN_Code");
            entity.Property(e => e.Per).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.SoinName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SOIN_Name");
            entity.Property(e => e.SortName)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SpersonMast>(entity =>
        {
            entity.HasKey(e => e.PrCode)
                .HasName("PK_PERSONMAST")
                .HasFillFactor(90);

            entity.ToTable("SPersonMast");

            entity.Property(e => e.PrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PR_CODE");
            entity.Property(e => e.Ord).HasColumnName("ORD");
            entity.Property(e => e.Pf).HasColumnName("PF");
            entity.Property(e => e.PrName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_NAME");
            entity.Property(e => e.Spf).HasColumnName("SPF");
            entity.Property(e => e.Spord).HasColumnName("SPORD");
        });

        modelBuilder.Entity<StkTrfIss>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear, e.Type }).HasFillFactor(90);

            entity.ToTable("StkTrfIss");

            entity.HasIndex(e => new { e.AcYear, e.CompCode }, "InxStkTrfIssAcyearCompCode").HasFillFactor(90);

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.Carat)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.Fpid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("FPId");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PsrNo)
                .HasDefaultValue(0)
                .HasColumnName("PSrNo");
            entity.Property(e => e.PtrnNo)
                .HasDefaultValue(0)
                .HasColumnName("PTrnNo");
            entity.Property(e => e.Rate)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Tpid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TPId");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<StkTrfP>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear, e.Type })
                .HasName("PK_STKTRFP")
                .HasFillFactor(90);

            entity.ToTable("StkTrfP");

            entity.HasIndex(e => new { e.AcYear, e.CompCode }, "InxStkTrfPAcyearCompCode").HasFillFactor(90);

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.Fpid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("FPId");
            entity.Property(e => e.FpidOrgAvgRate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("FPIdOrgAvgRate");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.OrgAvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.PsrNo)
                .HasDefaultValue(0)
                .HasColumnName("PSrNo");
            entity.Property(e => e.PtrnNo)
                .HasDefaultValue(0)
                .HasColumnName("PTrnNo");
            entity.Property(e => e.Rate).HasColumnType("money");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Tpid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TPId");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<StkTrnfRec>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear, e.Type })
                .HasName("PK_StkTrfRec")
                .HasFillFactor(90);

            entity.ToTable("StkTrnfRec");

            entity.HasIndex(e => new { e.AcYear, e.CompCode }, "InxStkTrnfRecAcyearCompCode").HasFillFactor(90);

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.FpidOrgAvgRate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("FPIdOrgAvgRate");
            entity.Property(e => e.InvNo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.OrgAvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.Rate).HasColumnType("money");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Stock2015>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Stock2015");

            entity.Property(e => e.Amount).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Cname)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CName");
            entity.Property(e => e.CostAmt).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.CostPrice).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Crname)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CRName");
            entity.Property(e => e.Descr)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MemoInCrt).HasColumnType("numeric(20, 2)");
            entity.Property(e => e.MemoOutCrt).HasColumnType("numeric(21, 2)");
            entity.Property(e => e.ParPid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ParPId");
            entity.Property(e => e.PgCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PG_Code");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.Qname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("QName");
            entity.Property(e => e.SalAmt).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.SalesPrice).HasColumnType("numeric(29, 6)");
            entity.Property(e => e.SizeDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Stock).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.StockCrt).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<Stock2016>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Stock2016");

            entity.Property(e => e.Amount).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Cname)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CName");
            entity.Property(e => e.CostAmt).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.CostPrice).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Crname)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CRName");
            entity.Property(e => e.Descr)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MemoInCrt).HasColumnType("numeric(20, 2)");
            entity.Property(e => e.MemoOutCrt).HasColumnType("numeric(21, 2)");
            entity.Property(e => e.ParPid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ParPId");
            entity.Property(e => e.PgCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PG_Code");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.Qname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("QName");
            entity.Property(e => e.SalAmt).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.SalesPrice).HasColumnType("numeric(29, 6)");
            entity.Property(e => e.SizeDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SName");
            entity.Property(e => e.Stock).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.StockCrt).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<StockAdj>(entity =>
        {
            entity.HasKey(e => new { e.TrnNo, e.SrNo, e.CompCode, e.AcYear })
                .HasName("PK_StockAdj_1")
                .HasFillFactor(90);

            entity.ToTable("StockAdj");

            entity.HasIndex(e => new { e.AcYear, e.CompCode }, "InxStockAdjAcyearCompCode").HasFillFactor(90);

            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.OrgAvgRate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.Pm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PM");
            entity.Property(e => e.Rate).HasColumnType("money");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<StonNat>(entity =>
        {
            entity.HasKey(e => e.SnCode).HasFillFactor(90);

            entity.ToTable("StonNat");

            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.SnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SN_Name");
        });

        modelBuilder.Entity<TabAss>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TabAss");

            entity.Property(e => e.Aagrcode).HasColumnName("AAGRCode");
            entity.Property(e => e.Aagrname)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("AAGRName");
            entity.Property(e => e.Agrorder).HasColumnName("AGROrder");
            entity.Property(e => e.Apcode)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("APCode");
            entity.Property(e => e.Apname)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("APName");
            entity.Property(e => e.Assets).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Prn)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("PRN");
            entity.Property(e => e.Rn)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("RN");
        });

        modelBuilder.Entity<TabLium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TabLia");

            entity.Property(e => e.Lagrcode).HasColumnName("LAGRCode");
            entity.Property(e => e.Lagrname)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("LAGRName");
            entity.Property(e => e.Lgrorder).HasColumnName("LGROrder");
            entity.Property(e => e.Liabilities).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Lpcode)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("LPCode");
            entity.Property(e => e.Lpname)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("LPName");
            entity.Property(e => e.Prn)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("PRN");
            entity.Property(e => e.Rn)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("RN");
        });

        modelBuilder.Entity<TabTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TabTran");

            entity.Property(e => e.Agrcode).HasColumnName("AGRCode");
            entity.Property(e => e.Agrname)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("AGRName");
            entity.Property(e => e.Credit).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Debit).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Grorder).HasColumnName("GROrder");
            entity.Property(e => e.OpnAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Pcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PCode");
            entity.Property(e => e.Pname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PName");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TaskMast>(entity =>
        {
            entity.HasKey(e => new { e.TaskId, e.UserId }).HasFillFactor(90);

            entity.ToTable("TaskMast");

            entity.Property(e => e.TaskId).HasColumnName("TaskID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Task)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbincMast>(entity =>
        {
            entity.HasKey(e => e.TbinCode)
                .HasName("PK_BINCMAST")
                .HasFillFactor(90);

            entity.ToTable("TBIncMast");

            entity.Property(e => e.TbinCode)
                .ValueGeneratedNever()
                .HasColumnName("TBIN_Code");
            entity.Property(e => e.Per).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.SortName)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TbinName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TBIN_Name");
        });

        modelBuilder.Entity<TblBinaryFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblBinaryFiles");

            entity.Property(e => e.Ext)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.File)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Path)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempAbillInL>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempABillInL");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TempAbillOutL>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempABillOutL");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TempBalTab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TempBalTab");

            entity.Property(e => e.Aagrcode).HasColumnName("AAGRCode");
            entity.Property(e => e.Aagrname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AAGRName");
            entity.Property(e => e.Assets).HasColumnType("numeric(36, 2)");
            entity.Property(e => e.Ford).HasColumnName("FOrd");
            entity.Property(e => e.Frn).HasColumnName("FRN");
            entity.Property(e => e.Lia).HasColumnType("numeric(36, 2)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rord).HasColumnName("ROrd");
        });

        modelBuilder.Entity<TempPlperiod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TempPLPeriod");

            entity.Property(e => e.Aagrcode).HasColumnName("AAGRCode");
            entity.Property(e => e.Aagrname)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("AAGRName");
            entity.Property(e => e.Assets).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Ford).HasColumnName("FORd");
            entity.Property(e => e.Frn).HasColumnName("FRN");
            entity.Property(e => e.Liabilities).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<TempPltab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TempPLTab");

            entity.Property(e => e.Aagrcode).HasColumnName("AAGRCode");
            entity.Property(e => e.Aagrname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AAGRName");
            entity.Property(e => e.Assets).HasColumnType("numeric(36, 2)");
            entity.Property(e => e.Ford).HasColumnName("FOrd");
            entity.Property(e => e.Frn).HasColumnName("FRN");
            entity.Property(e => e.Lia).HasColumnType("numeric(36, 2)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rord).HasColumnName("ROrd");
        });

        modelBuilder.Entity<TempPltradTab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TempPLTradTab");

            entity.Property(e => e.Aagrcode).HasColumnName("AAGRCode");
            entity.Property(e => e.Aagrname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AAGRName");
            entity.Property(e => e.Assets).HasColumnType("numeric(36, 2)");
            entity.Property(e => e.Ford).HasColumnName("FOrd");
            entity.Property(e => e.Frn).HasColumnName("FRN");
            entity.Property(e => e.Lia).HasColumnType("numeric(36, 2)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rord).HasColumnName("ROrd");
        });

        modelBuilder.Entity<Test29012016>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Test29012016");

            entity.Property(e => e.AvgAmtOrig).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.AvgCaratOrig).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.AvgCost).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.AvgCostAfterMargin).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.AvgRatePs)
                .HasColumnType("numeric(38, 4)")
                .HasColumnName("AvgRatePS");
            entity.Property(e => e.Balance).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.CurrCost).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.CurrCostAfterMargin).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.InvNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("invNo");
            entity.Property(e => e.Margin).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.Op)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PName)
                .HasMaxLength(500)
                .HasColumnName("P_Name");
            entity.Property(e => e.PcnCy)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PCnCy");
            entity.Property(e => e.Pconv)
                .HasColumnType("numeric(38, 4)")
                .HasColumnName("PConv");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.Pm)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PM");
            entity.Property(e => e.ProfitLoss).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.ProfitLossPer).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.Rn).HasColumnName("RN");
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(38, 4)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(38, 4)")
                .HasColumnName("SRate");
            entity.Property(e => e.SratePconv)
                .HasColumnType("numeric(38, 4)")
                .HasColumnName("SRatePConv");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.UsedCarat).HasColumnType("numeric(10, 2)");
        });

        modelBuilder.Entity<TincMast>(entity =>
        {
            entity.HasKey(e => e.TinCode)
                .HasName("PK_TINCMAST")
                .HasFillFactor(90);

            entity.ToTable("TIncMast");

            entity.Property(e => e.TinCode)
                .ValueGeneratedNever()
                .HasColumnName("TIN_Code");
            entity.Property(e => e.Per).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.SortName)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TinName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIN_Name");
        });

        modelBuilder.Entity<ToincMast>(entity =>
        {
            entity.HasKey(e => e.ToinCode)
                .HasName("PK_OINCMAST")
                .HasFillFactor(90);

            entity.ToTable("TOIncMast");

            entity.Property(e => e.ToinCode)
                .ValueGeneratedNever()
                .HasColumnName("TOIN_Code");
            entity.Property(e => e.Per).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.SortName)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ToinName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TOIN_Name");
        });

        modelBuilder.Entity<TransferTableList>(entity =>
        {
            entity.HasKey(e => e.TableName).HasFillFactor(90);

            entity.ToTable("TransferTableList");

            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Trmmast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRMMAST");

            entity.Property(e => e.Days).HasColumnName("DAYS");
            entity.Property(e => e.TCode).HasColumnName("T_CODE");
            entity.Property(e => e.TSname)
                .HasMaxLength(8)
                .HasColumnName("T_SNAME");
        });

        modelBuilder.Entity<TrnMast>(entity =>
        {
            entity.HasKey(e => new { e.InvType, e.TrnNo, e.SrNo, e.CompCode, e.AcYear })
                .HasName("PK_TRNMAST")
                .HasFillFactor(90);

            entity.ToTable("TrnMast");

            entity.Property(e => e.InvType)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.SrNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.AcCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AC_Code");
            entity.Property(e => e.AcnCy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ACnCy");
            entity.Property(e => e.Aconv)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("AConv");
            entity.Property(e => e.AdjAmt).HasColumnType("money");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Bamount)
                .HasColumnType("money")
                .HasColumnName("BAmount");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DacYear).HasColumnName("DAcYear");
            entity.Property(e => e.DacYearAccode).HasColumnName("DAcYearACCode");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DetNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.DetNoAccode)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("DetNoACCode");
            entity.Property(e => e.DrAndCrPer)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.Dtp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DTP");
            entity.Property(e => e.Dtpaccode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DTPACCode");
            entity.Property(e => e.DtypeAccode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DTypeACCode");
            entity.Property(e => e.Edamount)
                .HasColumnType("money")
                .HasColumnName("EDAmount");
            entity.Property(e => e.IsTransfered).HasDefaultValue(false);
            entity.Property(e => e.JvseqNo).HasColumnName("JVSeqNo");
            entity.Property(e => e.LsrNo).HasColumnName("LSrNo");
            entity.Property(e => e.LtrnNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("LTrnNo");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PcnCy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("PCnCy");
            entity.Property(e => e.Pconv)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("PConv");
            entity.Property(e => e.PlsMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Prflag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFlag");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.TrnType)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrnMast226>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TrnMast226");

            entity.Property(e => e.AcCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AC_Code");
            entity.Property(e => e.AcnCy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ACnCy");
            entity.Property(e => e.Aconv)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("AConv");
            entity.Property(e => e.AdjAmt).HasColumnType("money");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Bamount)
                .HasColumnType("money")
                .HasColumnName("BAmount");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DacYear).HasColumnName("DAcYear");
            entity.Property(e => e.DacYearAccode).HasColumnName("DAcYearACCode");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DetNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.DetNoAccode)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("DetNoACCode");
            entity.Property(e => e.DrAndCrPer).HasColumnType("money");
            entity.Property(e => e.Dtp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DTP");
            entity.Property(e => e.Dtpaccode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DTPACCode");
            entity.Property(e => e.DtypeAccode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DTypeACCode");
            entity.Property(e => e.Edamount)
                .HasColumnType("money")
                .HasColumnName("EDAmount");
            entity.Property(e => e.InvType)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.JvseqNo).HasColumnName("JVSeqNo");
            entity.Property(e => e.LsrNo).HasColumnName("LSrNo");
            entity.Property(e => e.LtrnNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("LTrnNo");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PcnCy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("PCnCy");
            entity.Property(e => e.Pconv)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("PConv");
            entity.Property(e => e.PlsMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Prflag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFlag");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.SrNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.TrnType)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrnMastLocal>(entity =>
        {
            entity.HasKey(e => new { e.InvType, e.TrnNo, e.SrNo, e.CompCode, e.AcYear }).HasFillFactor(90);

            entity.ToTable("TrnMastLocal");

            entity.Property(e => e.InvType)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.SrNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.AcCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AC_Code");
            entity.Property(e => e.AcnCy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ACnCy");
            entity.Property(e => e.Aconv)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("AConv");
            entity.Property(e => e.AdjAmt).HasColumnType("money");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.IsTransfered).HasDefaultValue(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PcnCy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("PCnCy");
            entity.Property(e => e.Pconv)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("PConv");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TrnMastOsTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TrnMast_OS_temp");

            entity.Property(e => e.AcCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AC_Code");
            entity.Property(e => e.AcnCy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ACnCy");
            entity.Property(e => e.Aconv)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("AConv");
            entity.Property(e => e.AdjAmt).HasColumnType("money");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Bamount)
                .HasColumnType("money")
                .HasColumnName("BAmount");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DacYear).HasColumnName("DAcYear");
            entity.Property(e => e.DacYearAccode).HasColumnName("DAcYearACCode");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DetNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.DetNoAccode)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("DetNoACCode");
            entity.Property(e => e.DrAndCrPer).HasColumnType("money");
            entity.Property(e => e.Dtp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DTP");
            entity.Property(e => e.Dtpaccode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DTPACCode");
            entity.Property(e => e.DtypeAccode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DTypeACCode");
            entity.Property(e => e.Edamount)
                .HasColumnType("money")
                .HasColumnName("EDAmount");
            entity.Property(e => e.InvType)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.JvseqNo).HasColumnName("JVSeqNo");
            entity.Property(e => e.LsrNo).HasColumnName("LSrNo");
            entity.Property(e => e.LtrnNo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("LTrnNo");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PcnCy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("PCnCy");
            entity.Property(e => e.Pconv)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("PConv");
            entity.Property(e => e.PlsMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Prflag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRFlag");
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.SrNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.TrnType)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TypeMast>(entity =>
        {
            entity.HasKey(e => e.PType).HasFillFactor(90);

            entity.ToTable("TypeMast");

            entity.Property(e => e.PType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("P_Type");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserComp>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.CompCode }).HasFillFactor(90);

            entity.ToTable("UserComp");

            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
        });

        modelBuilder.Entity<UserRep>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.Rdate, e.Id }).HasFillFactor(90);

            entity.ToTable("UserRep");

            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Rdate)
                .HasColumnType("smalldatetime")
                .HasColumnName("RDate");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.CustName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Cust_Name");
            entity.Property(e => e.Demand)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("P_Name");
            entity.Property(e => e.Remark)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Rtime)
                .HasColumnType("datetime")
                .HasColumnName("RTime");
            entity.Property(e => e.Udemand)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("UDemand");
        });

        modelBuilder.Entity<VuGoldView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VU_GoldView");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Rate).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.StkOper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.TrnType)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Weight).HasColumnType("numeric(19, 4)");
        });

        modelBuilder.Entity<VuJewStockIssView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VU_JewStockIssView");

            entity.Property(e => e.Acyear).HasColumnName("ACyear");
            entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Carat).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Idate).HasColumnType("datetime");
            entity.Property(e => e.Oper)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<Zlog>(entity =>
        {
            entity.HasKey(e => new { e.Luser, e.CompName }).HasFillFactor(90);

            entity.ToTable("ZLog");

            entity.Property(e => e.Luser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.CompName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Time).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<ZlogAppIn>(entity =>
        {
            entity.HasKey(e => e.Idn).HasFillFactor(90);

            entity.ToTable("ZLogAppIn");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.DelCompName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelLuser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DelLUser");
            entity.Property(e => e.DelTime).HasColumnType("datetime");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Memo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Odetail)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ODetail");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Operation)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.PrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ZlogAppInRet>(entity =>
        {
            entity.HasKey(e => e.Idn).HasFillFactor(90);

            entity.ToTable("ZLogAppInRet");

            entity.Property(e => e.AacYear).HasColumnName("AAcYear");
            entity.Property(e => e.Amemo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AMemo");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AsrNo).HasColumnName("ASrNo");
            entity.Property(e => e.AtrnNo).HasColumnName("ATrnNo");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.DelCompName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelLuser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DelLUser");
            entity.Property(e => e.DelTime).HasColumnType("datetime");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Memo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Odetail)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ODetail");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Operation)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.PrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ZlogAppOut>(entity =>
        {
            entity.HasKey(e => e.Idn).HasFillFactor(90);

            entity.ToTable("ZLogAppOut");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.DelCompName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelLuser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DelLUser");
            entity.Property(e => e.DelTime).HasColumnType("datetime");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Memo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Odetail)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ODetail");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Operation)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.PrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ZlogAppOutRet>(entity =>
        {
            entity.HasKey(e => e.Idn).HasFillFactor(90);

            entity.ToTable("ZLogAppOutRet");

            entity.Property(e => e.AacYear).HasColumnName("AAcYear");
            entity.Property(e => e.Amemo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AMemo");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AsrNo).HasColumnName("ASrNo");
            entity.Property(e => e.AtrnNo).HasColumnName("ATrnNo");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.DelCompName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelLuser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DelLUser");
            entity.Property(e => e.DelTime).HasColumnType("datetime");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Memo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Odetail)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ODetail");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Operation)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.PrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ZlogPbillL>(entity =>
        {
            entity.HasKey(e => e.Idn).HasFillFactor(90);

            entity.ToTable("ZLogPBillL");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.DelCompName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelLuser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DelLUser");
            entity.Property(e => e.DelTime).HasColumnType("datetime");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.Gamount)
                .HasColumnType("money")
                .HasColumnName("GAmount");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lp3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP3");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Lt3)
                .HasColumnType("money")
                .HasColumnName("LT3");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.MacYear).HasColumnName("MAcYear");
            entity.Property(e => e.MemoIn)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MsrNo).HasColumnName("MSrNo");
            entity.Property(e => e.MtrnNo).HasColumnName("MTrnNo");
            entity.Property(e => e.Odetail)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ODetail");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Operation)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Pcom)
                .HasColumnType("money")
                .HasColumnName("PCom");
            entity.Property(e => e.PcomPer)
                .HasColumnType("money")
                .HasColumnName("PComPer");
            entity.Property(e => e.Pcs).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PdisPer)
                .HasColumnType("money")
                .HasColumnName("PDisPer");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Spkt).HasColumnName("SPkt");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ZlogPbillLret>(entity =>
        {
            entity.HasKey(e => e.Idn).HasFillFactor(90);

            entity.ToTable("ZLogPBillLRet");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.DelCompName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelLuser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DelLUser");
            entity.Property(e => e.DelTime).HasColumnType("datetime");
            entity.Property(e => e.Desc1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.Gamount)
                .HasColumnType("money")
                .HasColumnName("GAmount");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lp3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP3");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Lt3)
                .HasColumnType("money")
                .HasColumnName("LT3");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Odetail)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ODetail");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Operation)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PacYear).HasColumnName("PAcYear");
            entity.Property(e => e.Pcom)
                .HasColumnType("money")
                .HasColumnName("PCom");
            entity.Property(e => e.PcomPer)
                .HasColumnType("money")
                .HasColumnName("PComPer");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PdisPer)
                .HasColumnType("money")
                .HasColumnName("PDisPer");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.PinvNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PInvNo");
            entity.Property(e => e.PsrNo).HasColumnName("PSrNo");
            entity.Property(e => e.PtrnNo).HasColumnName("PTrnNo");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ZlogPktEnt>(entity =>
        {
            entity.HasKey(e => e.Idn).HasFillFactor(90);

            entity.ToTable("ZLogPktEnt");

            entity.Property(e => e.AvgCost).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.BinCode).HasColumnName("BIN_Code");
            entity.Property(e => e.BrnCode).HasColumnName("BRN_Code");
            entity.Property(e => e.BroCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BRO_Code");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.Cangle)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CAngle");
            entity.Property(e => e.Carat).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CertNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Cheight)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CHeight");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.CrCode).HasColumnName("CR_Code");
            entity.Property(e => e.CrtMax).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CrtMin).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CtCode).HasColumnName("CT_Code");
            entity.Property(e => e.CuCode).HasColumnName("CU_Code");
            entity.Property(e => e.CurCost).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.DelCompName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelLuser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DelLUser");
            entity.Property(e => e.DelTime).HasColumnType("datetime");
            entity.Property(e => e.Descr)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Diameter).HasColumnType("numeric(8, 3)");
            entity.Property(e => e.EfCode).HasColumnName("EF_Code");
            entity.Property(e => e.FlCode).HasColumnName("FL_Code");
            entity.Property(e => e.Girdle).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.GrCodeK).HasColumnName("GR_CodeK");
            entity.Property(e => e.GrCodeN).HasColumnName("GR_CodeN");
            entity.Property(e => e.Gweight)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("GWeight");
            entity.Property(e => e.HaCode).HasColumnName("HA_Code");
            entity.Property(e => e.Height).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.Length).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.LuCode).HasColumnName("LU_Code");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.Margin).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Odetail)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ODetail");
            entity.Property(e => e.OinCode).HasColumnName("OIN_Code");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Operation)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Pangle)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("PAngle");
            entity.Property(e => e.Pass).HasColumnName("PAss");
            entity.Property(e => e.Per).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Pheight)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("PHeight");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.PoCode).HasColumnName("PO_Code");
            entity.Property(e => e.PurQuan).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.Quan).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Rap).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Rate).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Ratio).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.RinCode).HasColumnName("RIN_Code");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SalCurSym)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SalQuan).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Sass).HasColumnName("SAss");
            entity.Property(e => e.SbinCode).HasColumnName("SBIN_Code");
            entity.Property(e => e.SinCode).HasColumnName("SIN_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.SoinCode).HasColumnName("SOIN_Code");
            entity.Property(e => e.Spkt).HasColumnName("SPkt");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SrateMin)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SRateMin");
            entity.Property(e => e.SyCode).HasColumnName("SY_Code");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.Table1).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.TinCode).HasColumnName("TIN_Code");
            entity.Property(e => e.TotDepth).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Width).HasColumnType("numeric(8, 2)");
        });

        modelBuilder.Entity<ZlogSbillL>(entity =>
        {
            entity.HasKey(e => e.Idn).HasFillFactor(90);

            entity.ToTable("ZLogSBillL");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.CertAmt).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.DelCompName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelLuser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DelLUser");
            entity.Property(e => e.DelTime).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.Gamount)
                .HasColumnType("money")
                .HasColumnName("GAmount");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lp3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP3");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Lt3)
                .HasColumnType("money")
                .HasColumnName("LT3");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.MacYear).HasColumnName("MAcYear");
            entity.Property(e => e.MemoOut)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MsrNo).HasColumnName("MSrNo");
            entity.Property(e => e.MtrnNo).HasColumnName("MTrnNo");
            entity.Property(e => e.NcertAmt)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NCertAmt");
            entity.Property(e => e.Odetail)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ODetail");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Operation)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PdisPer)
                .HasColumnType("money")
                .HasColumnName("PDisPer");
            entity.Property(e => e.PdisW)
                .HasColumnType("money")
                .HasColumnName("PDisW");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.PrCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ZlogSbillLret>(entity =>
        {
            entity.HasKey(e => e.Idn).HasFillFactor(90);

            entity.ToTable("ZLogSBillLRet");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.CertAmt).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CnCy)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("D_Code");
            entity.Property(e => e.DelCompName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelLuser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DelLUser");
            entity.Property(e => e.DelTime).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.Gamount)
                .HasColumnType("money")
                .HasColumnName("GAmount");
            entity.Property(e => e.ICode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("I_Code");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lp3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP3");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Lt3)
                .HasColumnType("money")
                .HasColumnName("LT3");
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.NcertAmt)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("NCertAmt");
            entity.Property(e => e.Odetail)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ODetail");
            entity.Property(e => e.Oper)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Operation)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Otype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OType");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.Pdis)
                .HasColumnType("money")
                .HasColumnName("PDis");
            entity.Property(e => e.PdisPer)
                .HasColumnType("money")
                .HasColumnName("PDisPer");
            entity.Property(e => e.PdisW)
                .HasColumnType("money")
                .HasColumnName("PDisW");
            entity.Property(e => e.Pid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PId");
            entity.Property(e => e.PrCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SacYear).HasColumnName("SAcYear");
            entity.Property(e => e.SinvNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SInvNo");
            entity.Property(e => e.SnCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SN_Code");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SsrNo).HasColumnName("SSrNo");
            entity.Property(e => e.StrnNo).HasColumnName("STrnNo");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ZlogTrnMast>(entity =>
        {
            entity.HasKey(e => e.Idn).HasFillFactor(90);

            entity.ToTable("ZLogTrnMast");

            entity.Property(e => e.AcCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AC_Code");
            entity.Property(e => e.AcnCy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ACnCy");
            entity.Property(e => e.Aconv)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("AConv");
            entity.Property(e => e.AdjAmt).HasColumnType("money");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Bamount)
                .HasColumnType("money")
                .HasColumnName("BAmount");
            entity.Property(e => e.CompCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Comp_Code");
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.DacYear).HasColumnName("DAcYear");
            entity.Property(e => e.DacYearAccode).HasColumnName("DAcYearACCode");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelCompName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelLuser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DelLUser");
            entity.Property(e => e.DelTime).HasColumnType("datetime");
            entity.Property(e => e.DetNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.DetNoAccode)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("DetNoACCode");
            entity.Property(e => e.Dtp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DTP");
            entity.Property(e => e.Dtpaccode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DTPACCode");
            entity.Property(e => e.Edamount)
                .HasColumnType("money")
                .HasColumnName("EDAmount");
            entity.Property(e => e.InvType)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Luser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUser");
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.Odetail)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ODetail");
            entity.Property(e => e.Operation)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.PcnCy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("PCnCy");
            entity.Property(e => e.Pconv)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("PConv");
            entity.Property(e => e.Remark).HasMaxLength(100);
            entity.Property(e => e.SrNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.TrnTime).HasColumnType("datetime");
            entity.Property(e => e.TrnType)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ZsbillH>(entity =>
        {
            entity.HasKey(e => e.Idn).HasFillFactor(90);

            entity.ToTable("ZSBillH");

            entity.Property(e => e.AddLessAmt)
                .HasComputedColumnSql("([NetAmt]-[Amount])", false)
                .HasColumnType("money");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AtrnNo).HasColumnName("ATrnNo");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.CnCy)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CompName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.Ddate)
                .HasColumnType("smalldatetime")
                .HasColumnName("DDate");
            entity.Property(e => e.Dtime)
                .HasColumnType("datetime")
                .HasColumnName("DTime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.Duser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DUser");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NetAmt).HasColumnType("money");
            entity.Property(e => e.OutOk)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.ParName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Par_Name");
            entity.Property(e => e.PayAmt).HasColumnType("money");
            entity.Property(e => e.PrCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_Code");
            entity.Property(e => e.PrName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PR_Name");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.Stype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SType");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
            entity.Property(e => e.TrnNo).HasColumnType("numeric(10, 0)");
        });

        modelBuilder.Entity<ZsbillL>(entity =>
        {
            entity.HasKey(e => e.Idn).HasFillFactor(90);

            entity.ToTable("ZSBillL");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AtrnNo).HasColumnName("ATrnNo");
            entity.Property(e => e.BrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BR_Code");
            entity.Property(e => e.BrName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BR_Name");
            entity.Property(e => e.Bramount)
                .HasColumnType("money")
                .HasColumnName("BRAmount");
            entity.Property(e => e.Brper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("BRPer");
            entity.Property(e => e.CCode).HasColumnName("C_Code");
            entity.Property(e => e.CName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("C_Name");
            entity.Property(e => e.Ccost)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("CCost");
            entity.Property(e => e.Ccper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("CCPer");
            entity.Property(e => e.CnCy)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Conv).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.Cost).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Cper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("CPer");
            entity.Property(e => e.Ddate)
                .HasColumnType("smalldatetime")
                .HasColumnName("DDate");
            entity.Property(e => e.Dtime)
                .HasColumnType("datetime")
                .HasColumnName("DTime");
            entity.Property(e => e.Gper)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("GPer");
            entity.Property(e => e.Grap)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("GRap");
            entity.Property(e => e.Grate)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("GRate");
            entity.Property(e => e.Lp1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP1");
            entity.Property(e => e.Lp2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP2");
            entity.Property(e => e.Lp3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("LP3");
            entity.Property(e => e.Lt1)
                .HasColumnType("money")
                .HasColumnName("LT1");
            entity.Property(e => e.Lt2)
                .HasColumnType("money")
                .HasColumnName("LT2");
            entity.Property(e => e.Lt3)
                .HasColumnType("money")
                .HasColumnName("LT3");
            entity.Property(e => e.PCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("P_Code");
            entity.Property(e => e.QCode).HasColumnName("Q_Code");
            entity.Property(e => e.QName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Q_Name");
            entity.Property(e => e.RCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("R_Carat");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SCarat)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("S_Carat");
            entity.Property(e => e.SCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("S_Code");
            entity.Property(e => e.SName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_Name");
            entity.Property(e => e.SerNo).HasColumnName("Ser_No");
            entity.Property(e => e.Sper)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SPer");
            entity.Property(e => e.Srate)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SRate");
            entity.Property(e => e.SzCode).HasColumnName("SZ_Code");
            entity.Property(e => e.TrnDate).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
