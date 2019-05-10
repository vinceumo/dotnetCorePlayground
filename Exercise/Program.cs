using System;

namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = new int[2];
      int numberToCompare = 20;

      Console.Write("Input first integer: ");
      numbers[0] = int.Parse(Console.ReadLine());
      Console.Write("Input second integer: ");
      numbers[1] = int.Parse(Console.ReadLine());

      int[] difference = { Math.Abs(numberToCompare - numbers[0]), Math.Abs(numberToCompare - numbers[1]) };

      int closestNumber = (difference[0] == difference[1]) ? 0 : (difference[0] > difference[1]) ? numbers[1] : numbers[0];

      Console.WriteLine(closestNumber);
    }
  }
}