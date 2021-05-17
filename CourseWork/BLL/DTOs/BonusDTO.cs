using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.BLL.DTOs
{
    public class BonusDTO
    {
        public int BonusDTOId { get; set; }
        public string Name { get; set; }
        public decimal Sum { get; set; }
        public string Text { get; set; }
        public int CampainDTOId { get; set; }
    }
}
