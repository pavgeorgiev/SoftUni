using System;

namespace E02._Weekend_or_Working_Day
{
  class Program
  {
    static void Main(string[] args)
    {
      string dayOfTheWeek = Console.ReadLine();

      switch (dayOfTheWeek)
      {
        case "Monday":
        case "Tuesday":
        case "Thursday":
        case "Wednesday":
        case "Friday":
          Console.WriteLine("Working day");
          break;
        case "Saturday":
        case "Sunday":
          Console.WriteLine("Weekend"); // Sunday → Weekend
          break;
        default:
          Console.WriteLine("Error");
          break;
      }
    }
  }
}
