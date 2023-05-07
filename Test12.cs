class Program {
  static void Main() {
    List < Sphere > spheres = new List < Sphere > ();
    spheres.Add(new Sphere(10));
    spheres.Add(new Sphere(5));
    spheres.Add(new Sphere(12));
    Console.WriteLine(spheres[0] + spheres[1]);
    Sphere.Linq1(spheres);
    Sphere.Linq2(spheres);
  }
  class Sphere {
    public Sphere(int radius) {
      this.radius = radius;
    }
    int radius;
    public double V() {
      return 4 / 3 * Math.PI * Math.Pow(radius, 3);
    }
    public static double operator + (Sphere sphere1, Sphere sphere2) {
      return sphere1.V() + sphere2.V();
    }
    public static void Linq1(List < Sphere > spheres) {
      var selected_ = from p in spheres
      orderby - p.radius
      select p;
      foreach(Sphere sphere in selected_) Console.WriteLine($"{sphere.radius}");

    }
    public static void Linq2(List < Sphere > spheres) {
      var selected_ = from p in spheres
      orderby - p.V()
      select p;
      foreach(Sphere sphere in selected_) {
        Console.WriteLine($"{sphere.V()}");
        break;
      }

    }
  }
}
