using System;
using Entity.Table;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DataAccess
{
     public class SampleContext : DbContext
    {
        //https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/complex-data-model
        public SampleContext(DbContextOptions<SampleContext> options) : base(options)
        {
            //在此可对数据库连接字符串做加解密操作
        }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             base.OnModelCreating(modelBuilder);
        }
    }
}
