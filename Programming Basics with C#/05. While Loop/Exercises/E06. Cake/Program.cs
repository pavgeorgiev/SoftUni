using System;

namespace E06._Cake
{
  class Program
  {
    static void Main(string[] args)
    {
      int cakeWidth = int.Parse(Console.ReadLine());
      int cakeLength = int.Parse(Console.ReadLine());
      int cakeSize = cakeWidth * cakeLength;

      while (cakeSize > 0)
      {
        string input = Console.ReadLine();

        if (input == "STOP")
        {
          break;
        }

        int piecesTaken = int.Parse(input);
        cakeSize -= piecesTaken;

        if (cakeSize < 0)
        {
          break;
        }
      }

      if (cakeSize >= 0)
      {
        Console.WriteLine($"{cakeSize} pieces are left.");
      }

      else
      {
        int piecesNeeded = Math.Abs(cakeSize);
        Console.WriteLine($"No more cake left! You need {piecesNeeded} pieces more.");
      }
    }
  }
}
