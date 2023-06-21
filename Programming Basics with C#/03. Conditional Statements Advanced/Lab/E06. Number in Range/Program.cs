using System;

namespace E06._Number_in_Range
{
  class Program
  {
    static void Main(string[] args)
    {
      double number = double.Parse(Console.ReadLine());

      if (number != 0 && number >= -100 && number <= 100)
      {
        Console.WriteLine("Yes"); // 25 → Yes
      }
      else
      {
        Console.WriteLine("No");
      }
    }
  }
}
