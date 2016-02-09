using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    class Game
    {
        public static Food food = new Food();
        public static Snake snake = new Snake();
        public static Wall wall = new Wall();

        public Game()
        {
            Init();
            Play();
        }

        public void Play()
        {
            while (true)
            {
                Draw();
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                {
                    snake.Move(0, -1);
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    snake.Move(0, 1); 
                }
                if (button.Key == ConsoleKey.LeftArrow)
                {
                    snake.Move(-1, 0);
                }
                if (button.Key == ConsoleKey.RightArrow) 
                {
                    snake.Move(1, 0);
                }
                if (!Game.food.Check())
                {
                    Game.food.SetNewPosition();
                }

            }
            

        }


        public void Draw()
        {
            Console.Clear();
            snake.Draw();
            food.Draw();
            wall.Draw();
            
        }

        public void Init()
        {
            snake.body.Add(new Point(10, 10));
            food.SetNewPosition();
            wall.LoadLevel(1);
        }
        


    }
}
