/*using System;
using System.Data;
using static System.Math;

namespace Lab3
{
class Program
{
static void Main()
{
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
int m = 0;
int k = 0;
int pos1 = 10000000;
int pos2 = 0;
Random rand = new Random();
for (int y = 0; y < n; y++)
{
a[y] = rand.Next(-10, 10);
}
for (int i = 0; i < n; i++)
{
Console.Write(a[i] + " ");
if (i % 2 != 0)
{
m += a[i];
}
if (a[i] < 0)
{
pos1 = Min(pos1, i);
pos2 = Max(pos2, i);
}
}
for (int i = pos1+1; i < pos2; i++)
{
k += a[i];
}
Console.WriteLine("\n" + m + "\n" + k);
}
}
}*/

using System;
using System.Data;
using static System.Math;

namespace Lab3 {
  class Program {
    static void Main() {
      int n = Convert.ToInt32(Console.ReadLine());
      int[, ] a = new int[n, n];
      int p = 0;
      int k = 0;
      Random rand = new Random();
      for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
          a[i, j] = rand.Next(-10, 10);
        }
      }
      Console.WriteLine();
      for (int i = 0; i < n; i++) {
        p = 1;
        for (int j = 0; j < n; j++) {
          if (a[i, j] > 0) {
            p *= a[i, j];
          } else {
            p = 0;
          }

        }
        Console.WriteLine(p);
      }
      Console.WriteLine();
      for (int i = 0; i < n; i++) {

        for (int j = 0; j < n; j++) {
          Console.Write(a[i, j] + "\t");
        }
        Console.WriteLine();
      }
      for (int i = 0; i < n; i++) {

        for (int j = 0; j < 1; j++) {
          k = a[i, j];
          a[i, j] = a[i, j + 1];
          a[i, j + 1] = k;
        }
      }
      Console.WriteLine();
      for (int i = 0; i < n; i++) {

        for (int j = 0; j < n; j++) {
          Console.Write(a[i, j] + "\t");
        }
        Console.WriteLine();
      }
    }
  }
}
