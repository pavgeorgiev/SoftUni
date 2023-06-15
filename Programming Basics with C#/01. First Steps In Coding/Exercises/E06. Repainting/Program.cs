using System;

namespace E06._Repainting
{
  class Program
  {
    static void Main(string[] args)
    {
      double nylonPrice = (double.Parse(Console.ReadLine()) + 2) * 1.5;
      double paintPrice = (double.Parse(Console.ReadLine()) * 1.1) * 14.50;
      double thinnerPrice = double.Parse(Console.ReadLine()) * 5;
      double bagsPrice = 0.40;
      int workCompletionHours = int.Parse(Console.ReadLine());

      double totalMaterialsCost = nylonPrice + paintPrice + thinnerPrice + bagsPrice;
      double workCompletedCost = (totalMaterialsCost * 0.3) * workCompletionHours;
      double totalCost = totalMaterialsCost + workCompletedCost;

      Console.WriteLine(totalCost); // 5, 10, 10, 1 → 727.09
    }
  }
}
