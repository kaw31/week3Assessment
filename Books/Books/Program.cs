using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Book
    {
        public string title;
        public string author;
        public int isbn;
        public int price;

        public static int numberOfBooks;

        public Book(string title, string author, int isbn, int price)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.price = price;

            Book.numberOfBooks++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            string title;
            string author;
            int isbn;
            int price;


            // book list
            List<Book> bookList = new List<Book>();

            char response = ' ';

            // intro heading
            Console.WriteLine("Here is your book collection.  To add a book, press A; to delete a book, press D; to list all books, press L:");
            Console.WriteLine("To exit, press X.");

            do
            {
                // looping question
                Console.WriteLine("What would you like to do next: A (add book), D (delete book), L (list books) or X (exit)?:");
                response = Convert.ToChar(Console.ReadLine().ToUpper());

                // add book
                if (response == 'A')
                {
                    Console.WriteLine("Please enter the book title:");
                    title = Console.ReadLine();
                    Console.WriteLine("Please enter the book's author:");
                    author = Console.ReadLine();
                    Console.WriteLine("Please enter the book's ISBN:");
                    isbn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the price of the book:");
                    price = Convert.ToInt32(Console.ReadLine());

                    Book myBook = new Book(title, author, isbn, price);
                    bookList.Add(myBook);
                    Console.WriteLine("'{0}' by {1} has been added to the list.", title, author);
                    Console.WriteLine();
                }

                // delete book
                else if (response == 'D')
                {
                    Console.WriteLine("Type the name of the book you would like to delete:");
                    title = Console.ReadLine();
                    Console.WriteLine();
                    Book bookToDelete = bookList.Find(item => item.title == title);
                    
                    if (bookToDelete != null)
                    {
                        bookList.Remove(bookToDelete);
                        Console.WriteLine(title + " has been removed from the list.");
                        Console.WriteLine();
                    }
                     else
                    {
                        Console.WriteLine("Your book was not in the list.");
                        Console.WriteLine();
                    }
                }

                // list all books
                else if (response == 'L')
                {
                    Console.WriteLine("\nHere is the current list of books:\n");
                    foreach (Book b in bookList)
                    {
                        Console.WriteLine("Title: {0}", b.title);
                        Console.WriteLine("Author: {0} \n", b.author);
                        Console.WriteLine("ISBN: {0} \n", b.isbn);
                        Console.WriteLine("Price: £{0} \n", b.price);
                    }
                }

                // user inputs wrong key, or word, or number
                

            } while (response != 'X');


        }
    }
}
