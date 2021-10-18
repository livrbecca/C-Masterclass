using System;

namespace TernaryChallenge
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int inputTemp = 0;
            string tempMessage;


            Console.WriteLine("enter current temp");
            string inputValue = Console.ReadLine();

            bool isInt = int.TryParse(inputValue, out inputTemp);

            if (isInt)
            {
                tempMessage = inputTemp <= 15 ? "cold" : (inputTemp >= 16 && inputTemp <= 28) ? "still cold but ok" : "its hot!";
                Console.WriteLine(tempMessage);
            } else
            {
                Console.WriteLine("enter a valid number");
            }
        }
    }
}
