using System;

namespace E08._Tennis_Ranklist
{
  class Program
  {
    static void Main(string[] args)
    {
      int numTournaments = int.Parse(Console.ReadLine());
      int startingPoints = int.Parse(Console.ReadLine());
      double pointsEarned = 0;
      int tournamentsWon = 0;

      for (int i = 0; i < numTournaments; i++)
      {
        string stageReached = Console.ReadLine();

        switch (stageReached)
        {
          case "W":
            pointsEarned += 2000;
            tournamentsWon++;
            break;
          case "F":
            pointsEarned += 1200;
            break;
          case "SF":
            pointsEarned += 720;
            break;
        }
      }

      double finalPoints = startingPoints + pointsEarned;
      double averagePoints = pointsEarned / numTournaments;
      double percentageTournamentsWon = ((double)tournamentsWon / numTournaments) * 100;

      Console.WriteLine($"Final points: {finalPoints}");
      Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
      Console.WriteLine($"{percentageTournamentsWon:F2}%");
    }
  }
}
