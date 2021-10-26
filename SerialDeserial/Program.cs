using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialDeserial
{
    class Program
    {
        static void Main(string[] args)
        {
            Serialization s = new Serialization();
            int hi = 5;
            s.Serialize(hi);
            Console.WriteLine("serializarion of data / string");
           // Console.WriteLine(jsonstring);
        }
    }
}

// dependency injection
// method queries
