using System;

namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Input first integer: ");
      int x = int.Parse(Console.ReadLine());
      bool test = (Math.Abs(x - 100) <= 10 || Math.Abs(x - 200) <= 10);

      Console.WriteLine($"Result: {test}");
    }
  }
}
