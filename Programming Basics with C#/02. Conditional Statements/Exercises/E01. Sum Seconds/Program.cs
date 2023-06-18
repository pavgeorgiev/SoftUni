using System;

namespace E01._Sum_Seconds
{
  class Program
  {
    static void Main(string[] args)
    {
      int firstTime = int.Parse(Console.ReadLine());
      int secondTime = int.Parse(Console.ReadLine());
      int thirdTime = int.Parse(Console.ReadLine());

      int totalTime = firstTime + secondTime + thirdTime;
      int seconds = totalTime % 60;
      int minutes = totalTime / 60;

      if (seconds < 10)
      {
        Console.WriteLine($"{minutes}:0{seconds}");
      }
      else
      {
        Console.WriteLine($"{minutes}:{seconds}"); // 50, 50, 49 → 2:29
      }
    }
  }
}
