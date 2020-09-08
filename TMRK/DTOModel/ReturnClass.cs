using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMRK.DTOModel
{
    public class ReturnClass<T>
    {
        public T Result { get; set; }
        public string Message { get; set; }
        public int ErrorStatus { get; set; }
    }
}
