using CleanArchDemo.Domain.Entitis.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Persistance.DemoDbContexts
{
    public class DemoDbContext(DbContextOptions<DemoDbContext> options) :DbContext(options) 
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(user =>
            {
                user.Property(e => e.Id);
                user.HasKey(e => e.Id);
            });
        }
        public DbSet<User> Users { get; set; }
    }
}
