using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.BLL.DTOs
{
    public class CampainDTO
    {
        public int CampainDTOId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SumTotal { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }
        public string VideoUrl { get; set; }
        public string Topic { get; set; }
        public int UserDTOId { get; set; }
        public IList<CampainTagDTO> Tags {get; set;}
    }
}
