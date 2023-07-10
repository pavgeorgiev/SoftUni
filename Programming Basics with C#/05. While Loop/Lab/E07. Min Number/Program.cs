using System;

namespace E07._Min_Number
{
  class Program
  {
    static void Main(string[] args)
    {
      int smallestNumber = int.MaxValue;

      string input = Console.ReadLine();
      while (input != "Stop")
      {
        int num = int.Parse(input);

        if (num < smallestNumber)
        {
          smallestNumber = num;
        }

        input = Console.ReadLine();
      }

      Console.WriteLine(smallestNumber);
    }
  }
}
