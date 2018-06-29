using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web_Work.Models.ItemDB
{
    //[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class FileContext : DbContext
    {
        public FileContext() : base("FileDB")
        { }

        public DbSet<Item> Items { get; set; }
    }
}