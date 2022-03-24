using SqlServer.ListApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Entities
{
    public class ItemDescription : Entity
    {
        public ItemDescription(int id ,int itemId, string remarks)
        {
            Id = id;
            ItemId = itemId;
            Remarks = remarks;
        }

        public int ItemId { get; set; }
        public string Remarks { get; set; }
    }
}
