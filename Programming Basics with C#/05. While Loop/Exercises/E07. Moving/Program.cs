using System;

namespace E07._Moving
{
  class Program
  {
    static void Main(string[] args)
    {
      int width = int.Parse(Console.ReadLine());
      int length = int.Parse(Console.ReadLine());
      int height = int.Parse(Console.ReadLine());

      int freeSpace = width * length * height;
      int usedSpace = 0;

      string input = Console.ReadLine();

      while (input != "Done")
      {
        int boxes = int.Parse(input);
        usedSpace += boxes;

        if (usedSpace >= freeSpace)
        {
          int missingSpace = usedSpace - freeSpace;
          Console.WriteLine($"No more free space! You need {missingSpace} Cubic meters more.");
          return;
        }

        input = Console.ReadLine();
      }

      int remainingSpace = freeSpace - usedSpace;
      Console.WriteLine($"{remainingSpace} Cubic meters left.");
    }
  }
}
