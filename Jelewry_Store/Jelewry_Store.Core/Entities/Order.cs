using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jelewry_Store.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderCode { get; set; }
        public int UserId { get; set; }
        public double TotalPrice { get; set; }
        public bool IsExsist { get; set; }
        public DateTime OrderDate { get; set; }
        public SpaicelDemand EspaicelDemand { get; set; }
        public int NumOfItemInOrder { get; set; }
        public SortsOfSending ESortOfSending { get; set; }
    }
}
