using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Interdace
{
    public interface IUnitOfWork<T>:IDisposable where T: class,IEntity
    {
        IRepository<T> Repository { get; }
        Task Commit();
    }
}
