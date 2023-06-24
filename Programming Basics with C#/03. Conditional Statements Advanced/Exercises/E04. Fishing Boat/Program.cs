using System;

namespace E04._Fishing_Boat
{
  class Program
  {
    static void Main(string[] args)
    {
      int groupBudget = int.Parse(Console.ReadLine());
      string season = Console.ReadLine();
      int numberOfFishermen = int.Parse(Console.ReadLine());
      double shipRentalCost = 0;

      if (season == "Spring")
      {
        shipRentalCost = 3000;
      }
      else if (season == "Summer" || season == "Autumn")
      {
        shipRentalCost = 4200;
      }
      else if (season == "Winter")
      {
        shipRentalCost = 2600;
      }

      if (numberOfFishermen <= 6)
      {
        shipRentalCost *= 0.90;
      }
      else if (numberOfFishermen >= 7 && numberOfFishermen <= 11)
      {
        shipRentalCost *= 0.85;
      }
      else if (numberOfFishermen >= 12)
      {
        shipRentalCost *= 0.75;
      }

      if (season != "Autumn" && numberOfFishermen % 2 == 0)
      {
        shipRentalCost *= 0.95;
      }

      double moneyLeft = groupBudget - shipRentalCost;

      if (moneyLeft >= 0)
      {
        Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
      }
      else
      {
        Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):F2} leva.");
      }
    }
  }
}
