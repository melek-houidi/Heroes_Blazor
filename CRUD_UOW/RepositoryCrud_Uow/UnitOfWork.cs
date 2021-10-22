using RepositoryCrud_Uow.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryCrud_Uow.Core
{
    public class UnitOfWork : Interfaces.IUnitOfWork
    {
        private readonly ApplicationDbContext _DbContext;

        public ApplicationDbContext ApptioncationRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            this._DbContext = context;
            this.ApptioncationRepository = new ApplicationDbContext(this._DbContext);
        }
        public void Dispose()
        {
            this._DbContext.Dispose();
        }
        public async Task Commit()
        {
            await this._DbContext.SaveChangesAsync();
        }
    }
}
