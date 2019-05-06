https://www.w3resource.com/csharp-exercises/basic/index.php

## Exercise 1

Write a C# Sharp program to print Hello and your name in a separate line.

Expected Output : 

Hello

Alexandra Abramov

```cs
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello");
    Console.WriteLine("Vince");
  }
}
```

## Exercise 2

Write a C# Sharp program to print the sum of two numbers

```cs
class Program
{
  static void Main(string[] args)
  {
    int a = 39;
    int b = 73;

    Console.WriteLine(a + b);
  }
}
```

## Exercise 3

Write a C# Sharp program to print the result of dividing two numbers.

```cs
class Program
{
  static void Main(string[] args)
  {
    double a = 43;
    double b = 2;

    Console.WriteLine(a / b);
  }
}
```

## Exercise 4

Write a C# Sharp program to print the result of the specified operations:

- -1 + 4 * 6
- ( 35+ 5 ) % 7
- 14 + -4 * 6 / 11
- 2 + 15 / 6 * 1 - 7 % 2

Expected Output:

- 23
- 5
- 12
- 3

```cs
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine(-1 + 4 * 6);
    Console.WriteLine((35 + 5) % 7);
    Console.WriteLine(14 + -4 * 6 / 11);
    Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
  }
}
```

## Exercise 5

Write a C# Sharp program to swap two numbers.

Test Data:
- Input the First Number : 5
- Input the Second Number : 6
- Expected Output: 
- After Swapping :
- First Number : 6 
- Second Number : 5 

```cs
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Input the First Number:");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Input the Second Number:");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("After Swapping:");
    Console.WriteLine("First Number: " + b);
    Console.WriteLine("Second Number: " + a);
  }
}
```

## Exercise 6

Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.

Test Data:

- Input the first number to multiply: 2
- Input the second number to multiply: 3
- Input the third number to multiply: 6
- Expected Output:
- 2 x 3 x 6 = 36

```cs
class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Input the first number to multiply:");
      double a = double.Parse(Console.ReadLine());
      Console.Write("Input the second number to multiply:");
      double b = double.Parse(Console.ReadLine());
      Console.Write("Input the third number to multiply:");
      double c = double.Parse(Console.ReadLine());
      Console.WriteLine($"{a} x {b} x {c} = {a * b * c}");
    }
  }
```