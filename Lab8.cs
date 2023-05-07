class korabl {
  public korabl() {
    this.name = "Noname";
    this.vod = 100;
    this.type = "type";
  }
  public korabl(string name): this() {
    this.name = name;
  }
  public korabl(string name, string type, int vod) {
    this.name = name;
    this.vod = vod;
    this.type = type;
  }
  public void Show() {
    Console.WriteLine("Наименование {0} Тип {1} Водоизмещение {2}", name, type, vod);
  }
  public void ChangeName(string name) {
    this.name = name;
  }
  public void ChangeVod(int vod) {
    this.vod = vod;
  }
  public void ChangeType(string type) {
    this.type = type;
  }
  public void Change(string Name, string Type, int Vod) {
    name = Name;
    vod = Vod;
    type = Type;
  }
  public void Save() {
    using(FileStream fs = new FileStream(@ "D:\text3.txt", FileMode.Append)) {
      using(StreamWriter sw = new StreamWriter(fs)) {
        sw.WriteLine($"Наименование: {name}");
        sw.WriteLine($"Тип: {type}");
        sw.WriteLine($"Водоизмещение: {vod}");
      }
    }
  }
  public string SetName {
    get {
      return name;
    }
    set {
      name = value;
    }
  }
  public string SetType {
    get {
      return type;
    }
    set {
      type = value;
    }
  }
  public int SetVod {
    get {
      return vod;
    }
    set {
      vod = value;
    }
  }
  public static korabl operator + (korabl a, korabl b) {
    return new korabl(a.name + " и " + b.name, a.type + " и " + b.type, a.vod + b.vod);
  }

  public static bool operator < (korabl a, korabl b) {
    return a.vod < b.vod;
  }

  public static bool operator > (korabl a, korabl b) {
    return a.vod > b.vod;
  }

  string name, type;
  int vod;

}
class Class1 {
  static void Main() {
    korabl k = new korabl();
    korabl y = new korabl("Один", "Галера", 10000);
    y.Show();
    k.Change("Два", "Лодка", 200);
    k.Show();
    k.Save();
    y.Save();
    korabl l = y + k;
    l.Show();
    if (y > k) Console.WriteLine("Верно");
    else Console.WriteLine("Неверно");
  }
}
}
