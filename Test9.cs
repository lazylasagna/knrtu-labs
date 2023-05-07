class Program {
  static void Main() {
    List < VKR > vkrs = new List < VKR > (3);
    vkrs.Add(new VKR("Тема1", "ФИО1", 70));
    vkrs.Add(new VKR("Тема2", "ФИО2", 60));
    vkrs.Add(new VKR("Тема3", "ФИО3", 30));
    vkrs.Sort();
    foreach(VKR vkr in vkrs) Console.WriteLine($"{vkr.tema} {vkr.FIO} {vkr.orig}");
    VKR.Linq1(vkrs);
    VKR.Linq2(vkrs);
  }
  class VKR: IComparable < VKR > {
    public VKR(string tema, string fIO, int orig) {
      this.tema = tema;
      this.FIO = fIO;
      this.orig = orig;
    }
    public string tema;
    public string FIO;
    public int orig;
    public void Status() {
      if (orig >= 60) Console.Write(" Принят");
      else Console.Write(" Переделать");
    }

    static public void Linq1(List < VKR > array) {
      var selected_ = from p in array
      group p by p.orig;
      foreach(var item in selected_) {
        foreach(var i in item) {
          Console.Write($"{i.tema} {i.FIO} {i.orig}");
          i.Status();
          Console.WriteLine();
        }
      }
    }
    static public void Linq2(List < VKR > array) {
      int count = 0;
      var selected_ = from p in array
      select p;
      foreach(var item in selected_) {
        count += item.orig;
      }
      Console.WriteLine(count / array.Count);
    }

    public int CompareTo(VKR ? vkr) {
      return -vkr.orig;
    }
  }
}
