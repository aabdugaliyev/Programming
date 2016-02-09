using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNum
{
    class Program
    {
        static void Main(string[] args)
        {
            complex a = complex.change(Console.ReadLine());
            complex b = complex.change(Console.ReadLine());
           // complex c = a + b;
            complex c = a * b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
