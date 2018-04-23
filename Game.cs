using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListardDemo {
  class Game {
    static void Main(string[] args) {
      Feld feld = new Feld();
      Snake snek = new Snake();

      bool isAlive = true;
      while (isAlive) {
        Task.Delay(200).Wait();
      }
      Console.ReadLine();
    }
  }
}
