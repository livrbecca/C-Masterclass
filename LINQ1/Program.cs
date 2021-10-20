using System;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Amazon amazonliv = new Amazon();
            //amazonliv.GetOrders();
            amazonliv.GetTotalProducts();

            Console.Read();
        }
    }
}
