using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake.Models
{
    class Wall : Drawer
    {
        public Wall()
        {
            color = ConsoleColor.Red;
            sign = 'X';
        }

        public void LoadLevel(int level)
        {
            string fileName = string.Format("level_{0}.txt", level);
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            body.Clear();
            string[] rows = sr.ReadToEnd().Split('\n');

            int r1 = rows.Length;

            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < rows[i].Length; j++)
                {
                    if (rows[i][j] == 'X')
                    {
                        body.Add(new Point(j, i));
                    }
                }
            }
        }
    }
}
