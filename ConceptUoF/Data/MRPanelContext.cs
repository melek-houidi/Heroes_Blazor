using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MRPanelContext : DbContext
    {
        public MRPanelContext(DbContextOptions<MRPanelContext> options) : base(options) { }

        public DbSet<Person> Person { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //send data
            modelBuilder.Entity<Person>().HasData(new Person { Id = 1, Name = "Melek", Family = "Houidi" });
        }

    }
}
