using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.DAL.Models
{
    public abstract class Entity
    {
        public virtual int Id { get; protected set; }
    }
}
