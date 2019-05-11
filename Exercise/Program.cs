using System;
using System.Text.RegularExpressions;
//using System.Collections.Generic;
//using System.Linq;

namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Text: ");
      string text = Console.ReadLine();

      Console.WriteLine(IsPalindrome(text));
    }
    static bool IsPalindrome(string text)
    {
      string letters = Regex.Replace(text.ToLower(), @"[^A-Za-z0-9]+", String.Empty);
      char[] chars = letters.ToCharArray();
      Array.Reverse(chars);

      return (letters.Equals(new string(chars)));
    }
  }
}