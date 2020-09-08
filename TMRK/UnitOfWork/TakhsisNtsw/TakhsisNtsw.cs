using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMRK.Entities;
using TMRK.Repository;

namespace TMRK.UnitOfWork
{
    public partial class DataBase
    {
        private BaseRepository<TakhsisNtsw> _takhsisNtsw;
        public BaseRepository<TakhsisNtsw> TakhsisNtsw
        {
            get
            {
                if (_takhsisNtsw == null)
                {
                    _takhsisNtsw = new BaseRepository<TakhsisNtsw>(_mainContext);
                }
                return _takhsisNtsw;
            }
        }
    }
}
