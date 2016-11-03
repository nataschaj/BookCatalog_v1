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
            // Add code that can add the given Book object to the list
            books.Add(aBook);
        }

        public void PrintAllBooks()
        {
            // Add code that can print all books in the list
            // Hint: You will need a repetition statement
            foreach (Book nobooks in books)
            {
                Console.WriteLine(nobooks.GetAllInformation());
            }
        }

        public Book LookupBook(string isbn)
        {
            Book matchingBook = null;

            // Add code that will find a book (if any) in the list
            // which has a matching ISBN number. The variable matchingBook
            // should be set to this book
            // Hint: You will need a repetition statement

            // Look through all the books in the List
            foreach (Book morebooks in books)
            {
                if (morebooks.GetISBN() == isbn) // We got a match!
                {
                    matchingBook = morebooks; // Now matchingBook refers to the book with the matching ISBN
                }
            }


            return matchingBook;
        }
    }
}
