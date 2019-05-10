using System;


namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Input a string: ");
      string text = Console.ReadLine();
      Console.Write("Word to check: ");
      string wordToCheck = Console.ReadLine();
      string[] words = text.Split(" ");

      Console.WriteLine((wordToCheck == words[0]));
    }
  }
}
