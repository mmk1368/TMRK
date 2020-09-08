using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TMRK.Entities;

namespace TMRK.Context
{
    public partial class Rep_gsandbContext : DbContext
    {
        public Rep_gsandbContext()
        {
        }

        public Rep_gsandbContext(DbContextOptions<Rep_gsandbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Coding> Coding { get; set; }
        public virtual DbSet<CorrespondentBanks> CorrespondentBanks { get; set; }
        public virtual DbSet<Fishes> Fishes { get; set; }
        public virtual DbSet<FishesCount> FishesCount { get; set; }
        public virtual DbSet<TakhsisNtsw> TakhsisNtsw { get; set; }
        public virtual DbSet<TaminBankiView> TaminBankiView { get; set; }
        public virtual DbSet<TaminExpView> TaminExpView { get; set; }
        public virtual DbSet<TaminNimaView> TaminNimaView { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer("Server=.;Database=Rep_gsandb;Trusted_Connection=True;");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coding>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CODING", "SWTBIM");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.CodeIndex)
                    .HasColumnName("CODE_INDEX")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodePad)
                    .HasColumnName("CODE_PAD")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CodingId)
                    .HasColumnName("CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.CodingType)
                    .IsRequired()
                    .HasColumnName("CODING_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("DISPLAY_NAME")
                    .HasMaxLength(1024);

                entity.Property(e => e.InvalidCode)
                    .HasColumnName("INVALID_CODE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsSystemCoding)
                    .HasColumnName("IS_SYSTEM_CODING")
                    .HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<CorrespondentBanks>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CORRESPONDENT_BANKS", "SWTBIM");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CorrespondentBankId)
                    .HasColumnName("CORRESPONDENT_BANK_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.CountryCodingId)
                    .HasColumnName("COUNTRY_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.CountryName)
                    .HasColumnName("COUNTRY_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Fishes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FISHES", "SWTFXA");

                entity.Property(e => e.AcceptanceCodingDateId)
                    .HasColumnName("ACCEPTANCE_CODING_DATE_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.AcceptanceCodingTimeId)
                    .HasColumnName("ACCEPTANCE_CODING_TIME_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.AllocatedAvailableAmount)
                    .HasColumnName("ALLOCATED_AVAILABLE_AMOUNT")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.AllocationCode)
                    .HasColumnName("ALLOCATION_CODE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AllocationCodingDateId)
                    .HasColumnName("ALLOCATION_CODING_DATE_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.AllocationCodingId)
                    .HasColumnName("ALLOCATION_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.AllocationCodingTimeId)
                    .HasColumnName("ALLOCATION_CODING_TIME_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.AllocationDesc)
                    .HasColumnName("ALLOCATION_DESC")
                    .HasMaxLength(255);

                entity.Property(e => e.BankAuthorityNo)
                    .HasColumnName("BANK_AUTHORITY_NO")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.BankId)
                    .HasColumnName("BANK_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.BaseEquivalentAmount)
                    .HasColumnName("BASE_EQUIVALENT_AMOUNT")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BRANCH_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.CancellationCodingDateId)
                    .HasColumnName("CANCELLATION_CODING_DATE_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.CancellationCodingTimeId)
                    .HasColumnName("CANCELLATION_CODING_TIME_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.CircularCodingId)
                    .HasColumnName("CIRCULAR_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.CorrespondentBankId)
                    .HasColumnName("CORRESPONDENT_BANK_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.CreationCodingDateId)
                    .HasColumnName("CREATION_CODING_DATE_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.CreationCodingTimeId)
                    .HasColumnName("CREATION_CODING_TIME_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.CurrentFishEventId)
                    .HasColumnName("CURRENT_FISH_EVENT_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.DaysToExpiration)
                    .HasColumnName("DAYS_TO_EXPIRATION")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1024);

                entity.Property(e => e.DollarEquivalentAmount)
                    .HasColumnName("DOLLAR_EQUIVALENT_AMOUNT")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.EuroEquivalentAmount)
                    .HasColumnName("EURO_EQUIVALENT_AMOUNT")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.ExchangeRateTypeCodingId)
                    .HasColumnName("EXCHANGE_RATE_TYPE_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.ExpirationCodingDateId)
                    .HasColumnName("EXPIRATION_CODING_DATE_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.FishAmount)
                    .HasColumnName("FISH_AMOUNT")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.FishCurrencyCodingId)
                    .HasColumnName("FISH_CURRENCY_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.FishGoodCode)
                    .HasColumnName("FISH_GOOD_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FishGoodDesc)
                    .HasColumnName("FISH_GOOD_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.FishId)
                    .HasColumnName("FISH_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.FishNumber)
                    .IsRequired()
                    .HasColumnName("FISH_NUMBER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FishType)
                    .HasColumnName("FISH_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoodYearOfEntry)
                    .HasColumnName("GOOD_YEAR_OF_ENTRY")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.HasCustomerCommitment)
                    .HasColumnName("HAS_CUSTOMER_COMMITMENT")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ImportRequestId)
                    .HasColumnName("IMPORT_REQUEST_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.IsDuplicate)
                    .HasColumnName("IS_DUPLICATE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IsMaster)
                    .HasColumnName("IS_MASTER")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.IsOptimizationException)
                    .HasColumnName("IS_OPTIMIZATION_EXCEPTION")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.KharidArz)
                    .HasColumnName("KHARID_ARZ")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.KharidArzCodingDateId)
                    .HasColumnName("KHARID_ARZ_CODING_DATE_ID")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("LAST_UPDATE_TIME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoanLocationCodingId)
                    .HasColumnName("LOAN_LOCATION_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.MaxFobAmountGoodCode)
                    .HasColumnName("MAX_FOB_AMOUNT_GOOD_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MaxFobAmountGoodDesc)
                    .HasColumnName("MAX_FOB_AMOUNT_GOOD_DESC")
                    .HasMaxLength(512);

                entity.Property(e => e.MinistryCodingId)
                    .HasColumnName("MINISTRY_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.MonthToExpiration)
                    .HasColumnName("MONTH_TO_EXPIRATION")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NewExchangeRateTypeCodingId)
                    .HasColumnName("NEW_EXCHANGE_RATE_TYPE_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.NewFishTypeCodingId)
                    .HasColumnName("NEW_FISH_TYPE_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.NewForeignExchangeLocationCodingId)
                    .HasColumnName("NEW_FOREIGN_EXCHANGE_LOCATION_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.NewGuarantorTypeCodingId)
                    .HasColumnName("NEW_GUARANTOR_TYPE_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.NewLoanLocationCodingId)
                    .HasColumnName("NEW_LOAN_LOCATION_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.NewTermTypeCodingId)
                    .HasColumnName("NEW_TERM_TYPE_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.NewTradingTypeCodingId)
                    .HasColumnName("NEW_TRADING_TYPE_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.OptimizationExceptionDetail)
                    .HasColumnName("OPTIMIZATION_EXCEPTION_DETAIL")
                    .HasMaxLength(512);

                entity.Property(e => e.OrganizationViewPoint)
                    .HasColumnName("ORGANIZATION_VIEW_POINT")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.OriginalImportRequestId)
                    .HasColumnName("ORIGINAL_IMPORT_REQUEST_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.PersonForeignExchangeLocationCodingId)
                    .HasColumnName("PERSON_FOREIGN_EXCHANGE_LOCATION_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.PriorityTypeCodingId)
                    .HasColumnName("PRIORITY_TYPE_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.ReadyAllocationCodingDateId)
                    .HasColumnName("READY_ALLOCATION_CODING_DATE_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.ReadyAllocationCodingTimeId)
                    .HasColumnName("READY_ALLOCATION_CODING_TIME_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.RejectionCodingDateId)
                    .HasColumnName("REJECTION_CODING_DATE_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.RejectionCodingTimeId)
                    .HasColumnName("REJECTION_CODING_TIME_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.RowNumber)
                    .HasColumnName("ROW_NUMBER")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.SourceType)
                    .HasColumnName("SOURCE_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TradingTypeCodingId)
                    .HasColumnName("TRADING_TYPE_CODING_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.ValidationResult).HasColumnName("VALIDATION_RESULT");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.ViewPointCategory)
                    .HasColumnName("VIEW_POINT_CATEGORY")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FishesCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Fishes_count");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TakhsisNtsw>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("takhsisNTSW");

                entity.Property(e => e.ArzCode)
                    .HasColumnName("arzCode")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ArzDsc)
                    .HasColumnName("arzDsc")
                    .HasMaxLength(100);

                entity.Property(e => e.BakhshnameCodeJadid)
                    .HasColumnName("bakhshnameCodeJadid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankAuthorityNo)
                    .HasColumnName("bankAuthorityNo")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BankShobehCode)
                    .HasColumnName("bankShobehCode")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BankShobehDsc)
                    .HasColumnName("bankShobehDsc")
                    .HasMaxLength(100);

                entity.Property(e => e.BeneficiaryCountryCode)
                    .HasColumnName("beneficiaryCountryCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiaryCountryDsc)
                    .HasColumnName("beneficiaryCountryDsc")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CodeMelli)
                    .HasColumnName("codeMelli")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CommercialCardNo)
                    .HasColumnName("commercialCardNo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ContractTypeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContractTypeDsc).HasMaxLength(80);

                entity.Property(e => e.FishType)
                    .IsRequired()
                    .HasColumnName("fishType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FullName)
                    .HasColumnName("fullName")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kargozar)
                    .HasColumnName("kargozar")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.KharidArz).HasColumnName("kharidArz");

                entity.Property(e => e.MablaghArzi)
                    .HasColumnName("mablaghArzi")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.MablaghMoadelDolari).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.MahalCode)
                    .HasColumnName("mahalCode")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MahalTaminArz)
                    .HasColumnName("mahalTaminArz")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MahaleTashilatCode)
                    .HasColumnName("mahaleTashilatCode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MahaleTashilatDsc)
                    .HasColumnName("mahaleTashilatDsc")
                    .HasMaxLength(50);

                entity.Property(e => e.ModdatBeMah).HasColumnName("moddatBeMah");

                entity.Property(e => e.MohlatEngheza).HasColumnName("mohlatEngheza");

                entity.Property(e => e.NerkhArzCode)
                    .HasColumnName("nerkhArzCode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NerkhArzDsc)
                    .HasColumnName("nerkhArzDsc")
                    .HasMaxLength(50);

                entity.Property(e => e.NezaratTaeedVaziyat).HasColumnName("nezaratTaeedVaziyat");

                entity.Property(e => e.Omran).HasMaxLength(50);

                entity.Property(e => e.OnvanKhedmat)
                    .HasColumnName("onvanKhedmat")
                    .HasMaxLength(512);

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Radif).HasColumnName("radif");

                entity.Property(e => e.RecordInsertDateTime).HasColumnType("datetime");

                entity.Property(e => e.RequestCode).HasColumnName("requestCode");

                entity.Property(e => e.ShenaseMelli)
                    .HasColumnName("shenaseMelli")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Taahod).HasColumnName("taahod");

                entity.Property(e => e.TakhsisCode)
                    .HasColumnName("takhsisCode")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TakhsisDsc)
                    .HasColumnName("takhsisDsc")
                    .HasMaxLength(100);

                entity.Property(e => e.TarefeCodeBz)
                    .HasColumnName("tarefeCodeBZ")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarefeDscBz)
                    .HasColumnName("tarefeDscBZ")
                    .HasMaxLength(1000);

                entity.Property(e => e.TarikhEbtalFish)
                    .HasColumnName("tarikhEbtalFish")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TarikhIjadFish)
                    .HasColumnName("tarikhIjadFish")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TarikhMojavez)
                    .HasColumnName("tarikhMojavez")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TarikhTaeedFish)
                    .HasColumnName("tarikhTaeedFish")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TarikhTaminArz)
                    .HasColumnName("tarikhTaminArz")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TimeEbtalFish)
                    .HasColumnName("timeEbtalFish")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeIjadFish)
                    .HasColumnName("timeIjadFish")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeTaeedFish)
                    .HasColumnName("timeTaeedFish")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TradingTypeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TradingTypeDsc).HasMaxLength(250);
            });

            modelBuilder.Entity<TaminBankiView>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tamin_banki_view");

                entity.Property(e => e.ArzCode)
                    .HasColumnName("arzCode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ArzDesc)
                    .HasColumnName("arzDesc")
                    .HasMaxLength(255);

                entity.Property(e => e.BankAuthority)
                    .HasColumnName("bankAuthority")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BankShobehCode)
                    .HasColumnName("bankShobehCode")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BankShobehDsc)
                    .HasColumnName("bankShobehDsc")
                    .HasMaxLength(100);

                entity.Property(e => e.CodeMelli)
                    .HasColumnName("codeMelli")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.FishId)
                    .HasColumnName("fishID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasColumnName("fullName")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MablaghArzi)
                    .HasColumnName("mablaghArzi")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.MablaghMoadelDolari).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.NerkhArzDesc)
                    .HasColumnName("nerkhArzDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.RecordInsertDateTime).HasColumnType("datetime");

                entity.Property(e => e.ShenaseMelli)
                    .HasColumnName("shenaseMelli")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TarikhDarkhast)
                    .HasColumnName("tarikhDarkhast")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Vaziyat)
                    .IsRequired()
                    .HasColumnName("vaziyat")
                    .HasMaxLength(9);
            });

            modelBuilder.Entity<TaminExpView>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tamin_exp_view");

                entity.Property(e => e.ArzCode)
                    .HasColumnName("arzCode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ArzDesc)
                    .HasColumnName("arzDesc")
                    .HasMaxLength(255);

                entity.Property(e => e.BankAuthority)
                    .HasColumnName("bankAuthority")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BankShobehCode)
                    .HasColumnName("bankShobehCode")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BankShobehDsc)
                    .HasColumnName("bankShobehDsc")
                    .HasMaxLength(100);

                entity.Property(e => e.CodeMeliSaderkonande)
                    .HasColumnName("codeMeliSaderkonande")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodeMelli)
                    .HasColumnName("codeMelli")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerType)
                    .IsRequired()
                    .HasColumnName("customerType")
                    .HasMaxLength(5);

                entity.Property(e => e.ExpStatusDsc)
                    .HasColumnName("expStatusDsc")
                    .HasMaxLength(15);

                entity.Property(e => e.FishId)
                    .HasColumnName("fishID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.GomrokCode)
                    .HasColumnName("gomrokCode")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Kotaj)
                    .HasColumnName("kotaj")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MablaghArzi)
                    .HasColumnName("mablaghArzi")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.MablaghMoadelDolari).HasColumnType("numeric(20, 2)");

                entity.Property(e => e.MahalTaminArz)
                    .HasColumnName("mahalTaminArz")
                    .HasMaxLength(30);

                entity.Property(e => e.MoteghaziName)
                    .HasColumnName("moteghaziName")
                    .HasMaxLength(256);

                entity.Property(e => e.NerkhArzDesc)
                    .HasColumnName("nerkhArzDesc")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.RecordInsertDateTime).HasColumnType("datetime");

                entity.Property(e => e.ShenaseMeliSaderkonande)
                    .HasColumnName("shenaseMeliSaderkonande")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ShenaseMelli)
                    .HasColumnName("shenaseMelli")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TarikhDarkhast)
                    .HasColumnName("tarikhDarkhast")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaminNimaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tamin_nima_view");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("money");

                entity.Property(e => e.AmountDollarEq)
                    .HasColumnName("Amount_DollarEq")
                    .HasColumnType("money");

                entity.Property(e => e.BankShobehCode)
                    .HasColumnName("bankShobehCode")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BankShobehDsc)
                    .HasColumnName("bankShobehDsc")
                    .HasMaxLength(100);

                entity.Property(e => e.CodeMelli)
                    .HasColumnName("codeMelli")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DarkhastTypeDesc)
                    .HasColumnName("darkhastTypeDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.FishId)
                    .HasColumnName("fishID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasColumnName("fullName")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NimaDate)
                    .HasColumnName("nimaDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecordInsertDateTime).HasColumnType("datetime");

                entity.Property(e => e.RequestCode).HasColumnName("requestCode");

                entity.Property(e => e.RequestStatusDesc)
                    .HasColumnName("requestStatusDesc")
                    .HasMaxLength(24);

                entity.Property(e => e.SabtesefareshCode).HasColumnName("sabtesefareshCode");

                entity.Property(e => e.SharhArzNima)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShenaseMelli)
                    .HasColumnName("shenaseMelli")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TaminId)
                    .HasColumnName("taminID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TarikhDarkhast)
                    .HasColumnName("tarikhDarkhast")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
