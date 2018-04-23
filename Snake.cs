using System;

namespace ListardDemo {
  class Snake {
    public Snake () {
      Console.ForegroundColor = ConsoleColor.Black;
      //Console.SetCursorPosition(25, 10);
      Console.CursorVisible = true;
	  //Console.CursorSize = 100; Mac imcomp

      // Die Schlange startet initial mit der Länge 3
      Position[] snek = new Position[3];
      for (int i = 0; i < 3; ++i)
      {
        snek[i] = new Position(i + 20, 10);
      }
      
      // Rendert die Positionen der Schlange
      for (int i = 0; i < snek.Length; i++) {
        Console.SetCursorPosition(snek[i].x, snek[i].y);
        Console.Write("O");
      }
    }

    public void Move() {
     // calculates new Position and Push, Pop from snek       
    }

    public void Eat() {
     // extends when Snake eats Food --> extend array and push new Position       
    }
  }
}
