using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.DAL.Models
{
    public class News: Entity
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string Picture { get; set; }
        public DateTime Date { get; set; }
        public int CampainId { get; set; }
        public virtual Campain Campain { get; set; }

    }
}
