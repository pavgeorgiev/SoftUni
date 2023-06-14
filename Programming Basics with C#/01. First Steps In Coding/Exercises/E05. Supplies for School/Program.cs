using System;

namespace E05._Supplies_for_School
{
  class Program
  {
    static void Main(string[] args)
    {
      double pensPrice = double.Parse(Console.ReadLine()) * 5.80;
      double markersPrice = double.Parse(Console.ReadLine()) * 7.20;
      double chalkboardCleanerPrice = double.Parse(Console.ReadLine()) * 1.20;
      double discount = double.Parse(Console.ReadLine()) / 100;

      double total = pensPrice + markersPrice + chalkboardCleanerPrice;
      double discountedTotal = total - (total * discount);

      Console.WriteLine(discountedTotal); // 2, 3, 4, 25 → 28.5
    }
  }
}
