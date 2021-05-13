using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.DAL.Models
{
    public class Vote : Entity
    {
        public int VoteNumber { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public int? CampainId { get; set; }
        public virtual Campain Campain { get; set; }

    }
}
