using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int prov=0;
            int[] a = { 5, 4, 7, 2 };
            //List<int> a = new List<int>();
            for (int i = 0; i < a.Length -1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    prov = a[i];
                    a[i] = a[i + 1];
                    a[i] = prov;
                    Console.ReadKey();
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
