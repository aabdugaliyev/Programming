using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace InOutPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[50];
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fs2 = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader rs = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs2);
            int min = 99999999;
            int k = 0; 
            string[] arr = rs.ReadLine().Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = int.Parse(arr[i]);
                
            }
            /*foreach (string s in arr)
            {
                int custom = int.Parse(s);
            }*/

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < 999999; j++)
                {
                    if (array[i] % j == 0)
                    {
                        k++;
                    }
                }
                if (k == 2 && array[i]<min)
                {
                    min = array[i];
                }
                k = 0;
            }

            sw.WriteLine("\n" + "Minimum Prime is: " + min);
            sw.Close();
            rs.Close();
            Console.ReadKey();
        }
    }
}
