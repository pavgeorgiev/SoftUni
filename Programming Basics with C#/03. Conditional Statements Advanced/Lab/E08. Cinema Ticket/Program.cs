using System;

namespace E08._Cinema_Ticket
{
  class Program
  {
    static void Main(string[] args)
    {
      string dayOfWeek = Console.ReadLine();
      int ticketPrice = 0;

      switch (dayOfWeek)
      {
        case "Monday":
          ticketPrice = 12;
          break;
        case "Tuesday":
          ticketPrice = 12;
          break;
        case "Wednesday":
          ticketPrice = 14;
          break;
        case "Thursday":
          ticketPrice = 14;
          break;
        case "Friday":
          ticketPrice = 12;
          break;
        case "Saturday":
          ticketPrice = 16;
          break;
        case "Sunday":
          ticketPrice = 16;
          break;
      }

      Console.WriteLine(ticketPrice); // Friday → 12
    }
  }
}
