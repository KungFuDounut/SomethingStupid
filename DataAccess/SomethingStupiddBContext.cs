using DataAccess.Entities;
using DataAccess.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class SomethingStupiddBContext : DbContext
    {
        protected string connectionString { get; set; }
        protected EnumDatabase database { get; set; }
        public DbSet<OrgUser> orgUsers { get; set; }
        
        public SomethingStupiddBContext(string conString, EnumDatabase db)
        {
            this.connectionString = conString;
            this.database = db;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (database == EnumDatabase.MSSQL)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }

            
        }
    }
}
