using System;

namespace Snake {
  public class Feld {
    private int width;
    private int height;

    public Feld() {
      this.width = Console.WindowWidth - 1;
      this.height = Console.WindowHeight;
      Console.BackgroundColor = ConsoleColor.Green;
      // Console.SetBufferSize(width, height); Mac incomp
      Console.SetCursorPosition(50, 50);
      Console.Clear();
    }
  }
}
