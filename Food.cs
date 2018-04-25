using System;
using System.Collections.Generic;

namespace Snake {
  class Food {
    Random rnd = new Random();
    List<Position> food = new List<Position>();

    public void Spawn() {
        Console.ForegroundColor = ConsoleColor.Red;
        int posX = rnd.Next(1, Console.WindowWidth - 1);
        int posY = rnd.Next(1, Console.WindowHeight);

        if(food.Count == 0) {
            Position createFood = new Position(posX, posY);
            food.Add(createFood);
            Console.SetCursorPosition(posX, posY);
            Console.Write("#");
        }
        Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine(posX);
            Console.WriteLine(posY);
        }

        // evtl. durch neue posX / posY bestimmen?
    //public void Despawn() {
    //    Console.SetCursorPosition(food[0].x, food[0].y);
    //    Console.Write("\b");
    //    food.RemoveAt(0);
    //}
  }
}
