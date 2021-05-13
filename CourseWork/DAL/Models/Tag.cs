using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.DAL.Models
{
    public class Tag : Entity
    {
        public string TagName { get; set; }
        public virtual ICollection<CampainTag> CampainTags { get; set; }

    }
}
