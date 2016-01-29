using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
            static int g_menu()
            {
                Console.WriteLine("1 - is to create new Student");
                Console.WriteLine("2 - is to delete Student");
                Console.WriteLine("3 - is to find Student by GPA");
                Console.WriteLine("4 - is to show all Students");
                Console.WriteLine("0 - exit");
                string vybor = Console.ReadLine();
                int menu = int.Parse(vybor);
                return menu;
            }
        static void Main(string[] args)
        {
            while (true)
            {
                int menu = g_menu();

                if (menu == 1)
                {
                    Console.WriteLine("\n" + "Please Enter the name, surname and gpa");
                    string name = Console.ReadLine();
                    string surname = Console.ReadLine();
                    string s_gpa = Console.ReadLine();
                    int gpa = int.Parse(s_gpa);
                    Console.WriteLine(Student.create(name, surname, gpa));
                    
                }

                if (menu == 4)
                {

                    for (int i = 0; i < Student.k; i++ )
                    {
                        
                        Console.WriteLine(Student.store[i] + "\n");
                        
                    }
                }

                if (menu == 3)
                {
                    Console.WriteLine("Please Enter GPA");
                    string j = Console.ReadLine();
                    int set = int.Parse(j);
                    for (int i = 0; i < Student.k; i++)
                    {
                        if (set == Student.store[i].gpa)
                        {
                            Console.WriteLine(Student.store[i]);
                        }
                    }
                }

                if (menu == 0)
                {
                    //something to quit
                }
            }

          
            Console.ReadKey();

            
        }
    }
}
