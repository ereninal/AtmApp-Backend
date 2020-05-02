using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CustomerContext : DbContext
    {
        //Buradaki nesneler ile veritabanındaki tablo nesnelerini eşleştiricez
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AtmDB;Trusted_Connection=true");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
