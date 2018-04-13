using System;

namespace ListardDemo {
  public class Feld {
    private int width;
    private int height;

    public Feld() {
      this.width = Console.WindowWidth - 1;
      this.height = Console.WindowHeight;
      Console.BackgroundColor = ConsoleColor.Green;
      Console.Clear();
      Snake snek = new Snake(width, height);
	  }
  }
}
