using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        void Rollback();
    }

    public abstract class UnitOfWorkBase<TServiceResource,TDataConnection> : IUnitOfWork
        where TServiceResource : IServiceResource<TDataConnection>
    {

        public abstract  void Rollback();

        public abstract  void Save();

        public abstract  void Dispose();
    }


}
