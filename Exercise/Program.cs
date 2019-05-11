using System;
//using System.Collections.Generic;
//using System.Linq;

namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Year: ");
      int year = int.Parse(Console.ReadLine());
      int century = (year - 1) / 100 + 1;

      Console.WriteLine((year < 1) ? "Please enter starting from 1 AD" : $"Century: {century}");
    }
  }
}