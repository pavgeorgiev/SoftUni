using System;

namespace E09._Yard_Greening
{
  class Program
  {
    static void Main(string[] args)
    {
      double meters = double.Parse(Console.ReadLine());
      double meterPrice = 7.61;
      double discount = 0.18;

      double metersPrice = meters * meterPrice;
      double metersPriceDiscount = discount * metersPrice;
      double finalPrice = metersPrice - metersPriceDiscount;

      Console.WriteLine($"The final price is: {finalPrice:F2} lv."); // 550 → The final price is: 753.39 lv.
      Console.WriteLine($"The discount is: {metersPriceDiscount:F2} lv."); // 550 → The discount is: 3432.11 lv.
    }
  }
}
