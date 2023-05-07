/*using System;
using System.Data;
using static System.Math;

namespace Lab6
{
class Program
{
static void Main()
{
string l = "язык программирования C#";
string l1 = "";
int k = 0;
while (l.LastIndexOf(" ") > 0)
{
for (int i = l.LastIndexOf(" ") + 1; i < l.Length; i++)
{
l1 += l[i];
}
l1 += " ";
l = l.Remove(l.LastIndexOf(" "));
}
l1 = l1 + l;
Console.WriteLine(l1);
l = "язык программирования C#";
l1 = "";
for (int i = l.Length - 1; i >= 0; i--)
{
l1 += l[i];
}
Console.WriteLine(l1);
}
}
}*/

using System;
using System.Data;
using static System.Math;
using static System.Net.Mime.MediaTypeNames;

namespace Lab6 {
  class Program {
    static void Main() //4 2
    {
      string text = Console.ReadLine();
      string[] words = text.Split(new char[] {
        ' '
      });
      string word1;
      string wordik = "";
      foreach(string word in words) {
        word1 = word;
        if (word1.LastIndexOf(',') > 0) word1 = word.Remove(word.LastIndexOf(','));
        if (word1.LastIndexOf('.') > 0) word1 = word.Remove(word.LastIndexOf('.'));
        if (wordik.Length < word1.Length) wordik = word1;
      } //Я пошел погулять, зашел в магазин.
      int k = wordik.Length;
      Console.WriteLine(wordik.Length + " " + wordik);

    }
  }
}
