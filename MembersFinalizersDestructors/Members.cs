using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MembersFinalizersDestructors
{
    class Members
    {
        // MEMBER FIELDS
        // memeber: private fields
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public fields 
        public int age;

        // property that exposes jobTitle safely
        public string JobTitle { get { return jobTitle; } set { jobTitle = value; } }


        // public member Method - can be called from other classes
        public void Introduce(bool isFriend)
        {
            if (isFriend)
            {
                TellPrivateInfo();
            } else
            {
                Console.WriteLine($"hi my name is {memberName}, im a {jobTitle} and {age}");
            }
           
        }

        private void TellPrivateInfo()
        {
            Console.WriteLine($"my salary is {salary}");
        }

        // CONSTRUCTOR - also a member
        public Members() { 
            age = 335;
            memberName = "kim";
            salary = 900000;
            jobTitle = "web dev";
            Console.WriteLine("object created");
        }


        // member: finalizer or destructor
        ~Members()
        {
            // destructor, can be fined within classes, and classes can only have one destructor
            // cannot be inherited, overloaded or called
            // only available for this specific class
            // called when this object is out of scope - good for cleanup statements

            Console.WriteLine("deconstructor of Members object");

            //


        }
    
    }

}
