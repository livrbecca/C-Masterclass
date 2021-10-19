using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    public class Amazon
    {
        private List<OrderMaster> Orders;
        private List<OrderDetail> OrderDetails;

        public Amazon()
        {
            // object init
            Orders.Add(new OrderMaster()
            {
                CustomerName = "p1",
                OrderId = 1,
                OrderNo = "A01",
                TotalAmount = 140
            });

            Orders.Add(new OrderMaster()
            {
                CustomerName = "p2",
                OrderId = 1,
                OrderNo = "A02",
                TotalAmount = 150
            });

            Orders.Add(new OrderMaster()
            {
                CustomerName = "p3",
                OrderId = 3,
                OrderNo = "A03",
                TotalAmount = 100
            });

            Orders.Add(new OrderMaster()
            {
                CustomerName = "p4",
                OrderId = 4,
                OrderNo = "A04",
                TotalAmount = 50
            }); ;

            OrderDetails.Add(new OrderDetail()
            {
                OrderID = 1,
                OrderNo = "A01",
                ProductCode = "x",
                QT = 2,
                Price = 70
            });
        }
    }
}
