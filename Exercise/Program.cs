using System;

namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Input the first number to multiply:");
      double a = double.Parse(Console.ReadLine());
      Console.Write("Input the second number to multiply:");
      double b = double.Parse(Console.ReadLine());
      Console.Write("Input the third number to multiply:");
      double c = double.Parse(Console.ReadLine());
      Console.WriteLine($"{a} x {b} x {c} = {a * b * c}");
    }
  }
}
