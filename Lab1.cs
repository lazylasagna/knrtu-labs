using System;
using System.Data;
using static System.Math;

namespace Lab2
{
class Program
{

static void Main()
{
double dx = Convert.ToDouble(Console.ReadLine());
double x = -10;
//Console.WriteLine(x);
while (x <= 8)
{
if (x >= -10 && x <= -8)
{
Console.Write("y(" + Convert.ToString(x) + ")"+ " = ");
Console.WriteLine(-3);
}
else if (x >= -8 && x <= -3)
{
Console.Write("y(" + Convert.ToString(x) + ")" + " = ");
Console.WriteLine(Convert.ToString(x / 2 - 1));
}
else if (x>=-3 && x<=3)
{
Console.Write("y(" + Convert.ToString(x) + ")" + " = ");
Console.WriteLine(Convert.ToString(Math.Round(Math.Sqrt(Math.Pow(x, 2) - 9))));
{
else if (x>=3 && x <= 5)
{
Console.Write("y(" + Convert.ToString(x) + ")" + " = ");
Console.WriteLine(Convert.ToString(x-3));
}
else if (x>=5 && x<=8)
{
Console.Write("y(" + Convert.ToString(x) + ")" + " = ");
Console.WriteLine(3);
}
x += dx;

}
}
}
}