using System;

namespace E10._Odd_Even_Sum
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = int.Parse(Console.ReadLine());
      int oddNumSum = 0;
      int evenNumSum = 0;

      for (int i = 0; i < n; i++)
      {
        int num = int.Parse(Console.ReadLine());

        if (i % 2 != 0)
        {
          oddNumSum += num;
        }
        else
        {
          evenNumSum += num;
        }
      }

      int diff = oddNumSum - evenNumSum;

      if (diff == 0)
      {
        Console.WriteLine("Yes");
        Console.WriteLine($"Sum = {oddNumSum}");
      }
      else
      {
        Console.WriteLine("No");
        Console.WriteLine($"Diff = {Math.Abs(diff)}");
      }
    }
  }
}
