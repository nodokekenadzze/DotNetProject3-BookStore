using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of books with their names and prices
        List<Book> books = new List<Book>
        {
            new Book { Name = "The Great Gatsby", Price = 15.99m },
            new Book { Name = "To Kill a Mockingbird", Price = 10.49m },
            new Book { Name = "1984", Price = 8.99m },
            new Book { Name = "Pride and Prejudice", Price = 14.59m },
            new Book { Name = "Moby Dick", Price = 20.99m },
            new Book { Name = "War and Peace", Price = 19.99m },
            new Book { Name = "The Catcher in the Rye", Price = 12.39m },
            new Book { Name = "The Hobbit", Price = 13.49m },
            new Book { Name = "The Lord of the Rings", Price = 30.00m },
            new Book { Name = "Harry Potter and the Sorcerer's Stone", Price = 9.99m }
        };

        // Display all books with their prices
        Console.WriteLine("Books and their prices:");
        foreach (var book in books)
        {
            Console.WriteLine($"- {book.Name}: ${book.Price}");
        }

        // Find the most expensive book by comparing prices
        Book mostExpensiveBook = books[0];  // Start with the first book as the most expensive
        foreach (var book in books)
        {
            if (book.Price > mostExpensiveBook.Price) // If the current book is more expensive, update the most expensive book
            {
                mostExpensiveBook = book;
            }
        }

        // Print the most expensive book and its price
        Console.WriteLine($"\nThe most expensive book is \"{mostExpensiveBook.Name}\" with a price of ${mostExpensiveBook.Price}.");

        // Count how many books cost less than 20
        int count = 0;
        foreach (var book in books)
        {
            if (book.Price < 20) // If the book's price is less than 20, increase the count
            {
                count++;
            }
        }

        // Display the count of books costing less than $20
        Console.WriteLine($"\nNumber of books costing less than $20: {count}");

        // Ask the user to input the amount of money they have
        Console.WriteLine("Enter your amount: ");  // Prompt the user to enter an amount
        
        // Convert the user input to a decimal value
        decimal userMoney = Convert.ToDecimal(Console.ReadLine());

        // Display all books the user can afford based on their money
        Console.WriteLine($"\nBooks you can buy with {userMoney} GEL:");

        // Loop through the list of books using a while loop
        int i = 0;
        while (i < books.Count)
        {
            // If the price of the book is more than the user's money, skip this book and move to the next
            if (books[i].Price > userMoney)
            {
                i++;
                continue; // Skip to the next iteration of the loop
            }

            // If the book is affordable, print its name and price
            Console.WriteLine($"- {books[i].Name}: {books[i].Price} GEL");
            i++; // Move to the next book
        }
    }
}

// Class to represent a book with Name and Price properties
class Book
{
    public string Name { get; set; }  // Property for the book name
    public decimal Price { get; set; } // Property for the book price
}
