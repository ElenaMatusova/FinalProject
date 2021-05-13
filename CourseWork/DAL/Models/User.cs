using CourseWork.DAL.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.DAL.Models
{
    public class User : Entity
    {
        
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public bool IsBlocked { get; set; }
        public virtual ICollection<Campain> Campains { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
