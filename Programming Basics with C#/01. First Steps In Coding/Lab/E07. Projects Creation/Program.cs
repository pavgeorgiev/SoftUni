using System;

namespace E07._Projects_Creation
{
  class Program
  {
    static void Main(string[] args)
    {
      string architectName = Console.ReadLine();
      int numOfProjects = int.Parse(Console.ReadLine());
      int hoursNeeded = numOfProjects * 3;

      Console.WriteLine($"The architect {architectName} will need {hoursNeeded} hours to complete {numOfProjects} project/s.");
      // Pavel, 2 → The architect Pavel will need 6 hours to complete 2 project/s.
    }
  }
}
