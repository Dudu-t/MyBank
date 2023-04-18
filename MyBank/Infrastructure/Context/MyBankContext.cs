using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyBank.Domains.Entities;

namespace MyBank.Infrastructure.Context
{
    public class MyBankContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasMany(a => a.Customers).WithOne(c => c.Account).HasForeignKey(c => c.AccountId);
        }

        public string DbPath { get; }
        public MyBankContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var startPath = Environment.GetFolderPath(folder);
            var finishPath = System.IO.Path.Join(startPath, "MyBank");

            bool existsPath = System.IO.Directory.Exists(finishPath);

            if (!existsPath)
            {
                System.IO.Directory.CreateDirectory(finishPath);
            }
            
            DbPath = System.IO.Path.Join(finishPath, "MyBank.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }


    }
}
