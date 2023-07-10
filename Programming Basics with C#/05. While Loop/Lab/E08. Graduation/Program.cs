using System;

namespace E08._Graduation
{
  class Program
  {
    static void Main(string[] args)
    {
      string studentName = Console.ReadLine();
      double totalGrades = 0;
      int completedGrades = 0;
      int expelledGrade = 0;
      int currentGrade = 1;

      while (currentGrade <= 12)
      {
        double annualGrade = double.Parse(Console.ReadLine());

        if (annualGrade >= 4.00)
        {
          totalGrades += annualGrade;
          completedGrades++;
          currentGrade++;
        }
        else
        {
          expelledGrade = currentGrade;
          break;
        }
      }

      if (completedGrades == 12)
      {
        double averageGrade = totalGrades / completedGrades;
        Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
      }
      else
      {
        Console.WriteLine($"{studentName} has been excluded at {expelledGrade} grade");
      }
    }
  }
}
