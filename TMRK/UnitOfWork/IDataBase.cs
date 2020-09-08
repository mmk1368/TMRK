using TMRK.Entities;
using TMRK.Repository;

namespace TMRK.UnitOfWork
{
    public interface IDataBase
    {
        BaseRepository<TakhsisNtsw> TakhsisNtsw { get; }
        void Dispose();
    }
}