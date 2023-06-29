using System;

namespace E08._Number_Sequence
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = int.Parse(Console.ReadLine());

      int smallest = int.MaxValue;
      int largest = int.MinValue;

      for (int i = 0; i < n; i++)
      {
        int number = int.Parse(Console.ReadLine());
        
        if (number < smallest)
        {
          smallest = number;
        }

        if (number > largest)
        {
          largest = number;
        }
      }

      Console.WriteLine("Max number: " + largest);
      Console.WriteLine("Min number: " + smallest);
    }
  }
}
