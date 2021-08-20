using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Loja_do_Arlindo.Data
{
    public class Loja_do_ArlindoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Loja_do_ArlindoContext() : base("name=Loja_do_ArlindoContext")
        {
        }

        public System.Data.Entity.DbSet<Loja_do_Arlindo.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<Loja_do_Arlindo.Models.Product> Products { get; set; }
    }
}
