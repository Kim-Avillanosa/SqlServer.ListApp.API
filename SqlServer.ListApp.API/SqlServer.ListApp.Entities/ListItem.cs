using SqlServer.ListApp.Domain;
using System;

namespace SqlServer.ListApp.Entities
{
    public class ListItem : Entity
    {
        public string Value { get; set; }

        public int UserId { get; set; }

        public ListItem(int id, int userId, string value)
        {
            Id = id;
            UserId = UserId;
            Value = value;
        }

     
    }
}
