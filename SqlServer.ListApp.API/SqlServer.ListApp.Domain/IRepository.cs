using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Domain
{
    public interface IRepository : IDisposable
    {
        public void Add<TEntity>(TEntity item);
        public void Update<TEntity>(int Id, TEntity value);
        public bool Delete(int Id);

        public IQueryable<TEntity> Get<TEntity>(Func<TEntity, bool> function);


    }

}
