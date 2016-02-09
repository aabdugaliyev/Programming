using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Conduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Alisher\Desktop\Trash\test");
            List<FileSystemInfo> files = new List<FileSystemInfo>();
            files.AddRange(dir.GetFileSystemInfos());
            while (true)
            {
                for (int i = 0; i < files.Count; i++)
                {
                    if (index == i)
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
                    if (index > 0)
                    {
                        index--;
                    }
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    if (index < files.Count - 1)
                    {
                        index++;
                    }
                }
                if (button.Key == ConsoleKey.Enter)
                {
                    if (files[index].GetType() == typeof(DirectoryInfo))
                    {
                        dir = new DirectoryInfo(files[index].FullName);
                        files.Clear();
                        files.AddRange(dir.GetFileSystemInfos());
                    }
                }
                if (button.Key == ConsoleKey.Escape)
                {
                    
                    dir = new DirectoryInfo(@"C:\Users\Alisher\Desktop\Trash\test");
                    Console.Clear();
                    files.AddRange(dir.GetFileSystemInfos());
                }
                Console.Clear();
                
            }
        }
    }
}
