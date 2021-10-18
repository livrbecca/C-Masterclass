using System;

namespace AverageScoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0"; // starting point
            int count = 0; // counter, 0 inputs to start with
            int total = 0; // 
            int currentNumber = 0; // starting point

            while (input != "-1") // if they didnt enter -1, do the following
            {
                Console.WriteLine($"last score was {currentNumber}"); // 0 at first
                Console.WriteLine("enter the next score");
                Console.WriteLine($"current amount of entries = {count}"); // 0 at first, will increment on line 41 next iteration
                Console.WriteLine("-1 to end application");

                input = Console.ReadLine(); // entered number
                Console.WriteLine($"-----------------------------------");
                if (input.Equals("-1")) // end and show average
                {
                    Console.WriteLine($"-----------------------------------");
                    Console.WriteLine($"calculating average...");
                    double average = (double)total / (double)count;
                    Console.WriteLine(average);
                }
                    if (int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21) // is it a number, is it between 1 and 20
                {
                    total += currentNumber; // adding up scores if theyre valid: ect a numbr between 1 and 20
                }
                    else // input couldnt be parsed, lower than 0 or higher than 21
                {
                    if (!(input.Equals("-1"))) // if not -1 and not between 1-20
                    {
                        Console.WriteLine($"INVALID: enter value between 1-20");
                    }
                    continue;
                }
                count++;
            }

            Console.WriteLine("");
        }
    }
}
