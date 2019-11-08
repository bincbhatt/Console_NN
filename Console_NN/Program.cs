using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_NN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student List : ");
            List<Student> List = new List<Student>();
            List.Add(new Student { StudentID = 1, StudentName = "Bipin", Age = 31 });
            List.Add(new Student { StudentID = 2, StudentName = "Rohit", Age = 32 });
            List.Add(new Student { StudentID = 3, StudentName = "Virat", Age = 27 });
            List.Add(new Student { StudentID = 4, StudentName = "Suresh", Age = 34 });
            List.Add(new Student { StudentID = 5, StudentName = "Rishabh", Age = 21 });
            List.Add(new Student { StudentID = 6, StudentName = "Sachin", Age = 40 });
            List.Add(new Student { StudentID = 7, StudentName = "Bipin Bhatt", Age = 32 });
            List.Add(new Student { StudentID = 8, StudentName = "Ravi", Age = 32 });
            List.Add(new Student { StudentID = 9, StudentName = "Ankul", Age = 32 });
            List.Add(new Student { StudentID = 10, StudentName = "Ramesh", Age = 35 });
            List.Add(new Student { StudentID = 11, StudentName = "Laxman", Age = 45 });

            foreach (Student obj in List)
                Console.WriteLine(" Student ID :" + obj.StudentID + " Student Name :" + obj.StudentName + " Student Age :" + obj.Age);

            string value = string.Empty;
            do
            {
                Console.Write("Search Name : ");
                string str = Console.ReadLine();

                var list = from x in List where x.StudentName.ToLower().Contains(str.ToLower()) select x;

                foreach (Student obj in list)
                    Console.WriteLine(" Student ID :" + obj.StudentID + " Student Name :" + obj.StudentName + " Student Age :" + obj.Age);

                Console.Write("Do you want to continue : ");
                value = Console.ReadLine();
            }while (value.ToUpper() == "YES" || value.ToUpper() == "Y");





            // Console.ReadLine();
        }


    }
    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }

    }

}
