using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.DAL.Models
{
    public class Comment : Entity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public int? CampainId { get; set; }
        public virtual Campain Campain { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
    }
}
