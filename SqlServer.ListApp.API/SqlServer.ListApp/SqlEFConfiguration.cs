using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SqlServer.ListApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Infrastructure
{
    static class SqlEFConfiguration
    {
        public class ListItemConfiguration : BaseEntityTypeConfiguration<ListItem>
        {
            public override void Configure(EntityTypeBuilder<ListItem> builder)
            {
                builder.ToTable("ListItems");

                builder.HasIndex(i => i.Value)
                    .HasDatabaseName("Idx_FirstName");

                builder.Property(x => x.Value).HasColumnType("value")
                    .HasColumnType("varchar(100)")
                    .IsRequired();


                builder.HasOne<User>().WithMany().HasPrincipalKey(x => x.Id)
                 .HasForeignKey(x => x.UserId)
                 .OnDelete(DeleteBehavior.NoAction)
                 .HasConstraintName("FK_ListItem_User");

                AddCreatedAndUpdatedAt(builder);

                builder.SeedItems();
            }
        }

        public class ItemDescriptionConfiguration : BaseEntityTypeConfiguration<ItemDescription>
        {
            public override void Configure(EntityTypeBuilder<ItemDescription> builder)
            {
                builder.ToTable("ListItemDescriptions");


                builder.Property(x => x.Remarks).HasColumnType("remarks")
                     .HasColumnType("varchar(100)")
                     .IsRequired();


                builder.HasOne<ListItem>().WithMany().HasPrincipalKey(x => x.Id)
                         .HasForeignKey(x => x.ItemId)
                         .OnDelete(DeleteBehavior.NoAction)
                         .HasConstraintName("FK_ListItem_ItemDescription");


                AddCreatedAndUpdatedAt(builder);

                builder.SeedItemDescription();
            }
        }

        public class UserConfiguration : BaseEntityTypeConfiguration<User>
        {
            public override void Configure(EntityTypeBuilder<User> builder)
            {
                builder.ToTable("User");
                
                builder.Property(x => x.Name).HasColumnType("name")
                  .HasColumnType("varchar(10)")
                  .IsRequired();

                builder.Property(x => x.Email).HasColumnType("email")
                 .HasColumnType("varchar(30)")
                 .IsRequired();
                 

                AddCreatedAndUpdatedAt(builder);

                builder.SeedUser();

            }
        }

    }
}
