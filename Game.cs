using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class Game
    {
        static System.ConsoleKey currentDirection = ConsoleKey.RightArrow;

        static void Main(string[] args)
        {
            Feld feld = new Feld();
            Snake snek = new Snake();
            Food food = new Food();

            bool isAlive = true;
            while (isAlive)
            {
                Task.Delay(200).Wait();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey(true);
                    if (userInput.Key == ConsoleKey.LeftArrow && currentDirection != ConsoleKey.RightArrow)
                    {
                        currentDirection = ConsoleKey.LeftArrow;
                    }
                    if (userInput.Key == ConsoleKey.RightArrow && currentDirection != ConsoleKey.LeftArrow)
                    {
                        currentDirection = ConsoleKey.RightArrow;
                    }
                    if (userInput.Key == ConsoleKey.UpArrow && currentDirection != ConsoleKey.DownArrow)
                    {
                        currentDirection = ConsoleKey.UpArrow;
                    }
                    if (userInput.Key == ConsoleKey.DownArrow && currentDirection != ConsoleKey.UpArrow)
                    {
                        currentDirection = ConsoleKey.DownArrow;
                    }
                }

                snek.Move(Direction(currentDirection));
                snek.Draw();
                food.Spawn();
            }

            Console.ReadLine();
        }

        static Position Direction(System.ConsoleKey dir) {
            Position MOV_DOWN = new Position(0, 1);
            Position MOV_RIGHT = new Position(1, 0);
            Position MOV_UP = new Position(0, -1);
            Position MOV_LEFT = new Position(-1, 0);

            switch (dir)
            {
                case ConsoleKey.UpArrow:
                    return MOV_UP;
                case ConsoleKey.RightArrow:
                    return MOV_RIGHT;
                case ConsoleKey.DownArrow:
                    return MOV_DOWN;
                case ConsoleKey.LeftArrow:
                    return MOV_LEFT;
                default:
                    return MOV_RIGHT;
            }
        }
    }
}
