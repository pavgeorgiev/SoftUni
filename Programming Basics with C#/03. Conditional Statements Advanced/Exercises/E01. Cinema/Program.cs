using System;

namespace E01._Cinema
{
  class Program
  {
    static void Main(string[] args)
    {
      string projectionType = Console.ReadLine();
      int seatRows = int.Parse(Console.ReadLine());
      int seatColumns = int.Parse(Console.ReadLine());
      double ticketPrice = 0;

      switch (projectionType)
      {
        case "Premiere":
          ticketPrice = 12.00;
          break;
        case "Normal":
          ticketPrice = 7.50;
          break;
        case "Discount":
          ticketPrice = 5.00;
          break;
      }

      double totalTicketRevenue = (seatRows * seatColumns) * ticketPrice;

      Console.WriteLine($"{totalTicketRevenue:F2} leva");
      // Normal, 21, 13 → 2047.50 leva
    }
  }
}
