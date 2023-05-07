using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApplication1 {
  class Sudno {
    public string name;
    public static int massa = 1000;
    public Sudno() {
      this.name = "Без названия";
    }
    public Sudno(string name) {
      this.name = name;
    }
    public virtual void Show() {
      Console.WriteLine("Судно {0}, масса = {1} кг", name, massa);
    }
  }
  class Korabl: Sudno {
    public Korabl() {
      vod = 0;
    }
    public Korabl(string name, int vod): base(name) {
      this.vod = vod;
    }
    public override void Show() {
      Console.WriteLine("Судно {0}, масса = {1} кг, водоизмещение = {2} кг", name, massa, vod);
    }
    int vod;
  }
  class Parohod: Sudno {
    public Parohod() {
      height = 0;
    }
    public Parohod(string name, int height): base(name) {
      this.height = height;
    }
    public override void Show() {
      Console.WriteLine("Судно {0}, масса = {1} кг, высота = {2} м", name, massa, height);
    }
    int height;
  }
  class Kater: Sudno {
    public Kater() {
      speed = 0;
    }
    public Kater(string name, int speed): base(name) {
      this.speed = speed;
    }
    public override void Show() {
      Console.WriteLine("Судно {0}, масса = {1} кг, скорость = {2} м/c", name, massa, speed);
    }
    int speed;
  }
  class Program {
    static void Main() {
      Sudno[] arr = new Sudno[4];
      arr[0] = new Sudno("Лодка");
      arr[1] = new Korabl("Корабль", 999);
      arr[2] = new Parohod("Пароход", 30);
      arr[3] = new Kater("Катер", 150);
      for (int i = 0; i < 4; i++) arr[i].Show();
    }
  }
}
