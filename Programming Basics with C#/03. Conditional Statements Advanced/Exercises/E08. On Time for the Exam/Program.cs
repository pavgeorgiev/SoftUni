using System;

namespace E08._On_Time_for_the_Exam
{
  class Program
  {
    static void Main(string[] args)
    {
      int examHours = int.Parse(Console.ReadLine());
      int examMinutes = int.Parse(Console.ReadLine());
      int arrivalHours = int.Parse(Console.ReadLine());
      int arrivalMinutes = int.Parse(Console.ReadLine());

      int arrivalTotalMinutes = arrivalHours * 60 + arrivalMinutes;
      int examTotalMinutes = examHours * 60 + examMinutes;

      if (examTotalMinutes < arrivalTotalMinutes)
      {
        Console.WriteLine("Late");
        int minutesDifference = arrivalTotalMinutes - examTotalMinutes;

        if (minutesDifference < 60)
        {
          Console.WriteLine($"{minutesDifference} minutes after the start");
        }
        else
        {
          int hours = minutesDifference / 60;
          int minutes = minutesDifference % 60;
          Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
        }
      }
      else if (examTotalMinutes - 30 > arrivalTotalMinutes)
      {
        Console.WriteLine("Early");
        int minutesDifference = examTotalMinutes - arrivalTotalMinutes;

        if (minutesDifference < 60)
        {
          Console.WriteLine($"{minutesDifference} minutes before the start");
        }
        else
        {
          int hours = minutesDifference / 60;
          int minutes = minutesDifference % 60;

          Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
        }

      }
      else
      {
        int minutesDifference = examTotalMinutes - arrivalTotalMinutes;

        Console.WriteLine("On time");
        Console.WriteLine($"{minutesDifference} minutes before the start");
      }
    }
  }
}
