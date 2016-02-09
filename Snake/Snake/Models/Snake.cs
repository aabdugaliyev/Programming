using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    class Snake : Drawer
    {
        public Snake()
            
        {
            sign = 'O';
            color = ConsoleColor.Blue;
        }
        public void Move(int dx, int dy)
        {
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
                //body
            }
            body[0].x += dx;
            body[0].y += dy;

            if (body[0].x == Game.food.body[0].x &&
                body[0].y == Game.food.body[0].y)
            {
                body.Add(new Point(0, 0));
                Game.food.SetNewPosition();
            }


           
        }

    }
}
