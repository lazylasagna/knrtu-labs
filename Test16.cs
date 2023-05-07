class Program {
  static void Main() {
    List < Uchastnik > uchastniks = new List < Uchastnik > ();
    uchastniks.Add(new Uchastnik("Орлов Дмитрий", 40, 60));
    uchastniks.Add(new Uchastnik("Орло Дмитри", 4, 6));
    uchastniks.Add(new Uchastnik("Орл Дмитр", 30, 50));
    foreach(Uchastnik uchastnik in uchastniks) Console.WriteLine($"{uchastnik.FIO} {uchastnik.balls1} {uchastnik.balls2}");
    Console.WriteLine();
    uchastniks.Sort();
    foreach(Uchastnik uchastnik in uchastniks) Console.WriteLine($"{uchastnik.FIO} {uchastnik.balls1} {uchastnik.balls2}");
    Console.WriteLine();
    Uchastnik.Linq1(uchastniks);
    Console.WriteLine();
    Uchastnik.Linq2(uchastniks);
  }
  class Uchastnik: IComparable < Uchastnik > {
    public Uchastnik(string FIO, int balls1, int balls2) {
      this.FIO = FIO;
      this.balls1 = balls1;
      this.balls2 = balls2;
    }
    public string FIO;
    public int balls1;
    public int balls2;
    public int Balls() {
      return balls1 + balls2;
    }
    public static void Linq1(List < Uchastnik > uchastniks) {
      int count = 0;
      var selected_ = from p in uchastniks
      select p.Balls();
      foreach(var item in selected_) count += item;
      Console.WriteLine(count / uchastniks.Count);
    }
    public static void Linq2(List < Uchastnik > uchastniks) {
      var selected_ = from p in uchastniks
      where p.Balls() == 100
      select p;
      foreach(var item in selected_) Console.WriteLine($"{item.FIO} {item.Balls()}");
    }

    public int CompareTo(Uchastnik ? uchastnik) {
      return uchastnik.Balls() - Balls();
    }
  }
}
