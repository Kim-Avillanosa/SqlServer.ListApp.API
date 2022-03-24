using SqlServer.ListApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Entities
{
    public class User : Entity
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public IEnumerable<ListItem> Items { get; set; }

        public User(int id, string email, string name)
        {
            Id = id;
            Email = email;
            Name = name;
        }



     

    }
}
