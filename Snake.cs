using System;
using System.Windows.Forms;

namespace ListardDemo {
  class Snake {
    private int width;
    private int height;

    public Snake (int width, int height) {
      this.width = width;
      this.height = height;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.SetCursorPosition(width / 2, height / 2);
      Console.CursorSize = 100;
      Console.CursorVisible = true;
    }

    private void Move(object sender, KeyPressEventArgs e) {
      switch (e.KeyCode) {
        case Up:
          Console.WriteLine("Up!");
        break;
        case Left:
          //
        break;
        case Down:
          //
        break;
        case Right:
          //
        break;
      }
    }
  }
}
