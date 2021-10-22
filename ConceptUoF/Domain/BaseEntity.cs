using GenericRepository;
using GenericRepository.Interdace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class BaseEntity: IEntity
    {
        public BaseEntity ()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }

}
