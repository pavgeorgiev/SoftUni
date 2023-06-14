using System;

namespace E04._Vacation_Books_List
{
  class Program
  {
    static void Main(string[] args)
    {
      int bookPages = int.Parse(Console.ReadLine());
      int pagesPerHour = int.Parse(Console.ReadLine());
      int numOfDays = int.Parse(Console.ReadLine());

      int hoursPerDay = bookPages / pagesPerHour / numOfDays;
      Console.WriteLine(hoursPerDay); // 212, 20, 2 → 5
    }
  }
}
