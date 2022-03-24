using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Domain
{
    public interface IRepository { }

    public interface IRepository<TEntity> : IRepository
    {
        IQueryable<TEntity> FindAll();
        IQueryable<TEntity> FindCondition(Expression<Func<TEntity, bool>> expression);
        TEntity Get(Expression<Func<TEntity, bool>> expression);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
