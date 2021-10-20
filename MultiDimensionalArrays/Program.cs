using System;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        { 
            // multi dimensional arrays based on commma amount
            string[,] matrix; // adding the comma makes it 2D
            int[,,] matrix3; // 3D array


            // 2D array - initializing it
            int[,] array2D = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            Console.WriteLine(array2D[1,1]); // accessing the number 5


            // 3D array - initializing it
            string[,,] array3D = new string[,,]
            {//1D
                {//2D
                    {"3D - 000", "111" },
                     {"222", "333" },
                    {"hey", "how you doing" }
                },
                {
                      {"444", "555" },
                     { "676", "888" },
                        {"sorry you cant", "get through" }
                }
             };
            Console.WriteLine(array3D[1,1,1]); // gets 888
            Console.WriteLine(array3D[0, 2, 0]); // gets 888


            string[,] array2DString = new string[3, 2] // 3 rows, 2 entries per row - 3 {}'s with 2 elements inside
            {
                {"1", "2" },
                {"3", "4" },
                {"5", "6" },
            };

            array2DString[1, 1] = "chicken"; // changing 2d array values
            Console.WriteLine(array2DString[1,1]);


            // finding how many dimensionss an array has: Rank - returns a number
            Console.WriteLine(array3D.Rank);
        }
    }
}
