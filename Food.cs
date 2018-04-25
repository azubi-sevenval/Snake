using System;
using System.Collections.Generic;

namespace Snake {
  class Food {
    Random rnd = new Random();
    List<Position> food = new List<Position>();

    public void Spawn() {
        Console.ForegroundColor = ConsoleColor.Red;
        if(food.Count == 0) {
            int posX = rnd.Next(1, Console.WindowWidth - 1);
			int posY = rnd.Next(1, Console.WindowHeight);

            Position newFood = new Position(posX, posY);
            food.Add(newFood);
        }
        Console.ForegroundColor = ConsoleColor.Black;
    }

    // ugly method, because Draw()-method already exists in Snake class
    // write Draw()-method in Game class and take Position elements as parameter?
    public void Draw() {
        foreach(Position pos in food) {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.Write("#");
        }
    }

    public Position Position(int index) {
        return food[index];
    }

    public void Despawn() {
        Console.SetCursorPosition(food[0].x, food[0].y);
        Console.Write("\b \b");
        food.RemoveAt(0);
    }
  }
}
