using System;

namespace ParamsKeyWord // freedom of passing unlimited arguemnts to a method
{
    class Program
    {
        static void Main(string[] args)
        {


            // real world example 
            Math.Min(1, 2); // Math class has a Min method and it allows you to pass in two values and return the lowest

            // alternative method to Math.Min : pass in more than two values
            int smallest = FindMinFromMultiple(5, 6, 7, 8, 9, 10, 11, 23);
            Console.WriteLine(smallest);


           // ParamsMethod("dfds", "sdsf", "esefs", "fsdss", "dgdfgdfdfg", "dfasdf"); // can pass as many as you want, or none at all and the code will not crash
            // ParamsMethod2(2, 45.42, 9492, "jelloooo", "fke"); //
        }

        // using params keyword to make a method that allows the user to insert as many parameters as they want


        public static int FindMinFromMultiple(params int[] numbers)
        {
            int lowest = int.MaxValue;

            foreach (int num in numbers)
            {
                if (num < lowest)
                    lowest = num;
              
            }
            return lowest;
            
        }


        public static void ParamsMethod(params string[] sentence) 
        {
            for (int i = 0; i < sentence.Length; i++) // for loop will run as many times as we pass parameters to the method
            {
                Console.WriteLine(sentence[i] + " ");
              
            }
        }

        public static void ParamsMethod2 (params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
