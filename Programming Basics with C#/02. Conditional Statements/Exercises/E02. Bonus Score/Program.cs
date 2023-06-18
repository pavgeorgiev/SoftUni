using System;

namespace E02._Bonus_Score
{
  class Program
  {
    static void Main(string[] args)
    {
      int num = int.Parse(Console.ReadLine());
      double bonusPoints = 0;

      if (num > 1000)
      {
        bonusPoints += num * 0.1;
      }
      else if (num > 100)
      {
        bonusPoints += num * 0.2;
      }
      else
      {
        bonusPoints += 5;
      }

      if (num % 2 == 0)
      {
        bonusPoints++;
      }

      if (num % 10 == 5)
      {
        bonusPoints += 2;
      }

      Console.WriteLine(bonusPoints); // 175 → 37
      Console.WriteLine(num + bonusPoints); // 175 → 212
    }
  }
}
