using System;
using System.Collections.Generic;

namespace TMRK.Entities
{
    public partial class Coding
    {
        public decimal CodingId { get; set; }
        public decimal Code { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public decimal IsActive { get; set; }
        public string CodePad { get; set; }
        public string CodingType { get; set; }
        public decimal? CodeIndex { get; set; }
        public decimal IsSystemCoding { get; set; }
        public decimal? InvalidCode { get; set; }
    }
}
