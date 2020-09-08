using System;
using System.Collections.Generic;

namespace TMRK.Entities
{
    public partial class TaminExpView
    {
        public string FishId { get; set; }
        public string Id { get; set; }
        public string MoteghaziName { get; set; }
        public decimal? MablaghArzi { get; set; }
        public string ArzDesc { get; set; }
        public string ArzCode { get; set; }
        public string MahalTaminArz { get; set; }
        public string CodeMelli { get; set; }
        public string ShenaseMelli { get; set; }
        public string TarikhDarkhast { get; set; }
        public string Kotaj { get; set; }
        public string GomrokCode { get; set; }
        public string CodeMeliSaderkonande { get; set; }
        public string ShenaseMeliSaderkonande { get; set; }
        public string BankAuthority { get; set; }
        public string BankShobehCode { get; set; }
        public string BankShobehDsc { get; set; }
        public decimal? MablaghMoadelDolari { get; set; }
        public string NerkhArzDesc { get; set; }
        public string CustomerType { get; set; }
        public string ExpStatusDsc { get; set; }
        public DateTime? RecordInsertDateTime { get; set; }
    }
}
