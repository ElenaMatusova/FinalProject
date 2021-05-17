using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.BLL.DTOs
{
    public class LikeDTO
    {
        public int LikeDTOId { get; set; }
        public bool LikeType { get; set; }
        public int UserDTOId { get; set; }
        public int CommentDTOId { get; set; }
    }
}
