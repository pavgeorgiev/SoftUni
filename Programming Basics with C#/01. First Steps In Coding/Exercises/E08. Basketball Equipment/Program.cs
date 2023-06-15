using System;

namespace E08._Basketball_Equipment
{
  class Program
  {
    static void Main(string[] args)
    {
      int annualFee = int.Parse(Console.ReadLine());
      double shoesPrice = annualFee * 0.6;
      double outfitPrice = shoesPrice * 0.8;
      double ballPrice = outfitPrice / 4;
      double accessoriesPrice = ballPrice / 5;

      double totalPrice = annualFee + shoesPrice + outfitPrice + ballPrice + accessoriesPrice;
      Console.WriteLine(totalPrice); // 365 → 811.76
    }
  }
}
