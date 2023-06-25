using System;

namespace E06._Operations_Between_Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      int N1 = int.Parse(Console.ReadLine());
      int N2 = int.Parse(Console.ReadLine());
      char op = char.Parse(Console.ReadLine());
      string resultStr = "";

      if (op == '+' || op == '-' || op == '*')
      {
        int result = 0;

        if (op == '+')
        {
          result = N1 + N2;
        }
        else if (op == '-')
        {
          result = N1 - N2;
        }
        else if (op == '*')
        {
          result = N1 * N2;
        }

        resultStr = $"{N1} {op} {N2} = {result} - {(result % 2 == 0 ? "even" : "odd")}";
      }
      else if (op == '/')
      {
        if (N2 == 0)
        {
          Console.WriteLine($"Cannot divide {N1} by zero");
          return;
        }

        double result = (double)N1 / N2;
        resultStr = $"{N1} / {N2} = {result:F2}";
      }
      else if (op == '%')
      {
        if (N2 == 0)
        {
          Console.WriteLine($"Cannot divide {N1} by zero");
          return;
        }

        int result = N1 % N2;
        resultStr = $"{N1} % {N2} = {result}";
      }
      else
      {
        Console.WriteLine("Invalid operator");
        return;
      }

      Console.WriteLine(resultStr);
    }
  }
}
