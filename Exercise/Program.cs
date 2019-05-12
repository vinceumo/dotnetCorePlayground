using System;
using System.Linq;
// using System.Collections;
//using System.Text.RegularExpressions;
//using System.Collections.Generic;
//using System.Linq;

namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = sortArrWithException(new int[] { 1, 77, -5, 0, -99, 4, -5, 3 }, -5);
      Console.WriteLine(string.Join(", ", arr));
    }
    static int[] sortArrWithException(int[] args, int exception)
    {
      int[] numbers = args.Where(x => x != exception).OrderBy(x => x).ToArray();
      int i = 0;

      return args.Select(x => x != exception ? numbers[i++] : exception).ToArray();
    }
  }
}