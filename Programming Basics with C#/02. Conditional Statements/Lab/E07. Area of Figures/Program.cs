using System;

namespace E07._Area_of_Figures
{
  class Program
  {
    static void Main(string[] args)
    {
      string figureType = Console.ReadLine();
      double area;

      if (figureType == "square")
      {
        double a = double.Parse(Console.ReadLine());
        area = a * a;
      }
      else if (figureType == "rectangle")
      {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        area = a * b;
      }
      else if (figureType == "circle")
      {
        double a = double.Parse(Console.ReadLine());
        area = a * a * Math.PI;
      }
      else
      {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        area = (a * b) / 2;
      }

      Console.WriteLine($"{area:F3}");
    }
  }
}
