using System;

namespace E12._Trade_Commissions
{
  class Program
  {
    static void Main(string[] args)
    {
      string city = Console.ReadLine();
      double sales = double.Parse(Console.ReadLine());
      double commission = 0;
      bool isValid = true;

      if (sales >= 0 && sales <= 500)
      {
        switch (city)
        {
          case "Sofia":
            commission = 0.05;
            break;
          case "Varna":
            commission = 0.045;
            break;
          case "Plovdiv":
            commission = 0.055;
            break;
          default:
            isValid = false;
            break;
        }
      }
      else if (sales >= 500 && sales <= 1000)
      {
        switch (city)
        {
          case "Sofia":
            commission = 0.07;
            break;
          case "Varna":
            commission = 0.075;
            break;
          case "Plovdiv":
            commission = 0.080;
            break;
          default:
            isValid = false;
            break;
        }
      }
      else if (sales >= 1000 && sales <= 10000)
      {
        switch (city)
        {
          case "Sofia":
            commission = 0.08;
            break;
          case "Varna":
            commission = 0.10;
            break;
          case "Plovdiv":
            commission = 0.12;
            break;
          default:
            isValid = false;
            break;
        }
      }
      else if (sales > 10000)
      {
        switch (city)
        {
          case "Sofia":
            commission = 0.12;
            break;
          case "Varna":
            commission = 0.13;
            break;
          case "Plovdiv":
            commission = 0.145;
            break;
          default:
            isValid = false;
            break;
        }
      }
      else
      {
        isValid = false;
      }

      if (isValid)
      {
        Console.WriteLine("{0:F2}", sales * commission);
      }
      else
      {
        Console.WriteLine("error");
      }
    }
  }
}
