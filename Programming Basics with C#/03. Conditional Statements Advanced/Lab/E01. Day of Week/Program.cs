using System;

namespace E01._Day_of_Week
{
  class Program
  {
    static void Main(string[] args)
    {
      int number = int.Parse(Console.ReadLine());
      string dayOfTheWeek;

      switch (number)
      {
        case 1:
          dayOfTheWeek = "Monday";
          break;
        case 2:
          dayOfTheWeek = "Tuesday";
          break;
        case 3:
          dayOfTheWeek = "Wednesday";
          break;
        case 4:
          dayOfTheWeek = "Thursday";
          break;
        case 5:
          dayOfTheWeek = "Friday";
          break;
        case 6:
          dayOfTheWeek = "Saturday";
          break;
        case 7:
          dayOfTheWeek = "Sunday";
          break;
        default:
          dayOfTheWeek = "Error";
          break;
      }

      Console.WriteLine(dayOfTheWeek); // 5 → Friday
    }
  }
}
