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
        private LogBaseRepository<Request> _request;
        public LogBaseRepository<Request> Request
        {
            get
            {
                if (_request == null)
                {
                    _request = new LogBaseRepository<Request>(_logContext);
                }
                return _request;
            }
        }
    }
}
