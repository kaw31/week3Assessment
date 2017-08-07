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
            //string response;
            string title;
            string author;
            int isbn;
            int price;

            //string bookToAdd; 
            string bookToDelete;

            List<Book> bookList = new List<Book>();

            Console.WriteLine("Here is your book collection.  To add a book, press A; to delete a book, press D; to list all books, press L:");
            Console.WriteLine("To exit, press X.");
            char response = Convert.ToChar(Console.ReadLine().ToUpper());


            //Console.WriteLine("What would you like to do next: A, D, L or X?:");
            //response = Convert.ToChar(Console.ReadLine().ToUpper());

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
            }

            else if (response == 'D')
            {
                Console.WriteLine("Type the name of the book you would like to delete:");
                bookToDelete = Console.ReadLine();
                //bookList.Remove(bookToDelete);
            }

            else if (response == 'L')
            {
                Console.WriteLine("\nHere is the current list of books:\n");
                foreach (Book b in bookList)
                {
                    Console.WriteLine("Title: {0}", b.title);
                    Console.WriteLine("Author: {0} \n", b.author);
                    Console.WriteLine("ISBN: {0} \n", b.isbn);
                    Console.WriteLine("Price: {0} \n", b.price);
                }
            }





            //switch (response)
            //{
            //    case 'A':
            //        Console.WriteLine("Type the name of the book you would like to add:");
            //        bookToAdd = Console.ReadLine();
            //        bookList.Add(bookToAdd);
            //        break;
            //    case 'D':
            //        Console.WriteLine("Type the name of the book you would like to delete:");
            //        bookToDelete = Console.ReadLine();
            //        bookList.Remove(bookToDelete);
            //        break;
            //    case 'L':
            //        for (int i = 0; i < bookList.Count; i++)
            //        {
            //            Console.WriteLine(bookList[i]);
            //        }
            //        break;
            //    case 'S':
            //        bookList.Sort();
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
