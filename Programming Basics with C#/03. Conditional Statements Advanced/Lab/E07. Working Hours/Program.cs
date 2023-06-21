using System;

namespace E07._Working_Hours
{
  class Program
  {
    static void Main(string[] args)
    {
      int hourOfDay = int.Parse(Console.ReadLine());
      string dayOfWeek = Console.ReadLine();

      if (hourOfDay >= 10 && hourOfDay <= 18 && dayOfWeek != "Sunday")
      {
        Console.WriteLine("open"); // 11, Monday → open
      }
      else
      {
        Console.WriteLine("closed");
      }
    }
  }
}
