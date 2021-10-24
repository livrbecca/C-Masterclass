using System;
using System.Collections;
using System.Collections.Generic;


namespace Collections // classes that we can use to store a collection of objects, can be of multiple types, not fixed in size
{ // different to arrays - collections used to store, manage and manipulate groups of object smore efficiently 

    // NON GENERIC
    // Can store any type of object
    // located in system.collections namespace




    // GENERIC 
        // Limited to one type of object
        // system.collections.generic namespace



    class Program
    {
        static void Main(string[] args)
        {

            // non generic 
            int num1 = 5; float num2 = 6.8f; string name = "liv";
            ArrayList NonGenCollection = new ArrayList(); // initialize it
            NonGenCollection.Add(num1);
            NonGenCollection.Add(num2);
            NonGenCollection.Add(name); // added int, float, string - diff types = non generic 

            // iterating throug them: has to be as an object due to the diff types
            foreach (object item in NonGenCollection)
            {
                Console.WriteLine(item);
            }


            // generic
            string a1 = "cat";
            string a2 = "dog";
            string a3 = "lizard";
            // can only hold one type of objetc, and we specify that when defining the list: List<string>
            List<string> myGenericCollection = new List<string>(); // initialize it
            myGenericCollection.Add(a1);
            myGenericCollection.Add(a2);
            myGenericCollection.Add(a3);

            foreach (string animal in myGenericCollection)
            {
                Console.WriteLine(animal);
            }

        }

        
        
        
    }
}
