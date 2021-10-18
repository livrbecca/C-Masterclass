using System;

namespace Loops // not inc;uding foreach
{
    class Program
    {
        static void Main(string[] args)
        {

            // counted for loop
            for (int counter = 0; counter < 10; counter++)
            {

                if (counter == 3)
                {
                    Console.WriteLine("at 3 we stop!");
                    //break;
                    continue; // no longer stops at 3
                }
                Console.WriteLine(counter);
            }

            // only odd numbers
            for (int i = 1; i < 30; i += 2)
            {
                Console.WriteLine(i);
            }

            // do while loop
            //int counter = 0;
            string wholeText = "";
            int lengthOfText = 0;
            do
            {
                Console.WriteLine("enter a name");
                string inputName = Console.ReadLine();
                int nameLength = inputName.Length;
                lengthOfText += nameLength;
                wholeText += inputName;

                // counter++; // if you forget to increment, you get an infinite loop
            } while(lengthOfText < 20);
            Console.WriteLine("thanks. - " + wholeText);

            // the difference: Executes the code first and then checka
        }
    }
}
