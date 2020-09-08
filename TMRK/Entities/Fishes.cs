using System;
using System.Collections.Generic;

namespace TMRK.Entities
{
    public partial class Fishes
    {
        public decimal FishId { get; set; }
        public decimal ImportRequestId { get; set; }
        public decimal? BranchId { get; set; }
        public string Status { get; set; }
        public decimal? FishAmount { get; set; }
        public decimal FishCurrencyCodingId { get; set; }
        public decimal? MonthToExpiration { get; set; }
        public decimal? BaseEquivalentAmount { get; set; }
        public decimal? CreationCodingDateId { get; set; }
        public decimal? AcceptanceCodingDateId { get; set; }
        public decimal? ExpirationCodingDateId { get; set; }
        public decimal? DaysToExpiration { get; set; }
        public decimal? DollarEquivalentAmount { get; set; }
        public decimal? EuroEquivalentAmount { get; set; }
        public decimal? PriorityTypeCodingId { get; set; }
        public decimal? MinistryCodingId { get; set; }
        public decimal? TradingTypeCodingId { get; set; }
        public decimal? CurrentFishEventId { get; set; }
        public string FishNumber { get; set; }
        public decimal? ExchangeRateTypeCodingId { get; set; }
        public decimal? CorrespondentBankId { get; set; }
        public decimal? CircularCodingId { get; set; }
        public decimal? LoanLocationCodingId { get; set; }
        public decimal? CreationCodingTimeId { get; set; }
        public decimal? AcceptanceCodingTimeId { get; set; }
        public decimal? BankId { get; set; }
        public DateTime? Version { get; set; }
        public decimal? RowNumber { get; set; }
        public decimal? AllocationCodingDateId { get; set; }
        public decimal? AllocationCodingTimeId { get; set; }
        public decimal? CancellationCodingDateId { get; set; }
        public decimal? CancellationCodingTimeId { get; set; }
        public decimal? HasCustomerCommitment { get; set; }
        public string Description { get; set; }
        public string FishType { get; set; }
        public string SourceType { get; set; }
        public decimal? PersonForeignExchangeLocationCodingId { get; set; }
        public string AllocationCode { get; set; }
        public decimal? AllocationCodingId { get; set; }
        public string AllocationDesc { get; set; }
        public decimal? AllocatedAvailableAmount { get; set; }
        public string MaxFobAmountGoodCode { get; set; }
        public string MaxFobAmountGoodDesc { get; set; }
        public string FishGoodCode { get; set; }
        public string FishGoodDesc { get; set; }
        public decimal? IsOptimizationException { get; set; }
        public string LastUpdateTime { get; set; }
        public decimal? OrganizationViewPoint { get; set; }
        public decimal? OriginalImportRequestId { get; set; }
        public decimal? GoodYearOfEntry { get; set; }
        public decimal? JobId { get; set; }
        public string ViewPointCategory { get; set; }
        public decimal? NewTradingTypeCodingId { get; set; }
        public decimal? NewGuarantorTypeCodingId { get; set; }
        public decimal? NewTermTypeCodingId { get; set; }
        public decimal? NewLoanLocationCodingId { get; set; }
        public decimal? NewExchangeRateTypeCodingId { get; set; }
        public decimal? NewForeignExchangeLocationCodingId { get; set; }
        public decimal? NewFishTypeCodingId { get; set; }
        public decimal? KharidArz { get; set; }
        public decimal? KharidArzCodingDateId { get; set; }
        public decimal? BankAuthorityNo { get; set; }
        public decimal? IsMaster { get; set; }
        public decimal? RejectionCodingDateId { get; set; }
        public decimal? ReadyAllocationCodingDateId { get; set; }
        public decimal? RejectionCodingTimeId { get; set; }
        public decimal? ReadyAllocationCodingTimeId { get; set; }
        public string OptimizationExceptionDetail { get; set; }
        public decimal? IsDuplicate { get; set; }
        public string ValidationResult { get; set; }
    }
}
