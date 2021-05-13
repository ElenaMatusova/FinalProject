using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.DAL.Models
{
    public class Like : Entity
    {
        public bool LikeType { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public int? CommentId { get; set; }
        public virtual Comment Comment { get; set; }


    }
}
