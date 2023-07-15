using System;

namespace E03._Vacation
{
  class Program
  {
    static void Main(string[] args)
    {
      double targetAmount = double.Parse(Console.ReadLine());
      double availableAmount = double.Parse(Console.ReadLine());

      int savedDays = 0;
      int spendDays = 0;

      while (availableAmount < targetAmount && spendDays < 5)
      {
        string action = Console.ReadLine();
        double amount = double.Parse(Console.ReadLine());

        if (action == "save")
        {
          availableAmount += amount;
          savedDays++;
          spendDays = 0;
        }
        else if (action == "spend")
        {
          availableAmount -= amount;
          spendDays++;
          savedDays++;
          if (availableAmount < 0)
          {
            availableAmount = 0;
          }
        }
      }

      if (spendDays == 5)
      {
        Console.WriteLine("You can't save the money.");
        Console.WriteLine(savedDays);
      }
      else
      {
        Console.WriteLine($"You saved the money for {savedDays} days.");
      }
    }
  }
}
