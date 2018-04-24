using System;
using System.Collections;
using System.Collections.Generic;

namespace Snake {
  class Snake {
    List<Position> snek = new List<Position>();

    public Snake () {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.CursorVisible = true;
      //Console.CursorSize = 100; Mac imcomp

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

    public void Move() {
      Position snakeHead = snek[snek.Count - 1];
      Position next = new Position(snakeHead.x + 1, snakeHead.y);
      snek.Add(next);

      if(snek.Count > 1) {
          snek.RemoveAt(0);
          Console.SetCursorPosition(snek[0].x, snek[0].y);
          Console.Write("\b \b");
      }
    }

    public void Eat() {
            // if snakeHead == Food => snek.Add(Food)
            // snek.Update();
    }
  }
}
