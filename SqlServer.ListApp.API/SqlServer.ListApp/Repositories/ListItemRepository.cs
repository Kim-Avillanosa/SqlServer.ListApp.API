using SqlServer.ListApp.Domain;
using SqlServer.ListApp.Domain.Repositories;
using SqlServer.ListApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Infrastructure
{
    public class ListItemRepository : RepositoryBase<ListItem>, IListItemRepository
    {
        public ListItemRepository(AppDbContext appDbContext)
            : base(appDbContext) { }
    }
}
