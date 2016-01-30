using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes = new int[50];
            int[] prime = new int[50];
            int k = 0;
            int p = 0;
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < s.Length; i++)
            {
                prime[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j < 99999; j++)
                {
                    if (prime[i] % j == 0)
                    {
                        p++;
                    }
                }
                if (p == 2)
                {
                    primes[k] = prime[i];
                    k++;
                }
                p = 0;
            }
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(primes[i]);
            }

                Console.ReadKey();

        }
    }
}
