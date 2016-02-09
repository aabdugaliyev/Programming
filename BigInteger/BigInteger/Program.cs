using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Bint b1 = new Bint(s1);
            Bint b2 = new Bint(s2);
            Bint b3 = b1 + b2;
            for (int i = 0; i < Bint.b.Length; i++)
            {
                Console.Write(Bint.b.num[i])
            }
                Console.ReadKey();


        }
    }
}
