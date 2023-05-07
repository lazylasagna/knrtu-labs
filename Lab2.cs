using System;
using System.Data;
using static System.Math;

namespace Lab2 {
  class Program {

    static void Main() {
      int n = Convert.ToInt32(Console.ReadLine());
      int sum = 0;
      int sumel = 0;
      int el1 = 100;
      int el2 = 0;
      int[] array = new int[n];
      Random rand = new Random();
      bool ind = false;
      for (int k = 0; k < n; k++) {
        array[k] = rand.Next(-20, 20);
        for (int j = k - 1; j >= 0; j--)
          if (array[k] == array[j]) ind = true;
        if (ind) k = k - 1;
        ind = false;
      }
      for (int i = 0; i < n; ++i) {
        Console.Write(array[i] + "\t");
        if (array[i] < 0) {
          if (el1 > i) el1 = i;
          if (el2 < i) el2 = i;
        }
      }
      Console.WriteLine("\n");
      for (int i = 0; i < n; ++i) {
        if (i > el1 && i < el2) sumel += array[i];
      }
      for (int i = 1; i < n; i += 2) {
        sum += array[i];
      }
      Console.WriteLine(sum);
      Console.WriteLine(sumel);
    }
  }
}
