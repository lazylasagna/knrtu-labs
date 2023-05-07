using System;
using System.Data;
using static System.Math;

namespace Lab4 {
  class Program {
    static void Main() {
      List < int > a = new List < int > (5);
      Random rand = new Random();
      int mmax = 0;
      int mmin = 10000;
      int[] c = new int[3];
      for (int i = 0; i < 5; i++) {
        a.Add(rand.Next(100));
      }
      foreach(int x in a) Console.Write(x + " ");
      a.Add(rand.Next(100));
      Console.WriteLine();
      foreach(int x in a) Console.Write(x + " ");
      List < int > b = new List < int > (3);
      for (int i = 0; i < 3; i++) {
        b.Add(rand.Next(100));
      }
      Console.WriteLine();
      foreach(int x in b) Console.Write(x + " ");
      a.InsertRange(3, b);
      Console.WriteLine();
      foreach(int x in a) Console.Write(x + " ");
      Console.WriteLine("\n" + "Количество элементов: " + a.Count);
      for (int i = 0; i < a.Count; i++) {
        if (a[i] > mmax) mmax = a[i];
        if (a[i] < mmin) mmin = a[i];
      }
      int k = 0;
      foreach(int x in b) {
        c[k] = x;
        k++;
      }
      Console.WriteLine("Максимальный элемент: " + mmax + "\n" + "Минимальный элемент: " + mmin);
      for (int i = 0; i < c.Length; i++) Console.Write(c[i] + " ");
      b.Remove(b[1]);
      Console.WriteLine();
      foreach(int x in b) Console.Write(x + " ");
    }
  }
}
