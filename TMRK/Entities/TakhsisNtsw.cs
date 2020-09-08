using System;
using System.Collections.Generic;

namespace TMRK.Entities
{
    public partial class TakhsisNtsw
    {
        public string Id { get; set; }
        public long? RequestCode { get; set; }
        public string BankAuthorityNo { get; set; }
        public int? Radif { get; set; }
        public string BankShobehCode { get; set; }
        public string BankShobehDsc { get; set; }
        public decimal? MablaghArzi { get; set; }
        public string ArzCode { get; set; }
        public string ArzDsc { get; set; }
        public int NezaratTaeedVaziyat { get; set; }
        public string TarikhMojavez { get; set; }
        public string NerkhArzCode { get; set; }
        public string NerkhArzDsc { get; set; }
        public string TimeTaeedFish { get; set; }
        public string TimeEbtalFish { get; set; }
        public string TimeIjadFish { get; set; }
        public short? MohlatEngheza { get; set; }
        public byte? ModdatBeMah { get; set; }
        public string FishType { get; set; }
        public string ContractTypeCode { get; set; }
        public string ContractTypeDsc { get; set; }
        public string TradingTypeCode { get; set; }
        public string TradingTypeDsc { get; set; }
        public string CommercialCardNo { get; set; }
        public string FullName { get; set; }
        public string CodeMelli { get; set; }
        public string ShenaseMelli { get; set; }
        public string TakhsisCode { get; set; }
        public string TakhsisDsc { get; set; }
        public decimal? MablaghMoadelDolari { get; set; }
        public string TarikhIjadFish { get; set; }
        public string TarikhTaeedFish { get; set; }
        public string TarikhEbtalFish { get; set; }
        public string OnvanKhedmat { get; set; }
        public bool KharidArz { get; set; }
        public string BakhshnameCodeJadid { get; set; }
        public string Omran { get; set; }
        public string BeneficiaryCountryCode { get; set; }
        public string BeneficiaryCountryDsc { get; set; }
        public string Kargozar { get; set; }
        public string MahalTaminArz { get; set; }
        public string TarikhTaminArz { get; set; }
        public string MahaleTashilatCode { get; set; }
        public string MahaleTashilatDsc { get; set; }
        public string TarefeCodeBz { get; set; }
        public string TarefeDscBz { get; set; }
        public bool? Taahod { get; set; }
        public string MahalCode { get; set; }
        public string Priority { get; set; }
        public DateTime? RecordInsertDateTime { get; set; }
    }
}
