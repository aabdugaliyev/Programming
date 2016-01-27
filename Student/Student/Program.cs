using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - is to create new Student");
            Console.WriteLine("2 - is to delete Student");
            Console.WriteLine("3 - is to find Student by GPA");
            Console.WriteLine("4 - is to show all Students");
            string vybor = Console.ReadLine();
            int menu = int.Parse(vybor);
            if (menu == 1)
            {
                create();
            }
            
            /*string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string s_gpa = Console.ReadLine();
            int gpa = int.Parse(s_gpa);
            Student st1 = new Student(name, surname, gpa);
            Console.WriteLine(st1);*/
            Console.ReadKey();
            
        }
    }
}
