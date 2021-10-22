using RepositoryCrud_Uow.Core.Interfaces;
using RepositoryCrud_Uow.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryCrud_Uow.Core
{
    class ApptioncationRepository : GenericRepository<ApplicationId>, IApplicationRepository
    {
        private readonly ApplicationDbContext _DbContext;
        public ApptioncationRepository(ApplicationDbContext context) : base(context)
        {
            this._DbContext = context;
        }
    }
}
