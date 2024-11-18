using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jelewry_Store.Core.Entities
{
    public class ProductInOrder
    {
        public int CodeProductOrder { get; set; }
        public Product CodeProduct { get; set; }
        public Order CodeOrder { get; set; }
        public int InvoiceProduct { get; set; }
    }
}
