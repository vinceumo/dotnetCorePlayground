using System;


namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] array1 = { 1, 3, -5, 4 };
      int[] array2 = { 1, 4, -5, -2 };
      int shortestArrLength = (array1.Length > array2.Length) ? array2.Length : array1.Length;
      int[] multiplyArr = new int[shortestArrLength];

      for (int i = 0; i < shortestArrLength; i++)
      {
        multiplyArr[i] = array1[i] * array2[i];
      }

      string result = string.Join(", ", multiplyArr);

      Console.WriteLine($"Decimal number: {result}");
    }
  }
}
