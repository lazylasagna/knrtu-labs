using System;
using System.Xml.Linq;

class Set {
  int count;
  int[] elements;
  public Set() {
    this.count = Convert.ToInt32(Console.ReadLine());
    elements = Fill();
  }
  public Set(int[] a) {
    elements = a;
  }

  public int[] Fill() {
    int[] fill = new int[count];
    for (int i = 0; i < count; i++) fill[i] = Convert.ToInt32(Console.ReadLine());
    return fill;
  }
  public void ShowSet() {
    Console.Write("Элементы множества: ");
    foreach(int element in elements) Console.Write(element + " ");
  }
  public void IndexOf(int Value) {
    Console.Write("\n" + "Индекс '" + Value + "': ");
    int n = 0;
    for (int i = 0; i < elements.Length; i++)
      if (elements[i] == Value) {
        n = i;
        break;
      }
    if (n != 0) Console.WriteLine(n);
    else Console.WriteLine(-1);
  }
  public void Add(int NewElement) {
    Array.Resize(ref elements, elements.Length + 1);
    elements[elements.Length - 1] = NewElement;
  }
  public static Set operator++(Set set1) {
    for (int i = 0; i < set1.elements.Length; i++) set1.elements[i]++;
    return set1;
  }
  public static Set operator * (Set set1, Set set2) {
    Console.WriteLine("\n" + "Пересечение");
    foreach(int element in set1.elements) {
      if (set2.elements.Contains(element)) {
        Console.Write(element + " ");
      }
    }
    return set1;

  }
  public static Set operator + (Set set1, Set set2) {
    Console.WriteLine("\n" + "Объединение");
    foreach(int element in set1.elements) {
      if (!set2.elements.Contains(element)) {
        Console.Write(element + " ");
      }
    }
    foreach(int element in set2.elements) Console.Write(element + " ");
    return set1;
  }
  public static Set operator / (Set set1, Set set2) {
    Console.WriteLine("\n" + "Разность");
    foreach(int element in set1.elements) {
      if (!set2.elements.Contains(element)) {
        Console.Write(element + " ");
      }
    }
    return set1;
  }
  public static bool operator < (Set set1, Set set2) {
    Console.WriteLine();
    return set1.elements.Length < set2.elements.Length;
  }
  public static bool operator > (Set set1, Set set2) {
    Console.WriteLine();
    return set1.elements.Length > set2.elements.Length;
  }

}
class Program {
  static void Main() {
    int[] a1 = {
      5,
      4,
      3,
      2,
      1
    };
    Set a = new Set(a1);
    Set b = new Set();
    b.Add(5);
    b.ShowSet();
    b.IndexOf(5);
    b++;
    b.ShowSet();
    Set c = a + b;
    Set d = a * b;
    Set e = a / b;
    Console.WriteLine(a > b);

  }
}
