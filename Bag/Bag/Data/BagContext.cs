using Bag.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bag.Data
{
    public class BagContext:DbContext
    {
        public BagContext(DbContextOptions options):base(options)
        {

        }
        public virtual DbSet<Unit> Units { get; set; }
    }
}
