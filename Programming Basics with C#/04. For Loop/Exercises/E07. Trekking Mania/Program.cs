using System;

namespace E07._Trekking_Mania
{
  class Program
  {
    static void Main(string[] args)
    {
      int numOfGroups = int.Parse(Console.ReadLine());
      double totalNumOfPeople = 0;
      int musalaPeople = 0;
      int montBlancPeople = 0;
      int kilimanjaroPeople = 0;
      int k2People = 0;
      int everestPeople = 0;

      for (int i = 0; i < numOfGroups; i++)
      {
        int groupPeople = int.Parse(Console.ReadLine());
        totalNumOfPeople += groupPeople;

        if (groupPeople <= 5)
        {
          musalaPeople += groupPeople;
        }
        else if (groupPeople <= 12)
        {
          montBlancPeople += groupPeople;
        }
        else if (groupPeople <= 25)
        {
          kilimanjaroPeople += groupPeople;
        }
        else if (groupPeople <= 40)
        {
          k2People += groupPeople;
        }
        else
        {
          everestPeople += groupPeople;
        }
      }

      double musalaPeoplePercentage = musalaPeople / totalNumOfPeople * 100;
      double montBlancPeoplePercentage = montBlancPeople / totalNumOfPeople * 100;
      double kilimanjaroPeoplePercentage = kilimanjaroPeople / totalNumOfPeople * 100;
      double k2PeoplePercentage = k2People / totalNumOfPeople * 100;
      double everestPeoplePercentage = everestPeople / totalNumOfPeople * 100;

      Console.WriteLine($"{musalaPeoplePercentage:F2}%");
      Console.WriteLine($"{montBlancPeoplePercentage:F2}%");
      Console.WriteLine($"{kilimanjaroPeoplePercentage:F2}%");
      Console.WriteLine($"{k2PeoplePercentage:F2}%");
      Console.WriteLine($"{everestPeoplePercentage:F2}%");
    }
  }
}
