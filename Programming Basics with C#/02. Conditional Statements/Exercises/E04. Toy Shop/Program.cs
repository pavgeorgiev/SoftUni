using System;

namespace E04._Toy_Shop
{
  class Program
  {
    static void Main(string[] args)
    {
      double puzzlePrice = 2.60;
      double talkingDollPrice = 3;
      double teddyBearPrice = 4.10;
      double minionPrice = 8.20;
      double truckPrice = 2;

      double excursionPrice = double.Parse(Console.ReadLine());
      double puzzleCount = double.Parse(Console.ReadLine());
      double talkingDollCount = double.Parse(Console.ReadLine());
      double teddyBearCount = double.Parse(Console.ReadLine());
      double minionCount = double.Parse(Console.ReadLine());
      double truckCount = double.Parse(Console.ReadLine());

      double totalToys = puzzleCount + talkingDollCount + teddyBearCount + minionCount + truckCount;
      double totalToysPrice = (puzzleCount * puzzlePrice) + (talkingDollCount * talkingDollPrice) + (teddyBearCount * teddyBearPrice) + (minionCount * minionPrice) + (truckCount * truckPrice);

      if (totalToys >= 50)
      {
        totalToysPrice *= 0.75;
      }

      totalToysPrice *= 0.90;
      double remainingMoney = totalToysPrice - excursionPrice;

      if (remainingMoney >= 0)
      {
        Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
        // 40.8, 20, 25, 30, 50, 10 → Yes! 418.20 lv left.
      }
      else
      {
        Console.WriteLine($"Not enough money! {Math.Abs(remainingMoney):F2} lv needed.");
      }
    }
  }
}
