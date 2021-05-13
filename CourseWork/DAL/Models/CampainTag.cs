using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.DAL.Models
{
    public class CampainTag
    {
        public int CampainId { get; set; }
        public Campain Campain { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        
    }
}
