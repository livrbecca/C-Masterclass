using System;
using System.Collections.Generic;
using System.Text;
// create delegate to filter people based on age, filter delegate will take a person as a parameter and return bool is age is met
namespace EventsAndDelegates
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
