using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2LINQ
{
    public class University
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine($"university {Name} with ID {ID}");
        }

    }
}
