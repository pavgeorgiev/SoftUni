using System;

namespace E01._Excellent_Result
{
  class Program
  {
    static void Main(string[] args)
    {
      double grade = double.Parse(Console.ReadLine());

      if (grade >= 5.50)
      {
        Console.WriteLine("Excellent!"); // 5.50 → Excellent!
      }
    }
  }
}
