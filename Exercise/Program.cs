using System;


namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Input a string ");
      string text = Console.ReadLine();
      string last4Chars = (text.Length > 4) ? text.Substring(text.Length - 4) : text;

      Console.WriteLine($"{last4Chars}{last4Chars}{last4Chars}{last4Chars}");
    }
  }
}
