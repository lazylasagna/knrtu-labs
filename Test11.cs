class Program {
  static void Main() {
    List < Nomer > nomers = new List < Nomer > ();
    nomers.Add(new Nomer(1, new DateTime(2023, 12, 01), new DateTime(2023, 12, 10)));
    nomers.Add(new Nomer(3, new DateTime(2023, 01, 01), new DateTime(2023, 01, 05)));
    nomers.Add(new Nomer(4, new DateTime(2022, 12, 10), new DateTime(2022, 12, 30)));
    foreach(Nomer nomer in nomers) Console.WriteLine($"{nomer.nomer} {nomer.date1} {nomer.date2} {nomer.Raschet(nomer)}");
    Console.WriteLine();
    nomers.Sort();
    foreach(Nomer nomer in nomers) Console.WriteLine($"{nomer.nomer} {nomer.date1} {nomer.date2} {nomer.Raschet(nomer)}");
    Console.WriteLine();
    Nomer.Linq1(nomers);
    Console.WriteLine();
    Nomer.Linq2(nomers);
  }
  class Nomer: IComparable < Nomer > {
    public Nomer(int nomer, DateTime date1, DateTime date2) {
      this.nomer = nomer;
      this.date1 = date1;
      this.date2 = date2;
    }
    public int nomer;
    public DateTime date1;
    public DateTime date2;
    public int Raschet(Nomer nomer) {
      return nomer.date2.Day - nomer.date1.Day;
    }

    public int CompareTo(Nomer ? nomer) {
      return Raschet(nomer) - (date2.Day - date1.Day);
    }
    static public void Linq1(List < Nomer > array) {
      var selected_ = from p in array
      where!(p.date1 < DateTime.Now & DateTime.Now < p.date2)
      select p;
      foreach(var selected in selected_) Console.WriteLine($"{selected.nomer} {selected.date1} {selected.date2}");

    }
    static public void Linq2(List < Nomer > array) {
      var selected_ = from p in array
      where p.date1 < DateTime.Now & DateTime.Now < p.date2
      select p;
      foreach(var selected in selected_) Console.WriteLine($"{selected.nomer} {selected.date1} {selected.date2}");

    }

  }
}
