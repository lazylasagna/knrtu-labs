using System;
using System.Linq;

class Program {
  static void Main() {
    Bank_card[] bank = new Bank_card[3];
    Bank_card Тинькофф = new Bank_card(1, "Иванов", 1500000);
    Bank_card Сбер = new Bank_card(2, "Иванов", 2000000);
    Bank_card Газпром = new Bank_card(3, "Орлов", 3000000);
    bank[0] = Тинькофф;
    bank[1] = Сбер;
    bank[2] = Газпром;
    Тинькофф.Расчет();
    Console.WriteLine((Тинькофф + Сбер).Bank_account);
    Bank_card.Linq1(bank);
    Bank_card.Linq2(bank, "Иванов");
  }

  class Bank_card {
    public Bank_card(int number, string name, int bank_account) {
      this.number = number;
      this.name = name;
      this.bank_account = bank_account;
    }
    int number;
    string name;
    int bank_account;
    public int Bank_account {
      get {
        return bank_account;
      }
      set {
        bank_account = value;
      }
    }
    public void Расчет() {
      bank_account -= 1400000;
    }
    public void Show() {
      Console.WriteLine(Convert.ToString(number) + " " + bank_account);
    }
    public static Bank_card operator + (Bank_card a, Bank_card b) {
      return new Bank_card(a.number + b.number, a.name, a.bank_account + b.bank_account);
    }
    static public void Linq1(Bank_card[] array) {
      string a = "";
      var selected_account = from p in array
      group p by p.name;
      foreach(var account in selected_account) {
        int count = 0;
        foreach(var p in account) {
          a = p.name;
          count++;
        }
        Console.WriteLine(a + " " + count);
      }
    }
    static public void Linq2(Bank_card[] array, string name) {
      int summ = 0;
      var selected_account = from p in array
      where p.name == name
      select p;
      foreach(var account in selected_account) {
        summ += account.Bank_account;
      }
      Console.WriteLine(summ);
    }

  }
}
