using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.BLL.DTOs
{
    public class NewsDTO
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string Picture { get; set; }
        public DateTime Date { get; set; }
        public int CampainDTOId { get; set; }
    }
}
