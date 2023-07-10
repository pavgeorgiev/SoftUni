using System;

namespace E06._Max_Number
{
  class Program
  {
    static void Main(string[] args)
    {
      int largestNumber = int.MinValue;

      string input = Console.ReadLine();
      while (input != "Stop")
      {
        int num = int.Parse(input);

        if (num > largestNumber)
        {
          largestNumber = num;
        }

        input = Console.ReadLine();
      }

      Console.WriteLine(largestNumber);
    }
  }
}
