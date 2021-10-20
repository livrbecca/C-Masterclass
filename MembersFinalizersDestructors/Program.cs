using System;

namespace MembersFinalizersDestructors
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Members mem1 = new Members();
            mem1.Introduce(true);

            // to see the destructor, we need to be out of scope, can see it using debug, gone too quikcly once terminal closes
        }
        
    }
}
