using System;

namespace ListardDemo {
  public class Listard<T> {
    public T[] values = new T[0];
    private T Udo;

    public Listard(T Udo) {
      this.Udo = Udo;
    }

    public T[] Push(T value) {
      T[] newarray = new T[values.Length + 1];

      for (int i = 0; i < values.Length; i++) {
        newarray[i] = values[i];
      }
      newarray[values.Length] = value;
      values = newarray;

      return values;
    }

    public T[] Pop() {
      T[] newarray = new T[values.Length - 1];

      for (int i = 0; i < newarray.Length; i++) {
        newarray[i] = values[i];
      }
      values = newarray;

      return values;
    }

    public T[] Shift(T value) {
      T[] newarray = new T[values.Length + 1];

      for (int i = 0; i < values.Length; i++) {
        newarray[i] = values[i];
      }
      newarray[values.Length] = value;
      values = newarray;

      return values;
    }

    public T[] Unshift() {
      T[] newarray = new T[values.Length - 1];
      this.Remove(0);

      return values;
    }

    public T[] Remove(int index) {
      T[] newarray = new T[values.Length - 1];
      for (int i = 0; i < values.Length; i++) {
        if (i < index) {
          newarray[i] = values[i];
        } else if (i > index) {
          newarray[i - 1] = values[i];
        } else {
          continue;
        }
      }
      values = newarray;
      return values;
    }

    public T[] Replace(int index, T value) {
      values[index] = value;
      return values;
    }

    public T[] Insert(int index, T value) {
      T[] newarray = new T[values.Length + 1];

      for (int i = 0; i < newarray.Length; i++) {
        if (i < index) {
          newarray[i] = values[i];
        } else if (i > index) {
          newarray[i] = values[i - 1];
        } else {
          newarray[i] = value;
        }
      }
      values = newarray;
      return values;
    }
  }
}
