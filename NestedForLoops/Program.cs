using System;

namespace NestedForLoops
{ // Nested for loops and 2D arrays
    class Program
    {
        // cant use non static inside static methods
        static int[,] matrix =
        {
             {1, 2, 3}, // left:00  02:right
              {4, 5, 6}, // left:11 11:right - center value
               {7, 8, 9}, // left:22 20:right
               // 02, 11, 10
        };

        static void Main(string[] args)
        {


            #region for loop diagonal left
            // getLength method, pass in the dimension
            // 0 = the rows
            for (int i = 0; i < matrix.GetLength(0); i++) // 0 , 1 ,2
            {


                // inner for loop for the columns
                // length of the second dimension so you can go through every col
                for (int j = 2; j < matrix.GetLength(0); j--) // [0, 0(j)], [0, 1(j)]
                {


                    //if (matrix[i, j] % 2 == 0) // only get even, change 0 to 1 for odd numbers
                    //{
                    //    Console.WriteLine(matrix[i, j]);
                    //}


                    // GETTING DIAGONAL VALUES
                    // going across left
                    //if (i == j)
                    //{
                    //    Console.WriteLine(matrix[i, j]);
                    //}

                   


                }
                #endregion


                #region using ONE for loop and left diagonals

                for (int a = 0; a < matrix.GetLength(0); a++)
                {
                   // Console.WriteLine(matrix[a,a]);
                }
                #endregion


                #region using one for loop and right diagonals

                for (int b = 0, c = 2; b < matrix.GetLength(0); b++, c--)
                {
                    Console.WriteLine(matrix[b,c]);
                }
                #endregion




            }
        }
    }
}
