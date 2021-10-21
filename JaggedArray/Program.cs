using System;

namespace JaggedArray
{

    // Difference between Jagged Arrays and Multidimensional arrays
    // A jagged array is an array of arrays. Each array is not guaranteed to be of the same size.
    // A multidimensional array is more of a cohesive grouping, like a box, table, etc., where there are no irregular lengths


    class Program
    {
        static void Main(string[] args)
        {
            // how to decalre a jagged array -
            // store an arrray (multiple or 1) within an array  'array section'
            // created with 2 [], 
            int[][] jaggedArr = new int[3][]; // want 3 arrays inside in

            // Initialize a jagged array
            jaggedArr[0] = new int[5];
            jaggedArr[1] = new int[1]; // how many values / entries that array will have
            jaggedArr[2] = new int[3];

            jaggedArr[0] = new int[] { 2, 4, 6, 8, 10 }; 
            jaggedArr[1] = new int[] { 5 };
            jaggedArr[2] = new int[] { 8, 8, 9 };

            // Alternative way, init and declare values in one
            int[][] jaggedArr2 = new int[][]
            {
                new int[]{10, 20, 30, 40, 50 },
                new int[]{3, 6, 9, 12}
            };

           // Console.WriteLine(jaggedArr2[0, 4]); // to access 50 - WRONG
           Console.WriteLine(jaggedArr2[0][4]); // correct, seperate []'s unlike multidimensional arrays


            // printing all values of jagged arr
            for (int i = 0; i < jaggedArr2.Length; i++)
            {
                for (int j = 0; j < jaggedArr2[i].Length; j++) // is is the first, then second etc, array
                {
                    Console.WriteLine(jaggedArr2[i][j]); // j goes through the first array's elements, then the next ones
                }
            }

        }
    }
}
