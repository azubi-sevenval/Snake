using System;

namespace ListardDemo {
  class Position {
    int x, y;

    public Position(int x, int y) {
      this.x = x;
      this.y = y;
    }

    public int[] read() {
      int[] positions = { x, y };
      return positions;
    }
  }
}
