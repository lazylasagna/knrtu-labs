using System;

class Program {
  static void Main() {
    Film[] films = new Film[4];
    films[0] = new Film("Звездные воины", 3000, 100);
    films[0].Analize();
    films[1] = new Film("Аватар 2", 5000, 400);
    films[2] = new Film("Брат", 10, 5);
    films[3] = new Film("Бра", 10, 5);
    foreach(Film film in films) film.Show();
    Array.Sort(films);
    Console.WriteLine();
    foreach(Film film in films) film.Show();
    /* Film.Linq1(films);
    Film.Linq2(films);*/
  }
  class Film: IComparable < Film > {
    public Film(string название, int сборы, int бюджет) {
      this.название = название;
      this.сборы = сборы;
      this.бюджет = бюджет;
    }
    string название;
    int сборы;
    int бюджет;
    public void Analize() {
      //Console.WriteLine(сборы); 3000
      if (сборы > бюджет) Console.WriteLine(true);
      else Console.WriteLine(false);
    }

    public int CompareTo(Film ? film) {
      if (film is null) throw new ArgumentException("Некорректное значение параметра");
      return film.сборы - сборы;
    }
    public void Show() {
      Console.WriteLine($"{название} {сборы} {бюджет}");
    }
    public static void Linq1(Film[] array) {
      var selected_film = from p in array
      orderby p.бюджет
      select p;
      foreach(var film in selected_film) {
        Console.WriteLine($"{film.название} {film.сборы} {film.бюджет}");
        break;
      }
    }

    public static void Linq2(Film[] array) {
      var selected_film = array.Skip(array.Length / 2);
      foreach(var film in selected_film) Console.WriteLine($"{film.название} {film.сборы} {film.бюджет}");
    }
  }
}
