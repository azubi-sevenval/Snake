using System;

namespace ListardDemo {
  class Food {
    Random rnd = new Random();
    private int width;
    private int height;

    public Food() {
      this.width = rnd.Next(1, Console.WindowWidth - 1);
      this.height = rnd.Next(1, Console.WindowHeight);
      Console.ForegroundColor = ConsoleColor.Red;
      Console.SetCursorPosition(width, height);
    }
  }
}
