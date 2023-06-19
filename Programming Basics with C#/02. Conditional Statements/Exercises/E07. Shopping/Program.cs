using System;

namespace E07._Shopping
{
  class Program
  {
    static void Main(string[] args)
    {
      double budget = double.Parse(Console.ReadLine());
      int graphicsCardsCount = int.Parse(Console.ReadLine());
      int processorsCount = int.Parse(Console.ReadLine());
      int ramMemoriesCount = int.Parse(Console.ReadLine());

      int graphicsCardPrice = 250;
      double graphicsCardsPrice = graphicsCardPrice * graphicsCardsCount;

      double processorPrice = graphicsCardsPrice * 0.35;
      double processorsPrice = processorPrice * processorsCount;

      double ramMemoryPrice = graphicsCardsPrice * 0.10;
      double ramMemoriesPrice = ramMemoryPrice * ramMemoriesCount;

      double totalSum = graphicsCardsPrice + processorsPrice + ramMemoriesPrice;

      if (graphicsCardsCount > processorsCount)
      {
        totalSum *= 0.85;
      }

      double moneyLeft = budget - totalSum;

      if (moneyLeft >= 0)
      {
        Console.WriteLine($"You have {moneyLeft:F2} leva left!");
        // 900, 2, 1, 3 → You have 198.75 leva left!
      }
      else
      {
        Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):F2} leva more!");
      }
    }
  }
}
