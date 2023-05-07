using System;
using System.Data;
using static System.Math;

namespace Lab5 {
  class Program {
    static void Main() {
      string l = "язык программирования C#";
      string l1 = "";
      int k = 0;
      while (l.LastIndexOf(" ") > 0) {
        for (int i = l.LastIndexOf(" ") + 1; i < l.Length; i++) {
          l1 += l[i];
        }
        l1 += " ";
        l = l.Remove(l.LastIndexOf(" "));
      }
      l1 = l1 + l;
      Console.WriteLine(l1);
      l = "язык программирования C#";
      l1 = "";
      for (int i = l.Length - 1; i >= 0; i--) {
        l1 += l[i];
      }
      Console.WriteLine(l1);
    }
  }
}
