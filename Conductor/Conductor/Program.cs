using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Conductor
{
    class Program
    {
        static void Main(string[] args)
        {
            //FyleSystemInfo
            int x = 0;
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Alisher\Desktop\Trash\test");
            FileSystemInfo[] files = dir.GetFileSystemInfos();
            while(true)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    if (x == )
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    if (x == i)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(files[i].Name);
                }
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                {
                    if (x > 0)
                    {
                        x--;
                    }
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    if (x < files.Length - 1)
                    {
                        x++;
                    }
                }
                Console.Clear();
            }
            
        }
    }
}
