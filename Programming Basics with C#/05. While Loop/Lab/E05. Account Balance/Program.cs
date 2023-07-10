using System;

namespace E05._Account_Balance
{
  class Program
  {
    static void Main(string[] args)
    {
      double accountBalance = 0;

      string input = Console.ReadLine();
      while (input != "NoMoreMoney")
      {
        double num = double.Parse(input);

        if (num < 0)
        {
          Console.WriteLine("Invalid operation!");
          break;
        }

        accountBalance += num;
        Console.WriteLine($"Increase: {num:F2}");
        input = Console.ReadLine();
      }

      Console.WriteLine($"Total: {accountBalance:F2}");
    }
  }
}
