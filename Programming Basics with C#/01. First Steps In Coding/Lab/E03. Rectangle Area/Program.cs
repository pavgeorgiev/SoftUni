﻿using System;

namespace E03._Rectangle_Area
{
  class Program
  {
    static void Main(string[] args)
    {
      int length = int.Parse(Console.ReadLine());
      int width = int.Parse(Console.ReadLine());

      int area = length * width;
      Console.WriteLine(area); // 5, 7 → 35
    }
  }
}
