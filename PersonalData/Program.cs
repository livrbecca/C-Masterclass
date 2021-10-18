using System;
using System.Collections.Generic;
namespace PersonalData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonalData> PD = new List<PersonalData>();

            string input = "";
           

            do
            {
                Console.WriteLine("x to stop");
                Console.WriteLine("ID?");
                string ID = Console.ReadLine();
                Console.WriteLine("Name?");
                string Name = Console.ReadLine();
                Console.WriteLine("Age?");
                int Age = Int32.Parse(Console.ReadLine());

                PersonalData newPerson = new PersonalData();
                newPerson.ID = ID;
                newPerson.Name = Name;
                newPerson.Age = Age;

                PD.Add(newPerson);


                
                //    ysno = Console.ReadLine();

            }
            while (input != "x");

            foreach (PersonalData entry in PD)
            {
                entry.ShowPersonalData();
            }
            Console.WriteLine("-----------------------------------------");

        }
    }
}
