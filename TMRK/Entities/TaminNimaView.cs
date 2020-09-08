using System;
using System.Collections.Generic;

namespace TMRK.Entities
{
    public partial class TaminNimaView
    {
        public int? SabtesefareshCode { get; set; }
        public string BankShobehCode { get; set; }
        public string BankShobehDsc { get; set; }
        public decimal Amount { get; set; }
        public string SharhArzNima { get; set; }
        public int CodeArzNima { get; set; }
        public decimal? AmountDollarEq { get; set; }
        public string TarikhDarkhast { get; set; }
        public string DarkhastTypeDesc { get; set; }
        public string FishId { get; set; }
        public string CodeMelli { get; set; }
        public string ShenaseMelli { get; set; }
        public string TaminId { get; set; }
        public string FullName { get; set; }
        public string RequestStatusDesc { get; set; }
        public DateTime? NimaDate { get; set; }
        public int RequestCode { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? RecordInsertDateTime { get; set; }
    }
}
