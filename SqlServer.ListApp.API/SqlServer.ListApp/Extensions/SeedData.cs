using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SqlServer.ListApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Infrastructure
{
    public static class SeedData
    {
        public static void SeedItems(this EntityTypeBuilder<ListItem> builder)
        {
            builder.HasData(
                new ListItem(1, 1, "Eat"),
                new ListItem(2, 1, "Sleep"),
                new ListItem(3, 1, "Code"));
        }

        public static void SeedItemDescription(this EntityTypeBuilder<ItemDescription> builder)
        {
            builder.HasData(
                new ItemDescription(1, 1, "Must eat to survive"),
                new ItemDescription(2, 1, "Must sleep to survive"),
                new ItemDescription(3, 1, "Will code for coffee"));
        }

        public static void SeedUser(this EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User(1, "kmavillanosa@gmail.com", "Kim Cyriel S. Avillanosa"));
        }
    }
}
