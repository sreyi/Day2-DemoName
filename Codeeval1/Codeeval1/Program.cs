using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter book's title:\n");
        string title = Console.ReadLine();

        Console.Write("Enter book's author:\n");
        string author = Console.ReadLine();

        Console.Write("Enter book's year:\n");
        int year = Convert.ToInt32(Console.ReadLine());

        Book book = new Book(title, author, year);
        Console.WriteLine("Book Title: " + book.Title);
        Console.WriteLine("Book Author: " + book.Author);
        Console.WriteLine("Book Year: " + book.Year);
    }
}