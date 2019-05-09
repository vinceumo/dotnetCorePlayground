using System;


namespace Exercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Hexadecimal number: ");
      string hexNumber = Console.ReadLine();
      int decimalNumber = Convert.ToInt32(hexNumber, 16);

      Console.WriteLine($"Decimal number: {decimalNumber}");
    }
  }
}
