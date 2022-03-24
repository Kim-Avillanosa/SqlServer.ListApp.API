using SqlServer.ListApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Infrastructure
{
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly AppDbContext appDbContext;

        public RepositoryBase(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public virtual IQueryable<TEntity> FindAll() 
            => appDbContext.Set<TEntity>();

        public virtual IQueryable<TEntity>
            FindCondition(Expression<Func<TEntity, bool>> expression)
            => appDbContext.Set<TEntity>().Where(expression);

        public virtual TEntity Get(Expression<Func<TEntity, bool>> expression) 
            => appDbContext.Set<TEntity>().FirstOrDefault(expression);

        public virtual void Create(TEntity entity) 
            => appDbContext.Set<TEntity>().Add(entity);

        public virtual void Delete(TEntity entity) 
            => appDbContext.Set<TEntity>().Remove(entity);

        public virtual void Update(TEntity entity) 
            => appDbContext.Set<TEntity>().Update(entity);

       
    }
}
