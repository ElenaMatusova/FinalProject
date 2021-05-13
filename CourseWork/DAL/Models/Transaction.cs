using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.DAL.Models
{
    public class Transaction : Entity
    {
        public string Name { get; set; }
        public decimal Sum { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public int? CampainId { get; set; }
        public virtual Campain Campain { get; set; }
        public int? BonusId { get; set; }
        public virtual Bonus Bonus { get; set; }
    }
}
