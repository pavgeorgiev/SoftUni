using System;

namespace E06._Oscars
{
  class Program
  {
    static void Main(string[] args)
    {
      string actorName = Console.ReadLine();
      double academyPoints = double.Parse(Console.ReadLine());
      int numAssessors = int.Parse(Console.ReadLine());

      for (int i = 0; i < numAssessors; i++)
      {
        if (academyPoints >= 1250.5) break;

        string assessorName = Console.ReadLine();
        double assessorPoints = double.Parse(Console.ReadLine());

        academyPoints += (assessorName.Length * assessorPoints) / 2;
      }

      if (academyPoints >= 1250.5)
      {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:F1}!");
      }
      else
      {
        Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - academyPoints):F1} more!");
      }
    }
  }
}
