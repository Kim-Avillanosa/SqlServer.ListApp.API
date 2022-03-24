using Microsoft.EntityFrameworkCore.Storage;
using SqlServer.ListApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Infrastructure
{
    public class UnitOfWork : UnitOfWorkBase<SqlServerServiceResource, AppDbContext>
    {

        private readonly IDbContextTransaction transaction;

        public UnitOfWork()
        {
            transaction = DataConnection.Database.BeginTransaction();
        }

        public override void Save()
        {
            try
            {
                transaction.Commit();
            }
            catch 
            {
                transaction.Rollback();
            }
        }

        public override void Revert()
        {
            transaction.Rollback();
        }


        public override void Dispose()
        {
            if(DataConnection != null)
            {
                DataConnection.Dispose();
                transaction.Dispose();
            }
           
        }
    }
}
