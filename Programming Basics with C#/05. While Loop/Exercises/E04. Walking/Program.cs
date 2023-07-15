using System;

namespace E04._Walking
{
  class Program
  {
    static void Main(string[] args)
    {
      int goal = 10000;
      int totalSteps = 0;

      while (totalSteps < goal)
      {
        string input = Console.ReadLine();

        if (input == "Going home")
        {
          int stepsOnWayHome = int.Parse(Console.ReadLine());
          totalSteps += stepsOnWayHome;
          break;
        }

        int steps = int.Parse(input);
        totalSteps += steps;
      }

      if (totalSteps >= goal)
      {
        int difference = totalSteps - goal;
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{difference} steps over the goal!");
      }

      if (totalSteps < goal)
      {
        int difference = goal - totalSteps;
        Console.WriteLine($"{difference} more steps to reach goal.");
      }
    }
  }
}
