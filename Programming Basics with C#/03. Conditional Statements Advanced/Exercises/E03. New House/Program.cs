using System;

namespace E03._New_House
{
  class Program
  {
    static void Main(string[] args)
    {
      string flowerType = Console.ReadLine();
      int numberOfFlowers = int.Parse(Console.ReadLine());
      int budget = int.Parse(Console.ReadLine());
      double flowersPrice = 0;

      if (flowerType == "Roses")
      {
        flowersPrice = numberOfFlowers * 5;

        if (numberOfFlowers > 80)
        {
          flowersPrice *= 0.90;
        }
      }
      else if (flowerType == "Dahlias")
      {
        flowersPrice = numberOfFlowers * 3.80;

        if (numberOfFlowers > 90)
        {
          flowersPrice *= 0.85;
        }
      }
      else if (flowerType == "Tulips")
      {
        flowersPrice = numberOfFlowers * 2.80;

        if (numberOfFlowers > 80)
        {
          flowersPrice *= 0.85;
        }
      }
      else if (flowerType == "Narcissus")
      {
        flowersPrice = numberOfFlowers * 3;

        if (numberOfFlowers < 120)
        {
          flowersPrice *= 1.15;
        }
      }
      else if (flowerType == "Gladiolus")
      {
        flowersPrice = numberOfFlowers * 2.50;

        if (numberOfFlowers < 80)
        {
          flowersPrice *= 1.20;
        }
      }

      double moneyLeft = budget - flowersPrice;

      if (moneyLeft >= 0)
      {
        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowerType} and {moneyLeft:F2} leva left.");
        // Tulips, 88, 260 → Hey, you have a great garden with 88 Tulips and 50.56 leva left.
      }
      else
      {
        Console.WriteLine($"Not enough money, you need {Math.Abs(moneyLeft):F2} leva more.");
      }
    }
  }
}
