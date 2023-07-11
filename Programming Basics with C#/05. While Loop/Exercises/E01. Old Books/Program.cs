using System;

namespace E01._Old_Books
{
  class Program
  {
    static void Main(string[] args)
    {
      string favoriteBook = Console.ReadLine();
      int numCheckedBooks = 0;

      string book = Console.ReadLine();
      while (book != "No More Books" && book != favoriteBook)
      {
        numCheckedBooks++;
        book = Console.ReadLine();
      }

      if (book == favoriteBook)
      {
        Console.WriteLine($"You checked {numCheckedBooks} books and found it.");
      }
      else
      {
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {numCheckedBooks} books.");
      }
    }
  }
}
