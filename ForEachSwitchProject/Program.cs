using System;

namespace InputCheckerProject
{
    class Program
    {

        static bool IsAllAlphabetic(string input) // static so it can be used in main
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c)) return false;
            }
            return true; // else return true
        }

        //static bool IsInt(int input) // static so it can be used in main
        //{
        //   if (input.)
        //}


        static void Main(string[] args)
        {
            bool valid = false;
            //string inputValueType;

            Console.WriteLine("enter a value");
            string inputValue = Console.ReadLine();

            Console.WriteLine("select the data type to validty the input you entered");
            Console.WriteLine("1: string");
            Console.WriteLine("2: int");
            Console.WriteLine("3: boolean");

            

           // Console.Write("Enter :");
           

            int answer = Convert.ToInt32(Console.ReadLine()); // turn answer into number

          

            switch (answer)
            {

                case 1:
                    Console.WriteLine("checking for a string....");
                    valid = IsAllAlphabetic(inputValue);
                    Console.WriteLine(valid? "verified string!" : "invalid. input not a string" );
                    break;
                case 2:
                    Console.WriteLine("checking for a integer....");
                    int returnVal = 0; // set type you're expecting - int
                    valid = int.TryParse(inputValue, out returnVal); // returns bool if success
                    Console.WriteLine(valid ? "verified integer!" : "invalid. input not an integer");
                    break;
                case 3:
                    Console.WriteLine("checking for a boolean....");
                    bool returnBool = false; // set type you're expecting - boolean
                    valid = bool.TryParse(inputValue, out returnBool); // returns bool if success
                    Console.WriteLine(valid ? "verified boolean!" : "invalid. input not a boolean");
                    break;
                default:
                    Console.WriteLine("not able to detect an input type. restart and try again");
                    break;

            }

        }
    }
}
