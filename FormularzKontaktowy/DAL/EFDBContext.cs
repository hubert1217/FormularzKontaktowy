using FormularzKontaktowy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FormularzKontaktowy.DAL
{
    public class EFDBContext : DbContext
    {
        public EFDBContext() : base("FormularzKontaktowy")
        { 
            
        }

        public DbSet<Client> Clients { set; get; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}