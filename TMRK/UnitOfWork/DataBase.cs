using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMRK.Context;
using TMRK.Models;

namespace TMRK.UnitOfWork
{
    public partial class DataBase : IDisposable, IDataBase
    {
        Rep_gsandbContext _mainContext;
        public DataBase(Rep_gsandbContext context)
        {
            _mainContext = context;
        }
        public void Dispose()
        {
            _mainContext.DisposeAsync();
        }
    }
}
