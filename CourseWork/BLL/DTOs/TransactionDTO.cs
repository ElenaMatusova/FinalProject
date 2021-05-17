using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.BLL.DTOs
{
    public class TransactionDTO
    {
        public int TansactID { get; set; }
        public string Name { get; set; }
        public decimal Sum { get; set; }
        public int UserDTOId { get; set; }
        public int CampainDTOId { get; set; }
        public int BonusDTOId { get; set; }
    }
}
