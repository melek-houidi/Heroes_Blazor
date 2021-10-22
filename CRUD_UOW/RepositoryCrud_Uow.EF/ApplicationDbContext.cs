using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryCrud_Uow.EF
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options):base(options)
        {

        }

        public ApplicationDbContext(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public object Application { get; set; }
        public ApplicationDbContext DbContext { get; }
    }
}
