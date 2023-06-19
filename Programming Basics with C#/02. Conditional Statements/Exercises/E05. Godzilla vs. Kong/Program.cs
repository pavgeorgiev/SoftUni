using System;

namespace E05._Godzilla_vs._Kong
{
  class Program
  {
    static void Main(string[] args)
    {
      double movieBudget = double.Parse(Console.ReadLine());
      int extraCount = int.Parse(Console.ReadLine());
      double extraClothingCost = double.Parse(Console.ReadLine());

      double decorCost = movieBudget * 0.10;
      double totalClothingCost = extraCount * extraClothingCost;

      if (extraCount > 150)
      {
        totalClothingCost *= 0.90;
      }

      double movieCost = decorCost + totalClothingCost;
      double remainingBudget = movieBudget - movieCost;

      if (remainingBudget < 0)
      {
        Console.WriteLine("Not enough money!");
        Console.WriteLine($"Wingard needs {Math.Abs(remainingBudget):F2} leva more.");
      }
      else
      {
        Console.WriteLine("Action!");
        Console.WriteLine($"Wingard starts filming with {remainingBudget:F2} leva left.");
        /* 20000, 120, 55.5 →
           Action!
           Wingard starts filming with 11340.00 leva left. */
      }
    }
  }
}
