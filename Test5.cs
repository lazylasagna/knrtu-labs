class Program {
  static void Main() {
    List < Product > products = new List < Product > ();
    products.Add(new Product("Молоко", 100, new DateTime(2023, 01, 01)));
    products.Add(new Product("Яйца", 200, new DateTime(2023, 01, 04)));
    products.Add(new Product("Хлопья", 300, new DateTime(2024, 10, 04)));
    Console.WriteLine(products[0] > products[1]);
    Product.Linq1(products);
    Console.WriteLine();
    Product.Linq2(products);
    Product.Text(products[0]);
  }
  class Product {
    public Product(string название, int калорийность, DateTime срок) {
      this.название = название;
      this.калорийность = калорийность;
      this.срок = срок;
    }
    string название;
    int калорийность;
    DateTime срок;
    public int Калорийность {
      get;
      set;
    }
    public static bool operator < (Product product1, Product product2) {
      return product1.калорийность < product2.калорийность;
    }
    public static bool operator > (Product product1, Product product2) {
      return product1.калорийность > product2.калорийность;
    }
    public static void Linq1(List < Product > array) {
      var selected_products = from p in array
      where p.срок < DateTime.Now
      select p;
      foreach(var product in selected_products) Console.WriteLine($"{product.название} {product.калорийность} {product.срок}");
    }
    public static void Linq2(List < Product > array) {
      var selected_products = from p in array
      orderby p.калорийность
      select p;
      foreach(var product in selected_products) Console.WriteLine($"{product.название} {product.калорийность} {product.срок}");
    }
    static public void Text(Product product) {
      StreamWriter sw = new StreamWriter("D:\\tetxt.txt");
      sw.WriteLine($"{product.название} {product.калорийность} {product.срок}");
      sw.Close();
    }
  }
}
