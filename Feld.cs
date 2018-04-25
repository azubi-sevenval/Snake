using System;

namespace Snake {
  public class Feld {
    int width;
    int height;

    public Feld(int width, int height) {
      this.width = Console.WindowWidth - 1;
      this.height = Console.WindowHeight;
      Console.BackgroundColor = ConsoleColor.Green;
      // Console.SetBufferSize(width, height); Mac incomp
      Console.SetCursorPosition(50, 50);
      Console.Clear();
    }
  }
}
