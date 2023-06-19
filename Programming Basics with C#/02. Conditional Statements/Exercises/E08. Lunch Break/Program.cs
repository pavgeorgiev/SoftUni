using System;

namespace E08._Lunch_Break
{
  class Program
  {
    static void Main(string[] args)
    {
      string seriesName = Console.ReadLine();
      int episodeLength = int.Parse(Console.ReadLine());
      int lunchBreakLength = int.Parse(Console.ReadLine());

      double lunchTime = lunchBreakLength / 8.0;
      double restTime = lunchBreakLength / 4.0;
      double remainingTime = lunchBreakLength - lunchTime - restTime - episodeLength;

      if (remainingTime >= 0)
      {
        Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(remainingTime)} minutes free time.");
        // Game of Thrones, 60, 96 → You have enough time to watch Game of Thrones and left with 0 minutes free time.
      }
      else
      {
        Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(Math.Abs(remainingTime))} more minutes.");
      }
    }
  }
}
