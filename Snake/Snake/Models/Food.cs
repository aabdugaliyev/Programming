using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake.Models
{
    class Food: Drawer
    {
        public Food()
        {
            color = ConsoleColor.Green;
            sign = '♦';
        }

        public void SetNewPosition()
        {
            int x = new Random().Next() % 20;
            int y = new Random().Next() % 20;
            if (body.Count == 0)
            {
                body.Add(new Point(x, y));
            }
            else
            {
                body[0].x = x;
                body[0].y = y;
            }


           
        }

        public bool Check()
        {
            return true;
            foreach (Point p in Game.wall.body)
            {
                if (body[0].x == p.x && body[0].y == p.y)
                {
                    return false;
                    
                }
                else
                {
                    return true;
                }
            }
        }

    }
}
