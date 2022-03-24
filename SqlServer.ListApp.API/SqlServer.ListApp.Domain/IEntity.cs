using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Domain
{
    public interface IEntity
    {
        public int Id { get; }
    }

    public interface ITimestampedEntity : IEntity
    {
        DateTime UpdatedAt { get; }
    }

    public interface IDeletableEntity
    {
        bool IsDeleted { get;  }
    }

    public abstract class Entity : IEntity , ITimestampedEntity , IDeletableEntity
    {
        int _Id;
        DateTime _updatedAt;
        bool _deleted;

        public virtual int Id
        {
            get
            {
                return _Id;
            }
            protected set
            {
                _Id = value;
            }
        }

        public virtual DateTime UpdatedAt
        {
            get
            {
                return _updatedAt;
            }
            protected set
            {
                _updatedAt = value;
            }
        }

        public bool IsDeleted
        {
            get
            {
                return _deleted;
            }
            protected set
            {
                _deleted = value;
            }
        }
    }
}
