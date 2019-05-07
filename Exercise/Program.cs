using System;

namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Input a string : ");
      string text = Console.ReadLine();

      if (text.Length > 0)
      {
        Console.WriteLine(text.Substring(0, 1) + text + text.Substring(0, 1));
      }
    }
  }
}
