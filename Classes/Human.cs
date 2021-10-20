using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Human
    {
        // public string firstName; - this is protected, can't assign in created liv instance
        private string firstName; // constructor code still works even if changed to private
        private string lastName;
        private string eyeColor;
        private int Age;

        // CONSTRUCTORS - can create limitless
        // non parameterized constructor, etc default constructor
        public Human()
        {
            Console.WriteLine("Deault. Constructor called. Object created."); // works
        }


        public Human(string firstName, string lastName, string eyeColor, int Age) // local variables referred to with 'this', example of parametrized constructor
        {
            this.firstName = firstName;  
            this.lastName = lastName;
            this.Age = Age;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, string eyeColor) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, int Age) 
        {
            this.firstName = firstName;
            this.Age = Age;
        }

        public Human(string firstName) 
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }




        public void Intro() // overlaps with existing and cuts them down if eligible 
        {
            if (firstName != null && lastName != null && eyeColor != null && Age > 0){
                Console.WriteLine($"I am {firstName} {lastName}, I have {eyeColor} eyes and I am {Age}");
            } 
            else if (firstName != null && lastName != null && eyeColor != null)
            {
                Console.WriteLine($"I am {firstName} {lastName}, I have {eyeColor} eyes. You don't need to know my age");
            } else if (firstName != null && Age > 0)
            {
                Console.WriteLine($"I am {firstName} and I'm {Age}!");
            } else if (firstName != null)
            {
                Console.WriteLine($"I'm {firstName} :)");
            } else if (firstName != null && lastName != null)
            {
                Console.WriteLine($"I'm {firstName} {lastName}"); // doesn't work
            }

        }

    }
}
