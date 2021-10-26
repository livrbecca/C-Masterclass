using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            #region odd numbers pratice
            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //OddNumbers(numbers);
            //Console.ReadKey();
            #endregion

            UniversityManager Tim = new UniversityManager();
            Tim.MaleStudents();
            Tim.FemaleStudents();
            Tim.SortStudentsByAge();
            Tim.AllStudentsFromLancaster();
            string input = Console.ReadLine();
            int inputAsInt = Convert.ToInt32(input);
            Tim.AllStudentsFromSelectedUni(inputAsInt);
            Console.ReadKey();


        }

        


          

        #region Odd numbers practice

        //static void OddNumbers(int[] numbers)
        //{
        //    Console.WriteLine("odd numbers: ");

        //    IEnumerable<int> oddNumbers = numbers.Where(num => num % 2 != 0).OrderBy(n => n);

        //    foreach (int i in oddNumbers)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        #endregion
    }




    
}
