using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.BLL.DTOs
{
    public class CommentDTO
    {
        public int CommentDTOId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int UserDTOId { get; set; }
        public int CampainDTOId { get; set; }

   
    }
}
