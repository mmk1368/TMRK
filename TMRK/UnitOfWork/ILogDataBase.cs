using TMRK.Entities;
using TMRK.Repository;

namespace TMRK.UnitOfWork
{
    public interface ILogDataBase
    {
        LogBaseRepository<Request> Request { get; }
        LogBaseRepository<Response> Response { get; }

        void Dispose();
    }
}