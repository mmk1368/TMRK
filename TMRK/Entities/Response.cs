using System;
using System.Collections.Generic;

namespace TMRK.Entities
{
    public partial class Response
    {
        public long ResponseId { get; set; }
        public int ServiceId { get; set; }
        public int ServiceMethodId { get; set; }
        public string MethodOutput { get; set; }
        public string Exception { get; set; }
        public int? ErrorCode { get; set; }
        public DateTime ResponseTime { get; set; }
        public long? PointerId { get; set; }
        public string SummeryData { get; set; }
        public DateTime InsertDate { get; set; }
        public long? RequestId { get; set; }

        public virtual Request Request { get; set; }
    }
}
