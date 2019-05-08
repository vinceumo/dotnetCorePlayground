using System;
using System.Linq;

namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Input a number(integer): ");
      string numbers = Console.ReadLine();
      int total = 0;

      foreach (char number in numbers)
      {
        total += int.Parse(number.ToString());
      }

      Console.WriteLine($"Sum of the digits of the {numbers} integer: {total}");
    }
  }
}
