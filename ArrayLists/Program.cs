using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayLists // non generic
{
    class Program
    {


        #region EVEN LIST CHALLENGE / write a method that returns a list of even int numbers between 100 and 170 inclusive
        public static List<int> Solution()
        {

           
            List<int> EvenList = new List<int>();

            for (int i = 100; i < 171; i++)
            {
                if (i % 2 == 0)
                {
                    EvenList.Add(i);
                }
            }
            return EvenList;
        }
        #endregion

        static void Main(string[] args)
        {
       
            // declaring
            ArrayList myArrList = new ArrayList(); // undefined amount of objects
            ArrayList myArrList2 = new ArrayList(10); // saying this one should contain 10 objects

            myArrList.Add(1);
            myArrList.Add(7);
            myArrList.Add("hello");
            myArrList.Add(13.37);
            myArrList.Add(true);
            myArrList.Add(5000000);

            myArrList.Remove(13.37); // delete by SPECIFIC value, if it was there twice, would only remove the first one
            myArrList.RemoveAt(0); // remove by specific index
            int num = myArrList.Count;

            // if you wanted to add up all the numbers
            double sum = 0;
            foreach (object item in myArrList)
            {
                if (item is int)
                {
                    sum += Convert.ToDouble(item);
                    
                    //sum += Convert.ToInt32(item); have to convert bc item is an object still
                } else if (item is double)
                {
                    sum += (double)item; // using casting on the object
                } else if (item is string)
                {
                 //   Console.WriteLine(item);
                }
            }
           // Console.WriteLine(sum);
            //Console.ReadKey();

        }
    }
}
