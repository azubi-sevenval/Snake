using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Snake {
    class Game
    {
        // Control Settings
        static System.ConsoleKey DIR_UP = ConsoleKey.W;
        static System.ConsoleKey DIR_RIGHT = ConsoleKey.D;
        static System.ConsoleKey DIR_DOWN = ConsoleKey.S;
        static System.ConsoleKey DIR_LEFT = ConsoleKey.A;

        // Initial Direction on Game Start
        static System.ConsoleKey currentDirection = DIR_RIGHT;

        static void Main(string[] args)
        {
            Feld feld = new Feld(40, 20);
            Snake snek = new Snake();
            Food food = new Food();

            Console.CursorVisible = false;

            bool isAlive = true;
            while (isAlive)
            {
                Task.Delay(100).Wait();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey(true);
                    if (userInput.Key == DIR_LEFT && currentDirection != DIR_RIGHT)
                    {
                        currentDirection = DIR_LEFT;
                    }
                    if (userInput.Key == DIR_RIGHT && currentDirection != DIR_LEFT)
                    {
                        currentDirection = DIR_RIGHT;
                    }
                    if (userInput.Key == DIR_UP && currentDirection != DIR_DOWN) // replace with WASD?
                    {
                        currentDirection = DIR_UP;
                    }
                    if (userInput.Key == DIR_DOWN && currentDirection != DIR_UP)
                    {
                        currentDirection = DIR_DOWN;
                    }
                }

                if(snek.Head().x == Console.WindowWidth - 1 && snek.Head().y == Console.WindowHeight - 1) {
                    isAlive = false;
                    Console.SetCursorPosition(50, 50);
                    Console.Write("GAME OVER!");
                }

                food.Spawn();
                snek.Move(Direction(currentDirection));
                snek.Draw();
                food.Draw();

                if(snek.Head().x == food.Position(0).x && snek.Head().y == food.Position(0).y) {
                    snek.Eat(food.Position(0));
                    food.Despawn();
                    Thread.Sleep(150);
                }
            }
            Console.ReadLine();
        }

        static Position Direction(System.ConsoleKey dir)
        {
            Position MOV_DOWN = new Position(0, 1);
            Position MOV_RIGHT = new Position(1, 0);
            Position MOV_UP = new Position(0, -1);
            Position MOV_LEFT = new Position(-1, 0);

            //switch (dir)
            //{
            //    case ConsoleKey.W:
            //      return MOV_UP;
            //  case ConsoleKey.D:
            //      return MOV_RIGHT;
            //  case ConsoleKey.S:
            //      return MOV_DOWN;
            //  case ConsoleKey.A:
            //      return MOV_LEFT;
            //  default:
            //      return MOV_RIGHT;
            //}

            if (dir.Equals(DIR_UP))
            {
                return MOV_UP;
            }
            else if (dir.Equals(DIR_RIGHT))
            {
                return MOV_RIGHT;
            }
            else if (dir.Equals(DIR_DOWN))
            {
                return MOV_DOWN;
            }
            else if (dir.Equals(DIR_LEFT))
            {
                return MOV_LEFT;
            }
            else
            {
                return MOV_RIGHT;
            }
        }
    }
}
