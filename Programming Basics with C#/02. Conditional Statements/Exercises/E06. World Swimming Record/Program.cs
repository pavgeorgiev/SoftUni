using System;

namespace E06._World_Swimming_Record
{
  class Program
  {
    static void Main(string[] args)
    {
      double oldRecordInSeconds = double.Parse(Console.ReadLine());
      double distanceInMeters = double.Parse(Console.ReadLine());
      double timePerMeterInSeconds = double.Parse(Console.ReadLine());

      double newRecordInSeconds = distanceInMeters * timePerMeterInSeconds;

      double delayInSeconds = Math.Floor(distanceInMeters / 15.0) * 12.5;
      newRecordInSeconds += delayInSeconds;

      if (newRecordInSeconds < oldRecordInSeconds)
      {
        Console.WriteLine($"Yes, he succeeded! The new world record is {newRecordInSeconds:F2} seconds.");
      }
      else
      {
        double neededSeconds = newRecordInSeconds - oldRecordInSeconds;
        Console.WriteLine($"No, he failed! He was {neededSeconds:F2} seconds slower.");
        // 10464, 1500, 20 → No, he failed! He was 20786.00 seconds slower.
      }
    }
  }
}
