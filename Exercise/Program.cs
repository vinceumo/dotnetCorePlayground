using System;

namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter your word:");
      string text = Console.ReadLine();

      for (int i = 0; i < 3; i++)
      {
        Console.WriteLine(RemoveRandomLetter(text));
      }
    }

    static string RemoveRandomLetter(string word)
    {
      int wordLength = word.Length;
      Random random = new Random();
      int indexToRemove = random.Next(0, wordLength - 1);

      return word.Remove(indexToRemove, 1);
    }
  }
}
