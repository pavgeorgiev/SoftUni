using System;

namespace E09._Ski_Trip
{
  class Program
  {
    static void Main(string[] args)
    {
      int numberOfNights = int.Parse(Console.ReadLine()) - 1;
      string roomType = Console.ReadLine();
      string rating = Console.ReadLine();

      double totalSum;

      if (roomType == "room for one person")
      {
        totalSum = numberOfNights * 18;
      }
      else if (roomType == "apartment")
      {
        totalSum = numberOfNights * 25;
        if (numberOfNights < 10)
        {
          totalSum *= 0.7;
        }
        else if (numberOfNights <= 15)
        {
          totalSum *= 0.65;
        }
        else
        {
          totalSum *= 0.5;
        }
      }
      else
      {
        totalSum = numberOfNights * 35;
        if (numberOfNights < 10)
        {
          totalSum *= 0.9;
        }
        else if (numberOfNights <= 15)
        {
          totalSum *= 0.85;
        }
        else
        {
          totalSum *= 0.8;
        }
      }

      if (rating == "positive")
      {
        totalSum *= 1.25;
      }
      else
      {
        totalSum *= 0.9;
      }

      Console.WriteLine($"{totalSum:F2}");
    }
  }
}
