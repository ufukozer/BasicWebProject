using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicWebProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicWebProject
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server=BIS-1013602241;" +
                                                 "Database=Project;" +
                                                 "Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<User> Users { get; set; }

    }
}