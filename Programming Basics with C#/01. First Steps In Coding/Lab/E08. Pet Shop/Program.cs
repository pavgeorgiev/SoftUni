using System;

namespace E08._Pet_Shop
{
  class Program
  {
    static void Main(string[] args)
    {
      int dogFoodPackages = int.Parse(Console.ReadLine());
      int catFoodPackages = int.Parse(Console.ReadLine());
      double dogFoodPrice = 2.5;
      int catFoodPrice = 4;
      double totalPrice = (dogFoodPackages * dogFoodPrice) + (catFoodPackages * catFoodPrice);

      Console.WriteLine($"{totalPrice} lv."); // 5, 4 → 28.5 lv.
    }
  }
}
