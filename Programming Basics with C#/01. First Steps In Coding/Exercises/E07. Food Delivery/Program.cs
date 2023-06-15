using System;

namespace E07._Food_Delivery
{
  class Program
  {
    static void Main(string[] args)
    {
      double chickenMenusPrice = double.Parse(Console.ReadLine()) * 10.35;
      double fishMenusPrice = double.Parse(Console.ReadLine()) * 12.40;
      double vegetarianMenusPrice = double.Parse(Console.ReadLine()) * 8.15;
      double deliveryCost = 2.50;

      double totalMenusPrice = chickenMenusPrice + fishMenusPrice + vegetarianMenusPrice;
      double dessertPrice = totalMenusPrice * 0.2;
      double totalCost = totalMenusPrice + dessertPrice + deliveryCost;

      Console.WriteLine(totalCost); // 2, 4, 3 → 116.2
    }
  }
}
