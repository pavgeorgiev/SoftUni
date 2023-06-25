using System;

namespace E07._Hotel_Room
{
  class Program
  {
    static void Main(string[] args)
    {
      string month = Console.ReadLine();
      int numNights = int.Parse(Console.ReadLine());

      double studioPrice = 0;
      double apartmentPrice = 0;

      if (month == "May" || month == "October")
      {
        studioPrice = 50;
        apartmentPrice = 65;

        if (numNights > 14)
        {
          studioPrice *= 0.7;
        }
        else if (numNights > 7)
        {
          studioPrice *= 0.95;
        }
      }
      else if (month == "June" || month == "September")
      {
        studioPrice = 75.20;
        apartmentPrice = 68.70;

        if (numNights > 14)
        {
          studioPrice *= 0.8;
        }
      }
      else if (month == "July" || month == "August")
      {
        studioPrice = 76;
        apartmentPrice = 77;
      }

      if (numNights > 14)
      {
        apartmentPrice *= 0.9;
      }

      double studioTotalCost = studioPrice * numNights;
      double apartmentTotalCost = apartmentPrice * numNights;

      Console.WriteLine($"Apartment: {apartmentTotalCost:F2} lv.");
      Console.WriteLine($"Studio: {studioTotalCost:F2} lv.");
    }
  }
}
