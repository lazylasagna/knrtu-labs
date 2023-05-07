using System.Xml.Linq;
using System;

class Program {
  static void Main() {
    Цилиндр[] цилиндры = new Цилиндр[4];
    цилиндры[0] = new Цилиндр(10, 5);
    цилиндры[1] = new Цилиндр(8, 6);
    цилиндры[2] = new Цилиндр(12, 4);
    цилиндры[3] = new Цилиндр(10, 5);
    Цилиндр.Linq1(цилиндры);
    Console.WriteLine();
    Цилиндр.Linq2(цилиндры);
    var цилиндр = (Цилиндр) цилиндры[0].Clone();
    Console.WriteLine($"{цилиндр.высота} {цилиндр.радиус}");
  }
  class Цилиндр: ICloneable {
    public Цилиндр(int высота, int радиус) {
      this.высота = высота;
      this.радиус = радиус;
    }
    public int высота;
    public int радиус;
    public void Объем() {
      Console.WriteLine(Math.Round(Math.PI * радиус * радиус * высота));
    }
    static public void Linq1(Цилиндр[] array) {
      var selected_ = from p in array
      group p by p.радиус * p.радиус * p.высота;
      foreach(var item in selected_) {
        foreach(var i in item) Console.WriteLine($"{i.высота} {i.радиус}");
      }
    }
    static public void Linq2(Цилиндр[] array) {
      double summ = 0;
      var selected_ = from p in array
      select p;
      foreach(var item in selected_) {
        summ += Math.PI * item.радиус * item.радиус * item.высота;
      }
      Console.WriteLine(Math.Round(summ / array.Length));
    }
    public object Clone() {
      return new Цилиндр(высота, радиус);
    }
  }
}
