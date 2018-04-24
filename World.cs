using System;
using System.Collections.Generic;

namespace Snake
{
    public class World
    {
        List<Position> snek = new List<Position>();
        public void Draw()
        {
            foreach (var pos in snek)
            {
                Console.SetCursorPosition(pos.x, pos.y);
                Console.Write("O");
            }
        }
    }
}
