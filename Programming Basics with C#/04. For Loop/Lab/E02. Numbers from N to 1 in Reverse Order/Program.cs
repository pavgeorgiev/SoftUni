using System;

namespace E02._Numbers_from_N_to_1_in_Reverse_Order
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = int.Parse(Console.ReadLine());

      for (int i = n; i > 0; i--)
      {
        Console.WriteLine(i);
      }
    }
  }
}
