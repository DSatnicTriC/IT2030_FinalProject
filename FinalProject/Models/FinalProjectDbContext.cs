using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class FinalProjectDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FinalProjectDbContext() : base("name=FinalProjectDbContext")
        {
        }

        public virtual System.Data.Entity.DbSet<FinalProject.Models.Event> Events { get; set; }

        public virtual System.Data.Entity.DbSet<FinalProject.Models.EventType> EventTypes { get; set; }

        public virtual System.Data.Entity.DbSet<FinalProject.Models.User> Users { get; set; }
    }
}
