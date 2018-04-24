using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
  class Game {
    static void Main(string[] args) {
      Feld feld = new Feld();
      Snake snek = new Snake();
      Food food = new Food();

      bool isAlive = true;
      while (isAlive) {
        Task.Delay(200).Wait();
        food.Spawn();
        snek.Move();
        snek.Draw();
      }

      Console.ReadLine();
    }
  }
}
