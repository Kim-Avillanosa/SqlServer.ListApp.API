using SqlServer.ListApp.Domain;
using SqlServer.ListApp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Infrastructure
{
    public class SqlServerServiceResource : ServiceResource<AppDbContext>
    {
        public SqlServerServiceResource()
        {
            AddMember<IListItemRepository, ListItemRepository>();

          
        }
    }
}
