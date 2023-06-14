using System;

namespace E03._Deposit_Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      double depositAmount = double.Parse(Console.ReadLine());
      int depositMonths = int.Parse(Console.ReadLine());
      double interestRate = double.Parse(Console.ReadLine()) / 100;

      double sum = depositAmount + depositMonths * ((depositAmount * interestRate) / 12);
      Console.WriteLine(sum); // 200, 3, 5.7 → 202.85
    }
  }
}
