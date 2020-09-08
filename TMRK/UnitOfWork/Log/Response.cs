using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMRK.Entities;
using TMRK.Repository;

namespace TMRK.UnitOfWork
{
    public partial class LogDataBase
    {
        private LogBaseRepository<Response> _response;
        public LogBaseRepository<Response> Response
        {
            get
            {
                if (_response == null)
                {
                    _response = new LogBaseRepository<Response>(_logContext);
                }
                return _response;
            }
        }
    }
}
