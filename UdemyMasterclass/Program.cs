using System;

namespace UdemyMasterclass
{
    class Program 
    {
        static void Main(string[] args)
        {
            // SWITCH STATEMENTS
            int age = 3;
            switch (age)
            {
                case 17:
                    Console.WriteLine("too young to party!");
                    break; // break to break out of the switch statement
                case 21:
                    Console.WriteLine("party!");
                    break;
                case 23:
                    Console.WriteLine("can you even still be bothered");
                    break;
                default:
                    Console.WriteLine("how old are you then?");
                    break;
            }




            // TERNARY OPERATOR
            int temp = 90;
            string stateOfMatter;

            stateOfMatter = temp > 100 ? "gas" : (temp < 0 ? "solid" : "liquid"); // if not gas, move to the next t.operation
            Console.WriteLine($"state of mattter is {stateOfMatter}");




            // LOOPS


            Console.Read();

        }
    }
}
