using System.Xml.Linq;

class Port {
  public List < Sudno > port = new List < Sudno > ();
  public void AddKorabl(string name) {
    port.Add(new Korabl(name));
  }
  public void AddParohod(string name) {
    port.Add(new Parohod(name));
  }
  public void AddKater(string name) {
    port.Add(new Kater(name));
  }
  public void Change(int index, string name) {
    port[index].ChangeName(name);
  }
  public void Remove(int index) {
    port.RemoveAt(index);
  }
  public Sudno this[int index] {
    get {
      return port[index];
    }
    set {
      port[index] = value;
    }
  }
  public void Show() {
    int i = 0;
    foreach(Sudno sudno in port) {
      Console.WriteLine(sudno + " " + sudno.Name + " " + i);
      i++;
    }
  }
}
abstract class Sudno {
  private string name;
  public string Name {
    get {
      return name;
    }
    set {
      name = value;
    }
  }
  public Sudno(string name) {
    this.name = name;
  }
  public abstract string ChangeName(string name);
}
class Korabl: Sudno {
  public Korabl(string name): base(name) {}
  public override string ChangeName(string name) {
    Name = name;
    return Name;
  }
}
class Parohod: Sudno {
  public Parohod(string name): base(name) {}
  public override string ChangeName(string name) {
    Name = name;
    return Name;
  }
}
class Kater: Sudno {
  public Kater(string name): base(name) {}
  public override string ChangeName(string name) {
    Name = name;
    return Name;
  }
}
class Program {
  static void Main() {
    Port port = new Port();
    Console.WriteLine("0 - добавить в коллекцию объект.");
    Console.WriteLine("1 - удалить объект из коллекции.");
    Console.WriteLine("2 - вывести сведения по имеющимся в коллекции объектам.");
    Console.WriteLine("3 - внести изменения в характеристики объекта коллекции.");
    Console.WriteLine("4 - выход из программы.");
    bool f = true;
    while (f) {
      Console.WriteLine("Что вы хотите сделать?");
      string value = Console.ReadLine();
      switch (value) {
      case "0":
        Console.WriteLine("0 - Корабль \n1 - Пароход \n2 - Катер");
        string v = Console.ReadLine();
        Console.WriteLine("Введите имя");
        switch (v) {
        case "0":
          port.AddKorabl(Console.ReadLine());
          break;
        case "1":
          port.AddParohod(Console.ReadLine());
          break;
        case "2":
          port.AddKater(Console.ReadLine());
          break;
        }
        break;
      case "1":
        Console.WriteLine("Введите индекс");
        port.Remove(Convert.ToInt32(Console.ReadLine()));
        break;
      case "2":
        port.Show();
        break;
      case "3":
        Console.WriteLine("Введите индекс, имя");
        int index = Convert.ToInt32(Console.ReadLine());
        string name = Console.ReadLine();
        port.Change(index, name);
        break;
      case "4":
        f = false;
        break;
      }
    }
  }
}
