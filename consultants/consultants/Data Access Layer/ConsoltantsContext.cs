using consultants.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace consultants.Data_Access_Layer
{
    public class ConsoltantsContext : DbContext
    {
        public ConsoltantsContext() : base("ConsoltantsContext")
        {

        }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}