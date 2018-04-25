using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Snake {
  class Snake {
    public List<Position> snek = new List<Position>();
            
    public Snake () {
      Console.ForegroundColor = ConsoleColor.Black;
    
      // Die Schlange startet initial mit der Länge 3
      Position a = new Position(21, 10);
      Position b = new Position(22, 10);
      Position c = new Position(23, 10);
      snek.Add(a);
      snek.Add(b);
      snek.Add(c);
    }

    public void Draw()
    {
       foreach(var pos in snek) {
         Console.SetCursorPosition(pos.x, pos.y);
         Console.Write("O");
       }
    }

    public void Move(Position dir) {
      Position snakeHead = snek[snek.Count - 1];
      Position next = new Position(snakeHead.x + dir.x, snakeHead.y + dir.y);
      snek.Add(next);

      if(snek.Count > 1) {
          snek.RemoveAt(0);
          Console.Clear();
      }
    }

     public Position Head() {
         Position snakeHead = snek[snek.Count - 1];
         return snakeHead;
     }

    public void Eat(Position food) {
        snek.Add(food);
    }
  }
}
