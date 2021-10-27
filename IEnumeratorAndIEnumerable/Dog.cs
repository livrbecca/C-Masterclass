using System;

namespace IEnumeratorAndIEnumerable
{
    class Dog
    {
        public string Name { get; set; }
        public bool IsNaughty { get; set; }
        public Dog(string name, bool isnaughty)
        {
            this.Name = name;
            this.IsNaughty = isnaughty;
        }

        public void GiveTreat(int numberOfTreats)
        {
            Console.WriteLine("good boy,  {0} treats for {1}", numberOfTreats, Name);
        }
    }
}
