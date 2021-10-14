using System;
using Entity.Table;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DataAccess
{
     public class ProductContext : DbContext
    {
        //https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/complex-data-model
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            //在此可对数据库连接字符串做加解密操作
        }

        public DbSet<Product> Courses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             base.OnModelCreating(modelBuilder);
        }
    }
}
