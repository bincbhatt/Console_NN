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
            string[] Names = { "ABC", "BCD", "CDEA", "DEF", "EFG" };
            string value = "Yes";
            while (value.ToUpper() == "YES")
            {
                Console.WriteLine("Please enter one character");
                string str = Console.ReadLine();
                var list = from x in Names where x.Contains(str) select x;
                foreach (string x in list)
                    Console.WriteLine(x);

                Console.WriteLine("Do you want to continue : Yes or No !");
                value = Console.ReadLine();
            }





            // Console.ReadLine();
        }


    }
    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }

        public Student()
        {
            StudentID = 0;
        }
    }

}
