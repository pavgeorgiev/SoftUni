using System;

namespace E05._Journey
{
  class Program
  {
    static void Main(string[] args)
    {
      double budget = double.Parse(Console.ReadLine());
      string season = Console.ReadLine();
      string destination = "";
      string accommodationType = "Hotel";
      double accommodationCost = 0;

      if (budget <= 100)
      {
        destination = "Bulgaria";
        if (season == "summer")
        {
          accommodationType = "Camp";
          accommodationCost = budget * 0.30;
        }
        else if (season == "winter")
        {
          accommodationCost = budget * 0.70;
        }
      }
      else if (budget <= 1000)
      {
        destination = "Balkans";
        if (season == "summer")
        {
          accommodationType = "Camp";
          accommodationCost = budget * 0.40;
        }
        else if (season == "winter")
        {
          accommodationCost = budget * 0.80;
        }
      }
      else if (budget >= 1000)
      {
        destination = "Europe";
        accommodationCost = budget * 0.90;
      }

      Console.WriteLine($"Somewhere in {destination}");
      Console.WriteLine($"{accommodationType} - {accommodationCost:F2}");
    }
  }
}
