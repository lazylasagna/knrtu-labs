using System;
using static Program;

class Program {
  static void Main() {
    Билет[] array = new Билет[3];
    array[0] = new Билет("Снежная королева", new DateTime(2022, 12, 31), 500);
    array[1] = new Билет("Щелкунчик", new DateTime(2023, 02, 10), 400);
    array[2] = new Билет("Щелк", new DateTime(2021, 02, 10), 450);
    Билет.Show(array);
    foreach(Билет билет in array) Билет.Время(билет);
    Билет.Show(array);
    Билет.Фильтр(array, new DateTime(2022, 01, 01));
    Билет.Сорт(array);
  }
  public class Билет {
    public Билет(string наименование, DateTime дата, int стоимость) {
      this.наименование = наименование;
      this.дата = дата;
      this.стоимость = стоимость;
    }
    string наименование;
    public DateTime дата;
    int стоимость;
    public string Наименование {
      get {
        return наименование;
      }
    }
    public DateTime Дата {
      get {
        return дата;
      }
      set {
        дата = Convert.ToDateTime(value);
      }
    }
    public string Стоимость {
      get {
        return Convert.ToString(стоимость);
      }
      set {
        стоимость = Convert.ToInt32(value);
      }
    }
    static public void Время(Билет билет) {
      if (билет.Дата > DateTime.Now) Console.WriteLine(true);
      else Console.WriteLine(false);
    }
    static public void Show(Билет[] массив) {
      foreach(Билет билет in массив) Console.WriteLine(билет.Наименование + " " + билет.Дата + " " + билет.Стоимость);
    }

    static public void Фильтр(Билет[] массив, DateTime дата) {
      var selectedDate = from p in массив
      where p.Дата > дата
      orderby p.Дата
      select p;
      foreach(Билет билет in selectedDate) Console.WriteLine(билет.Наименование + " " + билет.Дата + " " + билет.Стоимость);
    }
    static public void Сорт(Билет[] массив) {
      var selectedDate = from p in массив
      orderby p.Дата
      select p;
      foreach(Билет билет in selectedDate) Console.WriteLine(билет.Наименование + " " + билет.Дата + " " + билет.Стоимость);
    }
  }
  /* public int this[int стоимость]
  {
  get { return Array[стоимость]; }
  }
  int[] Array;*/
}
