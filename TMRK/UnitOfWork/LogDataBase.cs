using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMRK.Models;

namespace TMRK.UnitOfWork
{
    public partial class LogDataBase : IDisposable, ILogDataBase
    {
        TMRKLOGContext _logContext;
        public LogDataBase(TMRKLOGContext context)
        {
            _logContext = context;
        }
        public void Dispose()
        {
            _logContext.DisposeAsync();
        }
    }
}
