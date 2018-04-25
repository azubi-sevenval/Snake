using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class Game
    {
        static System.ConsoleKey currentDirection = ConsoleKey.D;

        static void Main(string[] args)
        {
            Feld feld = new Feld(10, 10);
            Snake snek = new Snake();
            Food food = new Food();

            bool isAlive = true;
            while (isAlive)
            {
                Task.Delay(200).Wait();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey(true);
                    if (userInput.Key == ConsoleKey.A && currentDirection != ConsoleKey.D)
                    {
                        currentDirection = ConsoleKey.A;
                    }
                    if (userInput.Key == ConsoleKey.D && currentDirection != ConsoleKey.A)
                    {
                        currentDirection = ConsoleKey.D;
                    }
                    if (userInput.Key == ConsoleKey.W && currentDirection != ConsoleKey.S) // replace with WASD?
                    {
                        currentDirection = ConsoleKey.W;
                    }
                    if (userInput.Key == ConsoleKey.S && currentDirection != ConsoleKey.W)
                    {
                        currentDirection = ConsoleKey.S;
                    }
                }

                if(snek.Head().x == Console.WindowWidth - 1 && snek.Head().y == Console.WindowHeight - 1) {
                    Console.Write("GAME OVER!");
                }

                //food.Spawn();
                snek.Move(Direction(currentDirection));
                snek.Draw();
            }
            food.Spawn();
            Console.ReadLine();
        }

        static Position Direction(System.ConsoleKey dir) {
            Position MOV_DOWN = new Position(0, 1);
            Position MOV_RIGHT = new Position(1, 0);
            Position MOV_UP = new Position(0, -1);
            Position MOV_LEFT = new Position(-1, 0);

            switch (dir)
            {
              case ConsoleKey.W:
                  return MOV_UP;
              case ConsoleKey.D:
                  return MOV_RIGHT;
              case ConsoleKey.S:
                  return MOV_DOWN;
              case ConsoleKey.A:
                  return MOV_LEFT;
              default:
                  return MOV_RIGHT;
            }
        }
    }
}
