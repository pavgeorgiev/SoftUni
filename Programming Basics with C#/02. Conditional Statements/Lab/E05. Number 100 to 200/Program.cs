﻿using System;

namespace E05._Number_100_to_200
{
  class Program
  {
    static void Main(string[] args)
    {
      int num = int.Parse(Console.ReadLine());

      if (num < 100)
      {
        Console.WriteLine("Less than 100");
      }
      else if (num >= 100 && num <= 200)
      {
        Console.WriteLine("Between 100 and 200");
      }
      else
      {
        Console.WriteLine("Greater than 200"); // 210 → Greater than 200
      }
    }
  }
}
