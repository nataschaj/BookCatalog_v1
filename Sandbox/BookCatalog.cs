using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class BookCatalog
    {
        private List<Book> books;

        public BookCatalog()
        {
            books = new List<Book>();
        }

        public void AddBook(Book aBook)
        {
            // Add the given Book object to the List
            books.Add(aBook);
        }

        public void PrintAllBooks()
        {
            // For all the books, print out the information for each book
            foreach (Book b in books)
            {
                Console.WriteLine(b.GetAllInformation());
            }
        }

        public Book LookupBook(string isbn)
        {
            Book matchingBook = null;

            // Look through all the books in the List
            foreach (Book b in books)
            {
                if (b.GetISBN() == isbn) // We got a match!
                {
                    matchingBook = b; // Now matchingBook refers to the book with the matching ISBN
                }
            }

            return matchingBook;
        }
    }
}
