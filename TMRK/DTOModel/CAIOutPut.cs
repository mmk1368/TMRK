using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMRK.Entities;

namespace TMRK.DTOModel
{
    public class CAIOutPut : ICAIOutPut
    {
        public int Count { get; set; }
        public string LastUpdateDate { get; set; }
        public List<TakhsisInfo> TakhsisInfoList { get; set; }
    }
}
