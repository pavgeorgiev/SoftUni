using System;

namespace E09._Fish_Tank
{
  class Program
  {
    static void Main(string[] args)
    {
      int length = int.Parse(Console.ReadLine());
      int width = int.Parse(Console.ReadLine());
      int height = int.Parse(Console.ReadLine());
      double occupiedPercentage = double.Parse(Console.ReadLine()) / 100;

      double volume = length * width * height;
      double cubicDecimeters = volume / 1000;


      Console.WriteLine(cubicDecimeters * (1 - occupiedPercentage));
      // 85, 75, 47, 17 → 248.68875
    }
  }
}
