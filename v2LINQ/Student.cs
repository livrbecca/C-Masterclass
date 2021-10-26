using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2LINQ
{
     class Student
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        // foreign key
        public int UniID { get; set; }

        public void Print()
        {
            Console.WriteLine($"Student {Name}, with ID {ID}, age {Age}, ({Gender}) from university with ID {UniID}");
        }
    }
}
