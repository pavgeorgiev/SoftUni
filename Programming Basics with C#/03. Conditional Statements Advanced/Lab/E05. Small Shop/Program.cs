using System;

namespace E05._Small_Shop
{
  class Program
  {
    static void Main(string[] args)
    {
      string product = Console.ReadLine();
      string city = Console.ReadLine();
      double quantity = double.Parse(Console.ReadLine());
      double price = 0;

      if (product == "coffee")
      {
        switch (city)
        {
          case "Sofia":
            price = 0.50;
            break;
          case "Plovdiv":
            price = 0.40;
            break;
          case "Varna":
            price = 0.45;
            break;
        }
      }
      else if (product == "water")
      {
        switch (city)
        {
          case "Sofia":
            price = 0.80;
            break;
          case "Plovdiv":
            price = 0.70;
            break;
          case "Varna":
            price = 0.70;
            break;
        }
      }
      else if (product == "beer")
      {
        switch (city)
        {
          case "Sofia":
            price = 1.20;
            break;
          case "Plovdiv":
            price = 1.15;
            break;
          case "Varna":
            price = 1.10;
            break;
        }
      }
      else if (product == "sweets")
      {
        switch (city)
        {
          case "Sofia":
            price = 1.45;
            break;
          case "Plovdiv":
            price = 1.30;
            break;
          case "Varna":
            price = 1.35;
            break;
        }
      }
      else if (product == "peanuts")
      {
        switch (city)
        {
          case "Sofia":
            price = 1.60;
            break;
          case "Plovdiv":
            price = 1.50;
            break;
          case "Varna":
            price = 1.55;
            break;
        }
      }

      Console.WriteLine(price * quantity); // water, Plovdiv, 2 → 1.4
    }
  }
}
