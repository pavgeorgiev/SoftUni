using System;

namespace E03._Time_Plus_15_Minutes
{
  class Program
  {
    static void Main(string[] args)
    {
      int hour = int.Parse(Console.ReadLine());
      int minutes = int.Parse(Console.ReadLine());

      int totalMinutes = (hour * 60) + minutes + 15;
      int newHour = totalMinutes / 60 % 24;
      int newMinutes = totalMinutes % 60;

      Console.WriteLine($"{newHour}:{newMinutes:D2}"); // 23, 59 → 0:14
    }
  }
}
