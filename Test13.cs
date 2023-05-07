using System.Reflection.Metadata.Ecma335;

class Program {
  static void Main() {
    List < Kvitanciya > kvitanciyas = new List < Kvitanciya > ();
    kvitanciyas.Add(new Kvitanciya(1, "А", 100));
    kvitanciyas.Add(new Kvitanciya(4, "А", 100));
    kvitanciyas.Add(new Kvitanciya(2, "B", 200));
    kvitanciyas.Add(new Kvitanciya(3, "C", 300));
    Console.WriteLine(kvitanciyas[0] + kvitanciyas[1]);
    Kvitanciya.Linq1(kvitanciyas);
    Console.WriteLine();
    Kvitanciya.Linq2(kvitanciyas);
  }
  class Kvitanciya {
    public Kvitanciya(int code, string name, int summa) {
      this.code = code;
      this.name = name;
      this.summa = summa;
    }
    int code;
    string name;
    int summa;
    public override bool Equals(object ? obj) {
      if (obj is Kvitanciya kvitanciya) return summa == kvitanciya.summa;
      return false;
    }
    public static int operator + (Kvitanciya kvitanciya1, Kvitanciya kvitanciya2) {
      return kvitanciya1.summa + kvitanciya2.summa;
    }
    public static void Linq1(List < Kvitanciya > kvitanciyas) {
      var selected_ = from p in kvitanciyas
      group p by p.name;
      foreach(var selected in selected_) {
        int count = 0;
        Kvitanciya t;
        foreach(var item in selected) {
          count++;
        }
        foreach(var item in selected) {
          Console.Write($"{item.name}");
          break;
        }
        Console.Write(" " + count + "\n");
      }
    }
    public static void Linq2(List < Kvitanciya > kvitanciyas) {
      var selected_ = from p in kvitanciyas
      orderby - p.summa
      select p;
      foreach(var item in selected_) {
        Console.WriteLine($"{item.code} {item.name} {item.summa}");
      }
    }
  }
}
