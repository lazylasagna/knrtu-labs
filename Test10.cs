class Program {
  static void Main() {
    Polis[] polises = new Polis[3];
    polises[0] = new Polis("Тесла", "Осаго", 500);
    polises[1] = new Polis("Лада", "Каско", 400);
    polises[2] = new Polis("Шевроле", "Помощь на дороге", 700);
    foreach(Polis polis in polises) polis.Save();
    Console.WriteLine(polises[0] + polises[1]);
    Polis.Linq1(polises);
    Polis.Linq2(polises);
  }
  class Polis {
    public Polis(string auto, string type, int stoimost) {
      this.auto = auto;
      this.type = type;
      this.stoimost = stoimost;
    }
    string auto;
    string type;
    int stoimost;
    public void Save() {
      using(FileStream fs = new FileStream(@ "D:\text10.txt", FileMode.Append)) {
        using(StreamWriter sw = new StreamWriter(fs)) {
          sw.WriteLine($"{auto} {type} {stoimost}");
        }
      }
    }
    static public int operator + (Polis ? polis1, Polis ? polis2) {
      return polis1.stoimost + polis2.stoimost;
    }
    static public void Linq1(Polis[] array) {
      var selected_ = from p in array
      orderby - p.stoimost
      select p;
      foreach(var item in selected_) Console.WriteLine($"{item.auto} {item.type} {item.stoimost}");
    }
    static public void Linq2(Polis[] array) {
      int count = 0;
      var selected_ = from p in array
      where p.type == "Каско"
      select p;
      foreach(var item in selected_) {
        count++;
      }
      Console.WriteLine(count);
    }

  }
}
