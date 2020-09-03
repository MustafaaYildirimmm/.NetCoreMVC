using Microsoft.EntityFrameworkCore;
using NetCoreMVC.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreMVC.DataAccess.Concrete.EntityFramework.Context
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=.;initial catalog=northwind;persist security info=True;user id=sa;password=123");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
