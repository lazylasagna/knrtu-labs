using System;

class Program {
  static void Main() {
    List < Painting > paintings = new List < Painting > (4);
    paintings.Add(new Painting("Море", "Айвазовский", 1990));
    paintings.Add(new Painting("С#", "Орлов", 2000));
    paintings.Add(new Painting("Море2", "Айвазовский", 1991));
    Painting.Linq1(paintings);
    Painting.Linq2(paintings);
    Console.WriteLine(paintings[0]);
    Array.Sort(paintings);
    foreach(Painting painting in paintings) Console.WriteLine(painting);
  }
  class Painting: IComparable < Painting > {
    public Painting() {

    }
    public Painting(string name, string author, int date) {
      this.name = name;
      this.author = author;
      this.date = date;
    }
    public string Name {
      get;
      set;
    }
    public string Author {
      get;
      set;
    }
    public int Date {
      get;
      set;
    }
    string name;
    string author;
    int date;
    static public void Linq1(List < Painting > array) {
      var selected_author = from p in array
      group p by p.author;
      foreach(var item in array) {
        Console.WriteLine("{0} {1} {2}", item.name, item.author, item.date);
      }
    }
    static public void Linq2(List < Painting > array) {
      int count = 0;
      var selected_author = from p in array
      where p.author == "Айвазовский"
      select p;
      foreach(var author in selected_author) {
        count++;
      }
      if (count == array.Count) Console.WriteLine("Все картины написаны Айвазовским");
      else Console.WriteLine("Не все картины написаны Айвазовским");

    }
    public override string ToString() {
      return $ "{name} {author} {date}";
    }

    public int CompareTo(Painting ? obj) {
      if (obj is Painting painting) return author.CompareTo(painting.Author);
      else throw new ArgumentException("Некорректное значение параметра");
    }
  }
}
