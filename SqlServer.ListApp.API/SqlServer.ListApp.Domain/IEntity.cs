using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Domain
{
    public interface IEntity
    {
        public int Id { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
    }


    public interface IDeletableEntity : IEntity
    {
        public bool IsDeleted { get; set; }
    }
}
