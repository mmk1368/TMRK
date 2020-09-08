using System;
using System.Collections.Generic;

namespace TMRK.Entities
{
    public partial class Request
    {
        public Request()
        {
            Response = new HashSet<Response>();
        }

        public long RequestId { get; set; }
        public int ServiceId { get; set; }
        public int ServiceMethodId { get; set; }
        public string MethodInput { get; set; }
        public DateTime CallTime { get; set; }
        public string SummeryData { get; set; }
        public string MethodOrginalName { get; set; }
        public DateTime InsertDate { get; set; }
        public long? PointerId { get; set; }

        public virtual ICollection<Response> Response { get; set; }
    }
}
