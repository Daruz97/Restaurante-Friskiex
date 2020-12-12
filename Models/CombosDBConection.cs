using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Restaurante_Friskiex.Models
{
    public class CombosDBConection : DbContext
    {
        public CombosDBConection(): base ("CombosDB")
        {
         
       
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
      public  DbSet<Combos>  Comboss { get; set; }
    }

}