using System;

namespace E02._Radians_to_Degrees
{
  class Program
  {
    static void Main(string[] args)
    {
      double radians = double.Parse(Console.ReadLine());
      double degrees = radians * 180 / Math.PI;

      Console.WriteLine(degrees); // 0.7854 → 45.00010522957485
    }
  }
}
