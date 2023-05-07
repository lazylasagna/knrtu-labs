class Program {
  static void Main() {
    List < Штраф > штрафы = new List < Штраф > (3);
    штрафы.Add(new Штраф("Штраф1", new DateTime(2022, 12, 31), 500));
    штрафы.Add(new Штраф("Штраф2", new DateTime(2023, 02, 28), 5000));
    штрафы.Add(new Штраф("Штраф3", new DateTime(2023, 01, 01), 1000));
    Штраф.Linq1(штрафы);
    Console.WriteLine();
    Штраф.Linq2(штрафы);
    Штраф_Comparer ш = new Штраф_Comparer();
    штрафы.Sort(ш);
    Console.WriteLine();
    foreach(var штраф in штрафы) Console.WriteLine($"{штраф.наименование} {штраф.дата} {штраф.сумма}");
  }
  class Штраф_Comparer: IComparer < Штраф > {
    public int Compare(Штраф ? x, Штраф ? y) {
      if (x is null || y is null)
        throw new ArgumentException("Некорректное значение параметра");
      if (x.дата > y.дата) return 1;
      if (x.дата < y.дата) return -1;
      return 0;
    }
  }
  class Штраф {
    public Штраф(string наименование, DateTime дата, double сумма) {
      this.наименование = наименование;
      this.дата = дата;
      this.сумма = сумма;
    }
    public string наименование;
    public DateTime дата;
    public double сумма;
    public void Проверка() {
      if (дата < DateTime.Now) сумма = сумма * 1.05;
    }
    static public void Linq1(List < Штраф > array) {
      var selected_ = from p in array
      where p.дата < DateTime.Now
      select p;
      foreach(var selected in selected_) Console.WriteLine($"{selected.наименование} {selected.дата} {selected.сумма}");
    }
    static public void Linq2(List < Штраф > array) {
      var selected_ = from p in array
      orderby - p.сумма
      select p;
      foreach(var selected in selected_) {
        Console.WriteLine($"{selected.наименование} {selected.дата} {selected.сумма}");
        break;
      }
    }
  }
}
