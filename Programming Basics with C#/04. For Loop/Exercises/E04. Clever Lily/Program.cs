using System;

namespace E04._Clever_Lily
{
  class Program
  {
    static void Main(string[] args)
    {
      int age = int.Parse(Console.ReadLine());
      double washingMachinePrice = double.Parse(Console.ReadLine());
      int toyPrice = int.Parse(Console.ReadLine());
      double totalMoney = 0;
      int moneyReceived = 10;

      for (int i = 1; i <= age; i++)
      {
        if (i % 2 == 0)
        {
          totalMoney += moneyReceived - 1;
          moneyReceived += 10;
        }
        else
        {
          totalMoney += toyPrice;
        }
      }

      if (totalMoney < washingMachinePrice)
      {
        Console.WriteLine($"No! {washingMachinePrice - totalMoney:F2}");
      }
      else
      {
        Console.WriteLine($"Yes! {totalMoney - washingMachinePrice:F2}");
      }
    }
  }
}
