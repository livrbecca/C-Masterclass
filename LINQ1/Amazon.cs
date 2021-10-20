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

        public Amazon() // constructor?
        {

            Console.WriteLine("Constructor check...");

            // object initialization
            Orders = new List<OrderMaster>();
            OrderDetails = new List<OrderDetail>();

            #region orders
            Orders.Add(new OrderMaster()
            {
                CustomerName = "liv",
                OrderId = 1,
                OrderNo = "A01",
                TotalAmount = 1000
            });

            Orders.Add(new OrderMaster()
            {
                CustomerName = "liv",
                OrderId = 2,
                OrderNo = "A02",
                TotalAmount = 500
            });

            Orders.Add(new OrderMaster()
            {
                CustomerName = "p3",
                OrderId = 3,
                OrderNo = "A03",
                TotalAmount = 150
            });

            Orders.Add(new OrderMaster()
            {
                CustomerName = "p3",
                OrderId = 4,
                OrderNo = "A031",
                TotalAmount = 50
            });

            Orders.Add(new OrderMaster()
            {
                CustomerName = "p4",
                OrderId = 5,
                OrderNo = "A05",
                TotalAmount = 50
            });
            #endregion

            #region order details
            OrderDetails.Add(new OrderDetail()
            {
                OrderID = 1,
                OrderNo = "A01",
                ProductCode = "xx",
                QT = 2,
                Price = 1000
            });

            OrderDetails.Add(new OrderDetail()
            {
                OrderID = 2,
                OrderNo = "A02",
                ProductCode = "xx",
                QT = 1,
                Price = 500
            }) ;

            OrderDetails.Add(new OrderDetail()
            {
                OrderID = 3,
                OrderNo = "A03",
                ProductCode = "aaa",
                QT = 3,
                Price = 150
            });
            OrderDetails.Add(new OrderDetail()
            {
                OrderID = 4,
                OrderNo = "A03",
                ProductCode = "aaa",
                QT = 1,
                Price = 50
            });

            OrderDetails.Add(new OrderDetail()
            {
                OrderID = 5,
                OrderNo = "A05",
                ProductCode = "bb",
                QT = 1,
                Price = 50
            });

           
            #endregion
        }

        public void GetOrders() // getting orders based on customer if
        {
          //  var orders = from o in Orders where o.CustomerName == "p3" select o;
            var ordersDeets = (from od in OrderDetails join o in Orders on od.OrderID equals o.OrderId where o.CustomerName == "liv" select od).ToList();
            foreach(OrderDetail od in ordersDeets)
            {
                Console.WriteLine($"order number is {od.OrderNo}\nproduct code is {od.ProductCode}\nQT is {od.QT}\nprice is {od.Price}");
            }
        }

        public void GetTotalProducts()
        {
            // fetch total amount for a customer

            var products = (from od in OrderDetails group od by od.ProductCode into tbl
                                 select new { PCode = tbl.Key, Count = tbl.Sum(s => s.QT), Amt = tbl.Sum(s => s.Price * s.QT)});

            // anon type so cant dircetly loop it


            foreach (var od in products)
            {
                Console.WriteLine($"product code: {od.PCode}\ntotal price: {od.Amt}\nquantity: {od.Count}");
            }
        }
    }
}
