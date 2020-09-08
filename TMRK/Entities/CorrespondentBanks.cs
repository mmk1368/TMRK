using System;
using System.Collections.Generic;

namespace TMRK.Entities
{
    public partial class CorrespondentBanks
    {
        public decimal CorrespondentBankId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string CountryName { get; set; }
        public decimal IsActive { get; set; }
        public decimal? CountryCodingId { get; set; }
    }
}
