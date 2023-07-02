using System;

namespace E02._Half_Sum_Element
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = int.Parse(Console.ReadLine());
      int sum = 0;
      int biggestNum = int.MinValue;

      for (int i = 0; i < n; i++)
      {
        int num = int.Parse(Console.ReadLine());

        if (num > biggestNum)
        {
          biggestNum = num;
        }

        sum += num;
      }

      int diff = (sum - biggestNum) - biggestNum;

      if (diff == 0)
      {
        Console.WriteLine("Yes");
        Console.WriteLine($"Sum = {biggestNum}");
      }
      else
      {
        Console.WriteLine("No");
        Console.WriteLine($"Diff = {Math.Abs(diff)}");
      }
    }
  }
}
