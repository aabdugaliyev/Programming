using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace InOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[50];
            FileStream fs1 = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            string[] arr = sr.ReadLine().Split(' ');
            int max = -1;
            int min = 999999999;
            
            foreach (string s in arr)
            {
                int custom = int.Parse(s);
                if (custom > max)
                {
                    max = custom;
                }
                if (custom < min)
                {
                    min = custom;
                }
            }

            Console.WriteLine(min);
            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
