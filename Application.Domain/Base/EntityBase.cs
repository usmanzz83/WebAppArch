using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain.Base
{
    public abstract class EntityBase
    {

    }

    public abstract class Entity : EntityBase, IEntity
    {
        public virtual int Id { get; set; }
    }
}
