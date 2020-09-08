using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMRK.DTOModel
{
    public class CAIInput : ICAIInput
    {
        public string BankAuthorityNo { get; set; }
        public string NationalCode { get; set; }
        public int StartIndex { get; set; }
        public int PageSize { get; set; }
    }
}
