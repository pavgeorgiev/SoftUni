using System;

namespace E01._USD_to_BGN
{
  class Program
  {
    static void Main(string[] args)
    {
      double usd = double.Parse(Console.ReadLine());
      double bgn = usd * 1.79549;

      Console.WriteLine(bgn); // 3.1416 → 180.0004209182994
    }
  }
}
