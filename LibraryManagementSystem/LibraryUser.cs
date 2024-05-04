using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class LibraryUser: User
    {
        public LibraryCard Card;

        public LibraryUser(string name,LibraryCard Card): base(name)
        {
            this.Card = Card;
        }

        public void BorrowBook(Book book,Library library)
        {
            library.BorrowBook(book);
        }

    }
}
