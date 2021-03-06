using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Domain
{
    /// <summary>
    /// </summary>
    /// <typeparam name="TDataConnection">Data connection provider</typeparam>
    public interface IServiceResource<TDataConnection>
    {
        void AddMember<TAbstract, TConcrete>();
        T Resolve<T>(bool IsTransient = true) where T : IRepository;
    }
    
    public abstract class ServiceResource<TDataConnection> : IServiceResource<TDataConnection>
    {
        protected readonly TDataConnection dataConnection;

        protected readonly IDictionary<string, Type> Repositories = new Dictionary<string, Type>();

        protected readonly IDictionary<string, IRepository> RepositoryInstances = new Dictionary<string, IRepository>();

        public void AddMember<TAbstract, TConcrete>()
        {
            Repositories.Add(typeof(TAbstract).Name, typeof(TConcrete));
        }

        public T Resolve<T>(bool IsTransient = true) where T : IRepository
        {
            if (IsTransient)
            {
                return (T)Activator.CreateInstance(Repositories[typeof(T).Name], dataConnection);
            }
            else
            {
                if (!RepositoryInstances.ContainsKey(typeof(T).Name))
                {
                    T Instance = (T)Activator.CreateInstance(Repositories[typeof(T).Name], dataConnection);
                    RepositoryInstances.Add(typeof(T).Name, Instance);
                    return Instance;
                }
                else
                {
                    return (T)RepositoryInstances[typeof(T).Name];
                }
            }
        }

       
    }

}
