using System;

namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter a digit: ");
      int x = int.Parse(Console.ReadLine());

      Console.WriteLine($"{x}{x}{x}");
      Console.WriteLine($"{x} {x}");
      Console.WriteLine($"{x} {x}");
      Console.WriteLine($"{x} {x}");
      Console.WriteLine($"{x}{x}{x}");
    }
  }
}
