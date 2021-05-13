using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.DAL.Models
{
    public class Bonus : Entity
    {
        public string Name { get; set; }
        public decimal Sum { get; set; }
        public string Text { get; set; }
        public int? CampainId { get; set; }
        public virtual Campain Campain { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }

    }
}
