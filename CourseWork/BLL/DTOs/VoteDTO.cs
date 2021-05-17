using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.BLL.DTOs
{
    public class VoteDTO
    {
        public int VoteDTOId { get; set; }
        public double VoteRate { get; set; }
        public int UserDTOId { get; set; }
        public int CampainDTOId { get; set; }
    }
}
