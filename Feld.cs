using System;

namespace Snake {
  public class Feld {
    public Feld(int width, int height) {
      Console.BackgroundColor = ConsoleColor.Green;
      //Console.SetBufferSize(width, height);
      Console.SetCursorPosition(20, 10);
      Console.Clear();
    }
  }
}
