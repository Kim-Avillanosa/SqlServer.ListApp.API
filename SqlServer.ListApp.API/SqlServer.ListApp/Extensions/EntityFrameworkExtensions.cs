using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SqlServer.ListApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Infrastructure
{
    public static class EntityFrameworkExtensions
    {
        //base entity builder
        internal static EntityTypeBuilder<TEntity> UseTimestampedProperty<TEntity>(this EntityTypeBuilder<TEntity> entity) 
            where TEntity : class, ITimestampedEntity
        {
            //entity.Property(d => d.CreatedAt)
            //    .HasColumnName("created_at")
            //    .HasColumnType("datetime")
            //    .ValueGeneratedOnAdd();
            entity.Property(d => d.UpdatedAt)
                .HasColumnName("updated_at")
                .HasColumnType("TIMESTAMP")
                .ValueGeneratedOnAddOrUpdate();

            //entity.Property(d => d.CreatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
            //entity.Property(d => d.CreatedAt).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            entity.Property(d => d.UpdatedAt).Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
            entity.Property(d => d.UpdatedAt).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

            return entity;
        }


       
    }
}
