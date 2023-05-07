class Program {
  static void Main() {
    Стройматериал[] стройматериалы = new Стройматериал[4];
    стройматериалы[0] = new Стройматериал("Доски", 100, 50);
    стройматериалы[1] = new Стройматериал("Фанера", 100, 70);
    стройматериалы[2] = new Стройматериал("Кирпичи", 300, 20);
    стройматериалы[3] = new Стройматериал("Доски", 100, 50);
    Console.WriteLine(стройматериалы[0] == стройматериалы[3]);
    Стройматериал.Linq1(стройматериалы);
    Стройматериал.Linq2(стройматериалы);
  }
  class Стройматериал {
    public Стройматериал(string наименование, int количество, int цена) {
      this.наименование = наименование;
      this.количество = количество;
      this.цена = цена;
    }
    string наименование;
    int количество;
    int цена;
    public void Расчет() {
      Console.WriteLine(количество * цена);
    }
    static public bool operator == (Стройматериал с1, Стройматериал с2) {
      return с1.наименование == с2.наименование;
      return с1.количество == с2.количество;
      return с1.цена == с2.цена;
    }
    static public bool operator != (Стройматериал с1, Стройматериал с2) {
      return с1.наименование != с2.наименование;
      return с1.количество != с2.количество;
      return с1.цена != с2.цена;
    }
    static public void Linq1(Стройматериал[] array) {
      var selected_ = from p in array
      orderby - p.цена
      select p;
      foreach(var selected in selected_) Console.WriteLine($"{selected.наименование} {selected.количество} {selected.цена}");
    }
    static public void Linq2(Стройматериал[] array) {
      var selected_ = from p in array
      orderby p.цена
      select p;
      foreach(var selected in selected_) {
        Console.WriteLine($"{selected.наименование} {selected.количество} {selected.цена}");
        break;
      }
    }
  }
}
