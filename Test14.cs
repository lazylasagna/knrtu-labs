class Program {
  static void Main() {
    Predpriyatie[] predpriyaties = new Predpriyatie[3];
    predpriyaties[0] = new Predpriyatie("Газпром");
    predpriyaties[0].Add("Газ");
    predpriyaties[1] = new Predpriyatie("Лоджитык");
    predpriyaties[1].Add("Клавиатуры");
    predpriyaties[2] = new Predpriyatie("Илон маск");
    predpriyaties[2].Add("Чипы");
    predpriyaties[2].Add("Все на свете");
    Console.WriteLine(predpriyaties[2][1]);
    Predpriyatie.Linq1(predpriyaties);
    Console.WriteLine();
    Predpriyatie.Linq2(predpriyaties);
  }
  class Predpriyatie {
    public Predpriyatie(string name) {
      this.name = name;
      //List<String> products = new List<string>();
    }
    string name;
    public string Name {
      get {
        return name;
      }
      set {
        name = value;
      }
    }
    List < string > products = new List < string > ();
    public void Add(string tovar) {
      products.Add(tovar);
    }
    public string this[int index] {
      get {
        return products[index];
      }
      set {
        products[index] = value;
      }
    }
    public static void Linq1(Predpriyatie[] predpriyaties) {
      var selected_ = from p in predpriyaties
      select p;
      foreach(var item in selected_) Console.WriteLine(item.Name + " " + item.products.Count);
    }
    public static void Linq2(Predpriyatie[] predpriyaties) {
      var selected_ = from p in predpriyaties
      where p.products.Contains("Клавиатуры")
      select p;
      if (selected_.Count() > 0) foreach(var item in selected_) Console.WriteLine(item.Name + " Клавиатура");
      else Console.WriteLine("Нет предприятий");
    }
  }
}
