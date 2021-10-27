using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {

           Hashtable stuTable = new Hashtable();
            

           Student[] studentsArr = new Student[6];
           studentsArr[0] = new Student(1, "Maggie", 75);
           studentsArr[1] = new Student(1, "Maria", 55);
           studentsArr[2] = new Student(4, "Jason", 95);
           studentsArr[3] = new Student(3, "Clara", 51);
           studentsArr[4] = new Student(4, "Steve", 30);
           studentsArr[5] = new Student(1, "Harlow", 45);

            AddToHash(studentsArr, stuTable);

            Hashtable studentsTable = new Hashtable();

            #region student data
            Student s1 = new Student(1, "Maria", 55);
            Student s2 = new Student(2, "Jason", 95);
            Student s3 = new Student(3, "Clara", 51);
            Student s4 = new Student(4, "Steve", 30);
            #endregion


            #region how to add to hashtable, in key:value pairs
            studentsTable.Add(s1.Id, s1); // added in key:value pairs, ID:Maria
            studentsTable.Add(s2.Id, s2);
            studentsTable.Add(s3.Id, s3);
            studentsTable.Add(s4.Id, s4);
            #endregion 



            #region how to retrieve entries
            Student storedStudent1 = (Student)studentsTable[s1.Id]; // [1] is the key / ID
                                                                    // without casting into (Student), we were just passing an object, but Student only takes type Student
            #endregion

            #region stuct: dictionary entry
            // whenever we add a new entry to our hashtable, a dictionary entry object will be created for us and inserted into the hashtable
            // hastable: collection of dictionary entries

            foreach (DictionaryEntry entry in studentsTable)
            {
                int ID = (int)entry.Key;

                Student temp = (Student)entry.Value; // object, casting into type Student

               // Console.WriteLine($"{ID} : {temp.Name}({temp.GPA})");
            }


            // simplified withour casting

            foreach (Student student in studentsTable.Values)
            {
            
               // Console.WriteLine($"student id => {student.Id}\nstudent name => {student.Name}\nstudent GPA => {student.GPA}\n__________________________________");
            }
            #endregion
        }

        public static void AddToHash(Student[] stu, Hashtable table)
        {
            foreach (Student student in stu)
            {

                if (!table.ContainsKey(student.Id))
                {
                    
                    
                    Console.WriteLine($"student added:\nstudent id => {student.Id}\nstudent name => {student.Name}\nstudent GPA => {student.GPA}\n__________________________________");
                    table.Add(student.Id, student);
                } else
                {
                    Console.WriteLine($"ID {student.Id} - student already exists");
                }

               
            }
        }


    }

  

}

