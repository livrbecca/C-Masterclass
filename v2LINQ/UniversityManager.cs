using System.Collections.Generic;
using System.Linq;
using System;

namespace v2LINQ
{
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager() // constructor
        {
            universities = new List<University>(); // initialize the lists
            students = new List<Student>();

            universities.Add(new University { ID = 1, Name = "Lancaster" });
            universities.Add(new University { ID = 2, Name = "York" });

            students.Add(new Student { ID = 1, Name = "Carla", Gender = "female", Age = 18, UniID = 1 });
            students.Add(new Student { ID = 2, Name = "Toni", Gender = "male", Age = 21, UniID = 1 });
            students.Add(new Student { ID = 3, Name = "Letla", Gender = "female", Age = 18, UniID = 2 });
            students.Add(new Student { ID = 4, Name = "Bob", Gender = "transgender", Age = 22, UniID = 2 });
            students.Add(new Student { ID = 5, Name = "Linda", Gender = "female", Age = 28, UniID = 2 });
            students.Add(new Student { ID = 6, Name = "Patrick", Gender = "male", Age = 21, UniID = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = students.Where(stu => stu.Gender == "male");
            Console.WriteLine("male students: ");
            foreach (Student male in maleStudents)
            {
                male.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = students.Where(stu => stu.Gender == "female");
            Console.WriteLine("female students: ");
            foreach (Student f in femaleStudents)
            {
                f.Print();
            }
        }


        public void SortStudentsByAge()
        {
            var sortedStudents = students.OrderBy(s => s.Age);
            Console.WriteLine("SORTED students: ");
            foreach (Student sort in sortedStudents)
            {
                sort.Print();
            }
        }


        public void AllStudentsFromSelectedUni(int ID)
        {
            IEnumerable<Student> selected = from student in students join university in universities on student.UniID equals university.ID where university.ID == ID select student;
            Console.WriteLine("students from selected uni: ");
            foreach (Student student in selected)
            {
                student.Print();
            }
        }

        public void AllStudentsFromLancaster()
        {
            //IEnumerable<Student> lancs = students.Where(stu => stu.UniID is 1);

            IEnumerable<Student> lancs = from student in students join university in universities on student.UniID equals university.ID where university.Name == "Lancaster" select student;
            //students.GroupJoin(universities, student => student.UniID, uni => uni.Name == "Lancaster", (student, uni) => new { UniName = uni.Name, studentID = student.UniID });
            Console.WriteLine("students from lancaster: ");
            foreach (Student lanc in lancs)
            {
                lanc.Print();
            }
        }



    }
}
