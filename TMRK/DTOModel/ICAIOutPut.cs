using System;
using System.Collections.Generic;

namespace TMRK.DTOModel
{
    public interface ICAIOutPut
    {
        int Count { get; set; }
        string LastUpdateDate { get; set; }
        List<TakhsisInfo> TakhsisInfoList { get; set; }
    }
}