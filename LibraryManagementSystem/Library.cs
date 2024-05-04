using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library
    {
        private readonly List<Book> _books= new();
        private readonly List<Book> _borrowedBooks = new();

        public void Add(Book book)
        {
           _books.Add(book);
        }

        public void Remove(Book book)
        {
           _books.Remove(book);
        }

        public void Display()
        {
            Console.WriteLine("\t\t=================================================================");
            Console.WriteLine("\t\tBook Title\t\tBook Author\t\tBook Year");
            Console.WriteLine("\t\t=================================================================");
            foreach (Book book in _books) { 
                Console.Write(book);
           }
        }
        public void BorrowBook(Book book)
        {
            _borrowedBooks.Add(book);
        }

        public void DisplayBorrowedBooks()
        {
            Console.WriteLine("\t\t=================================================================");
            Console.WriteLine("\t\tBook Title\t\tBook Author\t\tBook Year");
            Console.WriteLine("\t\t=================================================================");
            foreach (Book book in _borrowedBooks)
            {
                Console.Write(book);
            }
        }
    }
}
