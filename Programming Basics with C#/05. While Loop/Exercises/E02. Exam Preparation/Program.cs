using System;

namespace E02._Exam_Preparation
{
  class Program
  {
    static void Main(string[] args)
    {
      int failedThreshold = int.Parse(Console.ReadLine());
      double gradesSum = 0;
      int solvedProblemsCount = 0;
      string lastProblem = "";
      int failedTimes = 0;

      string currentProblem = Console.ReadLine();
      while (currentProblem != "Enough" && failedTimes < failedThreshold)
      {
        int grade = int.Parse(Console.ReadLine());

        if (grade <= 4)
        {
          failedTimes++;
        }

        gradesSum += grade;
        solvedProblemsCount++;
        lastProblem = currentProblem;
        currentProblem = Console.ReadLine();
      }

      if (failedTimes >= failedThreshold)
      {
        Console.WriteLine($"You need a break, {failedTimes} poor grades.");
      }
      else
      {
        double averageScore = gradesSum / solvedProblemsCount;
        Console.WriteLine($"Average score: {averageScore:F2}");
        Console.WriteLine($"Number of problems: {solvedProblemsCount}");
        Console.WriteLine($"Last problem: {lastProblem}");
      }
    }
  }
}
