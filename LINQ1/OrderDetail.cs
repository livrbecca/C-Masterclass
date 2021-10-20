using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    public class OrderDetail
    {
        public int OrderID { get; set; }

        public string OrderNo { get; set; }
        public string ProductCode { get; set; }
        public int QT { get; set; }
        public decimal Price { get; set; }
    }
}
