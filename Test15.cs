class Program {
  static void Main() {
    List < Reis > reis = new List < Reis > ();
    reis.Add(new Reis("Москва", "Казань", new DateTime(2023, 01, 09)));
    reis.Add(new Reis("Чебоксары", "Москва", new DateTime(2023, 01, 08)));
    reis.Add(new Reis("Сочи", "Москва", new DateTime(2023, 02, 01)));
    foreach(Reis reis_ in reis) Console.WriteLine($"{reis_.mesto1} {reis_.mesto2} {reis_.date}");
    Console.WriteLine();
    reis.Sort(new Reis_Comparer());
    foreach(Reis reis_ in reis) Console.WriteLine($"{reis_.mesto1} {reis_.mesto2} {reis_.date}");
    Console.WriteLine();
    Reis.Linq1(reis);
    Console.WriteLine();
    Reis.Linq2(reis);
  }
  class Reis_Comparer: IComparer < Reis > {
    public int Compare(Reis ? x, Reis ? y) {
      if (x.date > y.date) return 1;
      if (x.date < y.date) return -1;
      return 0;
    }
  }
  class Reis {
    public Reis(string mesto1, string mesto2, DateTime date) {
      this.mesto1 = mesto1;
      this.mesto2 = mesto2;
      this.date = date;
    }
    public string mesto1;
    public string mesto2;
    public DateTime date;
    public override string ToString() {
      return $ "{mesto1} {mesto2} {date}";
    }
    public static void Linq1(List < Reis > reis) {
      var selected_ = from p in reis
      where p.mesto2 == "Москва"
      select p;
      foreach(var item in selected_) Console.WriteLine($"{item.mesto1} {item.mesto2} {item.date}");
    }
    public static void Linq2(List < Reis > reis) {
      var selected_ = from p in reis
      where p.date == new DateTime(2023, 01, 08)
      select p;
      foreach(var item in selected_) Console.WriteLine($"{item.mesto1} {item.mesto2} {item.date}");
    }

  }
}
