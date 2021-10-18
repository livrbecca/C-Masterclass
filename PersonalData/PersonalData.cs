using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalData
{
    public class PersonalData
    {
        public string ID { get; set; }
        public string Name { get; set; }
 
        public int Age { get; set; }

        public void ShowPersonalData()
        {
            Console.WriteLine($"data entry: {ID}, {Name}, {Age}");
        }

        public void RemovePersonalData()
        {
            Console.WriteLine($"data entry: {ID}, {Name}, {Age}");
        }
    }
}
