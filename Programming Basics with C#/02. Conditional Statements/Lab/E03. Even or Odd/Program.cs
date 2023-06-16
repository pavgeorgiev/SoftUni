using System;

namespace E03._Even_or_Odd
{
  class Program
  {
    static void Main(string[] args)
    {
      int num = int.Parse(Console.ReadLine());

      if (num % 2 == 0)
      {
        Console.WriteLine("even"); // 1024 → even
      }
      else
      {
        Console.WriteLine("odd");
      }
    }
  }
}
