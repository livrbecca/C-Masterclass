using System;
using System.Collections.Generic;

namespace EventsAndDelegates
{
    class Program
    {


        public delegate bool FilterDelegate(Person p); // takes person object, will return bool


        static void Main(string[] args)
        {
            #region part 1
            #region Delegate explanation - type/variable that can hold a reference to a method
            // provide the onClick event as a delegate

            //private delegate void OnClickDelegateName();

            //    void SendButtonClick()
            //{
            //    // code
            //}

            // ButtonFromTheUI.OnClick = SendButtonClick; - NOT calling it, just storing its reference
            #endregion

            List<string> names = new List<string>() { "Abbie", "Babbie", "Callie", "Dallia" };
            // Delegates are used to pass methods as arguments to other methods. 
            // This ability to refer to a method as a parameter makes delegates ideal for defining callback methods
            names.RemoveAll(FilterNames); // input expected called a Predicate, type/name of delegate, takes an object of T(string here), returns bool

            foreach (string name in names)
            {
               // Console.WriteLine(name);
            }
            #endregion
            Person p1 = new Person("aa", 33);
            Person p2 = new Person("bb", 73);
            Person p3 = new Person("cc", 13);
            Person p4 = new Person("dd", 15);

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };


          //  DisplayPeople("no filter", people, null);

            DisplayPeople("kids", people, IsMinor);

            DisplayPeople("adult", people, IsAdult);


            DisplayPeople("senior", people, IsSenior);

        }
        // method that will display a list of people, and a filter as a delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (Person person in people)
            {
                if (filter(person))
                {
                    Console.WriteLine($"{person.Name}, {person.Age} years old.");
                }
            }
        }


        // filters

        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }
        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }
        static bool IsSenior(Person p)
        {
            return p.Age > 65;
        }
        #region part 1 method
        static bool FilterNames(string s)
        {
            return s.Contains("b");
        }
        #endregion

    }
}
