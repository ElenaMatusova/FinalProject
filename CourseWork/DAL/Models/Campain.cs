using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.DAL.Models
{
    public enum Topic
    {
        Education, Environment, IT, Health
    }
    public class Campain : Entity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SumTotal { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }
        public string VideoUrl { get; set; }
        public Topic Topic { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Bonus> Bonuses { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<CampainTag> CampainTags { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<PicturesGalary> PicturesGalaries { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }

        

    }
}
