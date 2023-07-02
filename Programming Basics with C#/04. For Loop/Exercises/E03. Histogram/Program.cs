using System;

namespace E03._Histogram
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = int.Parse(Console.ReadLine());
      int p1Nums = 0;
      int p2Nums = 0;
      int p3Nums = 0;
      int p4Nums = 0;
      int p5Nums = 0;

      for (int i = 0; i < n; i++)
      {
        int num = int.Parse(Console.ReadLine());

        if (num < 200)
        {
          p1Nums++;
        }
        else if (num < 400)
        {
          p2Nums++;
        }
        else if (num < 600)
        {
          p3Nums++;
        }
        else if (num < 800)
        {
          p4Nums++;
        }
        else
        {
          p5Nums++;
        }
      }

      Console.WriteLine($"{((double)p1Nums / n * 100):F2}%");
      Console.WriteLine($"{((double)p2Nums / n * 100):F2}%");
      Console.WriteLine($"{((double)p3Nums / n * 100):F2}%");
      Console.WriteLine($"{((double)p4Nums / n * 100):F2}%");
      Console.WriteLine($"{((double)p5Nums / n * 100):F2}%");
    }
  }
}
