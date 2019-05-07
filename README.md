# C# practice

## C# Sharp Basic Declarations and Expressions : Exercises, Practice, Solution

https://www.w3resource.com/csharp-exercises/basic/index.php

<details>
  <summary>
  Table of Contents
  <summary>

- [C# practice](#c-practice)
  - [C# Sharp Basic Declarations and Expressions : Exercises, Practice, Solution](#c-sharp-basic-declarations-and-expressions--exercises-practice-solution)
    - [Exercise 1](#exercise-1)
    - [Exercise 2](#exercise-2)
    - [Exercise 3](#exercise-3)
    - [Exercise 4](#exercise-4)
    - [Exercise 5](#exercise-5)
    - [Exercise 6](#exercise-6)
    - [Exercise 7](#exercise-7)
    - [Exercise 8](#exercise-8)
    - [Exercise 9](#exercise-9)
    - [Exercise 10](#exercise-10)
    - [Exercise 11](#exercise-11)
    - [Exercise 12](#exercise-12)
    - [Exercise 13](#exercise-13)
    - [Exercise 14](#exercise-14)
    - [Exercise 15](#exercise-15)
    - [Exercise 16](#exercise-16)
    - [Exercise 17](#exercise-17)
    - [Exercise 18](#exercise-18)
    - [Exercise 19](#exercise-19)
    - [Exercise 20](#exercise-20)
      </details>

### Exercise 1

Write a C# Sharp program to print Hello and your name in a separate line.

Expected Output :

- Hello
- Alexandra Abramov

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

### Exercise 2

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

### Exercise 3

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

### Exercise 4

Write a C# Sharp program to print the result of the specified operations:

- -1 + 4 \* 6
- ( 35+ 5 ) % 7
- 14 + -4 \* 6 / 11
- 2 + 15 / 6 \* 1 - 7 % 2

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

### Exercise 5

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
    Console.Write("Input the First Number: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Input the Second Number: ");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("After Swapping: ");
    Console.WriteLine("First Number: " + b);
    Console.WriteLine("Second Number: " + a);
  }
}
```

### Exercise 6

Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.

Test Data:

- Input the first number to multiply: 2
- Input the second number to multiply: 3
- Input the third number to multiply: 6

Expected Output:

- 2 x 3 x 6 = 36

```cs
class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Input the first number to multiply: ");
      double a = double.Parse(Console.ReadLine());
      Console.Write("Input the second number to multiply: ");
      double b = double.Parse(Console.ReadLine());
      Console.Write("Input the third number to multiply: ");
      double c = double.Parse(Console.ReadLine());
      Console.WriteLine($"{a} x {b} x {c} = {a * b * c}");
    }
  }
```

### Exercise 7

Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.

Test Data:

- Input the first number: 25
- Input the second number: 4

Expected Output:

- 25 + 4 = 29
- 25 - 4 = 21
- 25 x 4 = 100
- 25 / 4 = 6
- 25 mod 4 = 1

```cs
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Input the first number to multiply: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Input the second number to multiply: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine($"{a} + {b} = {a + b}");
    Console.WriteLine($"{a} - {b} = {a - b}");
    Console.WriteLine($"{a} x {b} = {a * b}");
    Console.WriteLine($"{a} / {b} = {a / b}");
    Console.WriteLine($"{a} mod {b} = {a % b}");
  }
}
```

### Exercise 8

Write a C# Sharp program that takes a number as input and print its multiplication table.

Test Data:

- Enter the number: 5

Expected Output:

- 5 \* 0 = 0
- 5 \* 1 = 5
- 5 \* 2 = 10
- 5 \* 3 = 15

```cs
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter the number: ");
    int a = int.Parse(Console.ReadLine());

    for (int i = 0; i <= 10; i++)
    {
      Console.WriteLine($"{a} x {i} = {a * i}");
    }
  }
}
```

### Exercise 9

Write a C# Sharp program that takes four numbers as input to calculate and print the average.

Test Data:

- Enter the First number: 10
- Enter the Second number: 15
- Enter the third number: 20
- Enter the four number: 30

Expected Output:

- The average of 10 , 15 , 20 , 30 is: 18

```cs
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter the first number: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Enter the second number: ");
    double b = double.Parse(Console.ReadLine());
    Console.Write("Enter the third number: ");
    double c = double.Parse(Console.ReadLine());
    Console.Write("Enter the four number: ");
    double d = double.Parse(Console.ReadLine());
    double average = (a + b + c + d) / 4;
    Console.WriteLine($"The average of  {a}, {b}, {c}, {d} is: {average}");
  }
}
```

### Exercise 10

Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z

Test Data:

- Enter first number - 5
- Enter second number - 6
- Enter third number - 7

Expected Output:

- Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72

```cs
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter the first number: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Enter the second number: ");
    double y = double.Parse(Console.ReadLine());
    Console.Write("Enter the third number: ");
    double z = double.Parse(Console.ReadLine());
    double result1 = (x + y) * z;
    double result2 = x * y + y * z;
    Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, (x+y).z is {result1} and x.y + y.z is {result2}");
  }
}
```

### Exercise 11

Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20"

Test Data:

- Enter your age - 25

Expected Output:

- You look older than 25

```cs
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter your age: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine($"You look older than {x}");
  }
}
```

### Exercise 12

Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.

Test Data:

- Enter a digit: 25

Expected Output:

- 25 25 25 25
- 25252525
- 25 25 25 25
- 25252525

```cs
static void Main(string[] args)
{
  Console.Write("Enter a digit: ");
  int x = int.Parse(Console.ReadLine());

  for (int i = 0; i < 2; i++)
  {
    Console.WriteLine($"{x} {x} {x} {x}");
    Console.WriteLine($"{x}{x}{x}{x}");
  }
}
```

### Exercise 13

Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.

Test Data:

- Enter a number: 5

Expected Output:

- 555
- 5 5
- 5 5
- 5 5
- 555

```cs

```

### Exercise 14

Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.

Test Data:

- Enter the amount of celsius: 30

Expected Output:

- Kelvin = 303
- Fahrenheit = 86

```cs
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter the amount of celsius: ");
    double celsius = double.Parse(Console.ReadLine());
    double kelvin = celsius + 273.15;
    double fahrenheit = (celsius * 9 + (32 * 5)) / 5;

    Console.WriteLine($"Kelvin = {kelvin}");
    Console.WriteLine($"Fahrenheit = {fahrenheit}");
  }
}
```

### Exercise 15

Write a C# program remove specified a character from a non-empty string using index of a character.

Test Data:

- w3resource

Sample Output:

- wresource
- w3resourc
- 3resource

```cs
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter your word: ");
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
```

### Exercise 16

Write a C# program to create a new string from a given string where the first and last characters will change their positions.

Test Data:

- w3resource
- Python

Sample Output:

- e3resourcw
- nythoP
- x

```cs
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter your word: ");
    string text = Console.ReadLine();
    Console.WriteLine(SwitchFirstLastLetter(text));
  }

  static string SwitchFirstLastLetter(string word)
  {
    int wordLength = word.Length;
    char firstLetter = word[0];
    char lastLetter = word[wordLength - 1];
    char[] wordChars = word.ToCharArray();

    wordChars[0] = lastLetter;
    wordChars[wordLength - 1] = firstLetter;

    return new string(wordChars);
  }
}
```

Or other solution

```cs
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter your word: ");
    string text = Console.ReadLine();
    Console.WriteLine(SwitchFirstLastLetter(text));
  }

  static string SwitchFirstLastLetter(string word)
  {
    int wordLength = word.Length;

    return (wordLength > 1) ? word.Substring(wordLength - 1) + word.Substring(1, wordLength - 2) + word.Substring(0, 1) : word;
  }
}
```

### Exercise 17

Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.

Sample Output:

- Input a string : The quick brown fox jumps over the lazy dog.
- TThe quick brown fox jumps over the lazy dog.T

```cs
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Input a string : ");
    string text = Console.ReadLine();

    if (text.Length > 0)
    {
      Console.WriteLine(text.Substring(0, 1) + text + text.Substring(0, 1));
    }
  }
}
```

### Exercise 18

```cs

```

### Exercise 19

```cs

```

### Exercise 20

```cs

```
