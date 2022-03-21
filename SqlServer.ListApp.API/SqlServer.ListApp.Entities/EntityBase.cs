using SqlServer.ListApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Entities
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
    }
    public abstract class DeletableEntityBase : IDeletableEntity
    {
        public int Id { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

    }
}
