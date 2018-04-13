using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListardDemo {
  class Game {
    static void Main(string[] args) {
      Position Udo = new Position(1,1);
      Feld Heinz = new Feld();
      Listard<Position> Uwe = new Listard<Position>(Udo);

      bool condition = true;
      while (condition) {
        Task.Delay(200).Wait();
        Console.Write("O");
      }
      Console.ReadLine();
    }
  }
}
