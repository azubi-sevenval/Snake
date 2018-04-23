namespace ListardDemo {
  class Game {
    static void Main(string[] args) {
      Feld feld = new Feld();
      Snake snek = new Snake();

      bool isAlive = true;
      while (isAlive) {
        Task.Delay(200).Wait();
                snek.Move();
        snek.Render();
      }

      Console.ReadLine();
    }
  }
}
