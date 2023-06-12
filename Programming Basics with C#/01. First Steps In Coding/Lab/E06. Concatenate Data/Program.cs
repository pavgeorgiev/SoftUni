using System;

namespace E06._Concatenate_Data
{
  class Program
  {
    static void Main(string[] args)
    {
      string firstName = Console.ReadLine();
      string lastName = Console.ReadLine();
      int age = int.Parse(Console.ReadLine());
      string town = Console.ReadLine();

      Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
      // Pavel, Georgiev, 23, Sofia → You are Pavel Georgiev, a 23-years old person from Sofia.
    }
  }
}
