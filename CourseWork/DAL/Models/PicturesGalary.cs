using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.DAL.Models
{
    public class PicturesGalary : Entity
    {
        public string PictureUrl { get; set; }
        public int? CampainId { get; set; }
        public virtual Campain Campain { get; set; }
    }
}
