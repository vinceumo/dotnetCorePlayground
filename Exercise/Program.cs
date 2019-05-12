using System;
//using System.Text.RegularExpressions;
//using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(IsIncreasingSequence(new int[] { 1, 2, 3, 8, 6, 9 }));
      Console.WriteLine(IsIncreasingSequence(new int[] { 0, 2, 10 }));
      Console.WriteLine(IsIncreasingSequence(new int[] { 1, 8, 1, 3 }));
      Console.WriteLine(IsIncreasingSequence(new int[] { 1, 2, 3 }));
    }
    static bool IsIncreasingSequence(int[] args)
    {
      int[] sortArgs = (int[])args.Clone();
      Array.Sort(sortArgs);
      return (args.SequenceEqual(sortArgs));
    }
  }
}