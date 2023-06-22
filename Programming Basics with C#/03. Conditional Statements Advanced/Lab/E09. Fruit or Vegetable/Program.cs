using System;

namespace E09._Fruit_or_Vegetable
{
  class Program
  {
    static void Main(string[] args)
    {
      string productName = Console.ReadLine();
      string category;

      switch (productName)
      {
        case "banana":
        case "apple":
        case "kiwi":
        case "cherry":
        case "lemon":
        case "grapes":
          category = "fruit";
          break;
        case "tomato":
        case "cucumber":
        case "pepper":
        case "carrot":
          category = "vegetable";
          break;
        default:
          category = "unknown";
          break;
      }

      Console.WriteLine(category); // apple → fruit
    }
  }
}
